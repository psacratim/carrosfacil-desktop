using CarrosFacil.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrosFacil
{
    public partial class FormModelo : Form
    {
        public FormModelo()
        {
            InitializeComponent();
        }
        public string tipo;
        public int status, id_marca;

        private void FormModelo_Load(object sender, EventArgs e)
        {
            // STATUS
            cbStatus.Items.Add("Desativado");
            cbStatus.Items.Add("Ativado");
            cbStatus.SelectedIndex = 1;

            //MARCAS - ALIMENTADA PELO DB
            _ = Task.Run(() =>
            {
                Marca marca = new Marca();
                DataTable marcas = marca.CarregarMarcas();

                try // TODO: Adicionar isso em todos os outros tasks.
                {
                    this.Invoke((Action)(() =>
                    {
                        cbMarca.DataSource = marcas;
                        cbMarca.DisplayMember = "nome";
                        cbMarca.ValueMember = "id";
                        cbMarca.SelectedIndex = -1;

                        if (tipo == "Atualização")
                        {
                            cbMarca.SelectedValue = id_marca;

                            cbStatus.Enabled = true;
                            cbStatus.SelectedIndex = status;

                            btnCadastrar.Enabled = false;
                            btnAtualizar.Enabled = true;
                            btnDeletar.Enabled = true;
                        } else
                        {
                            cbStatus.Enabled = false;

                            btnCadastrar.Enabled = true;
                            btnAtualizar.Enabled = false;
                            btnDeletar.Enabled = false;
                        }
                    }));
                }
                catch (Exception) { }
            });
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                DefinirCorCamposObrigatorios(Color.FromArgb(179, 221, 255));

                MessageBox.Show("Por favor, preencha todos os campos obrigatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Modelo modelo = new Modelo();
            modelo.id_marca = (int) cbMarca.SelectedValue;
            modelo.nome = tbNome.Text;
            modelo.observacao = tbObservacao.Text;

            int resultado = modelo.Cadastrar();
            if (resultado == 0)
            { // ERRO
                MessageBox.Show("Erro ao cadastrar modelo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Modelo: " + modelo.nome + " cadastrada com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DefinirCorCamposObrigatorios(SystemColors.Window);
                Limpar();
            }
        }

        private bool ValidarCampos()
        {
            if (cbMarca.SelectedIndex == -1 || tbNome.Text == "")
            {
                return false;
            }

            return true;
        }

        private void DefinirCorCamposObrigatorios(Color color)
        {
            tbNome.BackColor = color;
            cbMarca.BackColor = color;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                DefinirCorCamposObrigatorios(Color.FromArgb(179, 221, 255));

                MessageBox.Show("Por favor, preencha todos os campos obrigatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Modelo modelo = new Modelo();
            modelo.id = Convert.ToInt32(tbCodigo.Text);
            modelo.id_marca = (int)cbMarca.SelectedValue;
            modelo.nome = tbNome.Text;
            modelo.observacao = tbObservacao.Text;
            modelo.status = cbStatus.SelectedIndex;

            int resultado = modelo.Atualizar();
            if (resultado == 0)
            { // ERRO
                MessageBox.Show("Erro ao atualizar modelo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Modelo: " + modelo.nome + " atualizar com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DefinirCorCamposObrigatorios(SystemColors.Window);
                Limpar();
                Close();
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
                MessageBox.Show("Erro: Para excluir um modelo, entre no modo de atualização.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbCodigo.Text, out int codigo))
            {
                MessageBox.Show("Erro: Não foi possível válidar o código desse modelo. Re-abra no modo atualização.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Confirme: Você realmente quer excluír esse modelo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (Modelo.Excluir(codigo) == 0)
                {
                    MessageBox.Show("Erro: Não foi possível excluir o modelo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                MessageBox.Show("Sucesso: Modelo excluído com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void Limpar()
        {
            tbNome.Clear();
            tbObservacao.Clear();
            cbMarca.SelectedIndex = -1;
        }
    }
}
