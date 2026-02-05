using CarrosFacil.Entities;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CarrosFacil
{
    public partial class FormCargo : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void MoverForm()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public FormCargo()
        {
            InitializeComponent();
        }

        public string tipo;
        public int status;

        private void FormCargo_Load(object sender, EventArgs e)
        {
            //
            cbStatus.Items.Add("Desativado");
            cbStatus.Items.Add("Ativado");
            cbStatus.SelectedIndex = 1;

            // 
            if (tipo == "Atualização")
            {
                btnCadastrar.Enabled = false;
                btnAtualizar.Enabled = true;
                btnDeletar.Enabled = true;

                cbStatus.Enabled = true;
                cbStatus.SelectedIndex = status;
            }
            else
            {
                cbStatus.Enabled = false;
                btnCadastrar.Enabled = true;
                btnAtualizar.Enabled = false;
                btnDeletar.Enabled = false;
            }
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                DefinirCorCamposObrigatorios(Color.FromArgb(179, 221, 255));

                MessageBox.Show("Por favor, preencha todos os campos obrigatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            Cargo cargo = new Cargo();
            cargo.nome = tbNome.Text;
            cargo.observacao = tbObservacao.Text;
            cargo.status = cbStatus.SelectedIndex;

            int resultado = cargo.Cadastrar();
            if (resultado == 0)
            { // ERRO
                MessageBox.Show("Erro ao cadastrar cargo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Cargo: " + cargo.nome + " cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ShowWarning(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (tipo != "Atualização")
            {
                MessageBox.Show("Erro: Para excluir umo cargo, entre no modo de atualização.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbCodigo.Text, out int codigo))
            {
                MessageBox.Show("Erro: Não foi possível válidar o código desse cargo. Re-abra no modo atualização.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Confirme: Você realmente quer excluír esse cargo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (Cargo.Excluir(codigo) == 0)
                {
                    MessageBox.Show("Erro: Não foi possível excluir o cargo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Sucesso: Cargo excluído com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            Cargo cargo = new Cargo();
            cargo.id = Convert.ToInt32(tbCodigo.Text);
            cargo.nome = tbNome.Text;
            cargo.observacao = tbObservacao.Text;
            cargo.status = cbStatus.SelectedIndex;

            int resultado = cargo.Atualizar();
            if (resultado == 0)
            { // ERRO
                MessageBox.Show("Erro ao atualuzar cargo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Cargo: " + cargo.nome + " atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DefinirCorCamposObrigatorios(SystemColors.Window);
                Limpar();
                Close();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCargo_MouseDown(object sender, MouseEventArgs e)
        {
            MoverForm();
        }
    }
}
