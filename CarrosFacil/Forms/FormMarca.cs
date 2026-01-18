using CarrosFacil.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrosFacil
{
    public partial class FormMarca : Form
    {
        public string tipo;
        public int status;

        public FormMarca()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                DefinirCorCamposObrigatorios(Color.FromArgb(179, 221, 255));

                MessageBox.Show("Por favor, preencha todos os campos obrigatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            Marca marca = new Marca();
            marca.nome = tbNome.Text;
            marca.observacao = tbObservacao.Text;
            marca.status = cbStatus.SelectedIndex;

            int resultado = marca.Cadastrar();
            if (resultado == 0) { // ERRO
                MessageBox.Show("Erro ao cadastrar marca.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                MessageBox.Show("Marca: "+marca.nome+" cadastrada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DefinirCorCamposObrigatorios(SystemColors.Window);
                Limpar();
            }
        }

        private bool ValidarCampos()
        {
            if (tbNome.Text == "")
            {
                return false;
            }

            return true;
        }

        private void DefinirCorCamposObrigatorios(Color color)
        {
            tbNome.BackColor = color;
        }

        private void Limpar()
        {
            tbNome.Clear();
            tbObservacao.Clear();
        }

        private void FormMarca_Load(object sender, EventArgs e)
        {

            // Status
            cbStatus.Items.Add("Desativado");
            cbStatus.Items.Add("Ativado");
            cbStatus.SelectedIndex = 1;

            if(tipo == "Atualização")
            {
                btnCadastrar.Enabled = false;
                btnAtualizar.Enabled = true;
                btnDeletar.Enabled = true;

                cbStatus.Enabled = true;
                cbStatus.SelectedIndex = status;
            } else
            {
                cbStatus.Enabled = false;
                btnCadastrar.Enabled = true;
                btnAtualizar.Enabled = false;
                btnDeletar.Enabled = false;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (tipo != "Atualização")
            {
                MessageBox.Show("Erro: Para excluir uma marca, entre no modo de atualização.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbCodigo.Text, out int codigo))
            {
                MessageBox.Show("Erro: Não foi possível válidar o código dessa marca. Re-abra no modo atualização.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Confirme: Você realmente quer excluír essa marca?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (Marca.Excluir(codigo) == 0)
                {
                    MessageBox.Show("Erro: Não foi possível excluir a marca.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                MessageBox.Show("Sucesso: Marca excluído com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                DefinirCorCamposObrigatorios(Color.FromArgb(179, 221, 255));

                MessageBox.Show("Por favor, preencha todos os campos obrigatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            Marca marca = new Marca();
            marca.id = Convert.ToInt32(tbCodigo.Text);
            marca.nome = tbNome.Text;
            marca.observacao = tbObservacao.Text;
            marca.status = cbStatus.SelectedIndex;

            int resultado = marca.Atualizar();
            if (resultado == 0)
            { // ERRO
                MessageBox.Show("Erro ao cadastrar atualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            MessageBox.Show("Marca: " + marca.nome + " atualizada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DefinirCorCamposObrigatorios(SystemColors.Window);
            Close();
        }

        // Mover formulário que não tem bordas.
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void FormMarca_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        // Pequena borda manual
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Cor e espessura da borda
            Color borderColor = Color.FromArgb(200, 200, 200);
            int borderSize = 2;

            using (Pen pen = new Pen(borderColor, borderSize))
            {
                Rectangle rect = new Rectangle(
                    borderSize / 2,
                    borderSize / 2,
                    this.Width - borderSize,
                    this.Height - borderSize
                );
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
    }
}
