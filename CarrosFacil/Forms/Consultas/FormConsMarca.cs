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

namespace CarrosFacil.Forms.Consultas
{
    public partial class FormConsMarca : Form
    {
        public FormConsMarca()
        {
            InitializeComponent();
        }

        private void FormConsMarca_Load(object sender, EventArgs e)
        {
            cbStatus.Items.Add("Desativado");
            cbStatus.Items.Add("Ativado");
            cbStatus.SelectedIndex = 1;

            cbOpcoes.Items.Add("- Nenhum Filtro -");
            cbOpcoes.Items.Add("Filtrar por código");
            cbOpcoes.Items.Add("Filtrar por nome");
            cbOpcoes.Items.Add("Filtrar por status");
            cbOpcoes.SelectedIndex = 0;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var marca = new Marca();
            switch (cbOpcoes.SelectedIndex)
            {
                case 1:
                    if (tbCodigo.Text == "")
                    {
                        MessageBox.Show("Por favor, insira um código para pesquisar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var codigo = Convert.ToInt32(tbCodigo.Text);
                    dgvMarcas.DataSource = marca.ConsultarPorCodigo(codigo);
                    break;

                case 2:
                    var nome = tbNome.Text;
                    if (nome == "")
                    {
                        MessageBox.Show("Por favor, insira um nome para pesquisar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    dgvMarcas.DataSource = marca.ConsultarPorNome(nome);
                    break;

                case 3:
                    dgvMarcas.DataSource = marca.ConsultarPorStatus(cbStatus.SelectedIndex);
                    break;

                default:
                    dgvMarcas.DataSource = marca.ConsultarSemFiltro();
                    break;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbCodigo.Text = "";
            tbNome.Text = "";
            cbStatus.SelectedIndex = 1;

            tbCodigo.Enabled = cbOpcoes.SelectedIndex == 1;
            tbNome.Enabled = cbOpcoes.SelectedIndex == 2;
            cbStatus.Enabled = cbOpcoes.SelectedIndex == 3;
        }

        private void dgvMarcas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja alterar ou excluir a marca selecionada?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Marca marca = new Marca();
                marca.ConsultaMarca(Convert.ToInt32(dgvMarcas.SelectedRows[0].Cells[0].Value));

                FormMarca formMarca = new FormMarca();
                formMarca.tipo = "Atualização";
                formMarca.status = marca.status;

                formMarca.tbCodigo.Text = marca.id.ToString();
                formMarca.tbNome.Text = marca.nome;
                formMarca.tbObservacao.Text = marca.observacao;

                formMarca.ShowDialog();

                btnPesquisar_Click(this, new EventArgs());
            }
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 27 && e.KeyChar != 01)
            {
                e.Handled = true;
                MessageBox.Show("Esse campo aceita somente números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
