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
    public partial class FormConsModelo : Form
    {
        public FormConsModelo()
        {
            InitializeComponent();
        }

        private void FormConsModelo_Load(object sender, EventArgs e)
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
            var modelo = new Modelo();
            switch (cbOpcoes.SelectedIndex)
            {
                case 1:
                    if (tbCodigo.Text == "")
                    {
                        MessageBox.Show("Por favor, insira um código para pesquisar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var codigo = Convert.ToInt32(tbCodigo.Text);
                    dgvMarcas.DataSource = modelo.ConsultarPorCodigo(codigo);
                    break;

                case 2:
                    if (tbNome.Text == "")
                    {
                        MessageBox.Show("Por favor, insira um nome para pesquisar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var nome = tbNome.Text;
                    dgvMarcas.DataSource = modelo.ConsultarPorNome(nome);
                    break;

                case 3:
                    dgvMarcas.DataSource = modelo.ConsultarPorStatus(cbStatus.SelectedIndex);
                    break;

                default:
                    dgvMarcas.DataSource = modelo.ConsultarSemFiltro();
                    break;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvMarcas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja alterar ou excluir o modelo selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                // Cria o modelo e obtém os dados.
                Modelo modelo = new Modelo();
                modelo.ConsultaModelo(Convert.ToInt32(dgvMarcas.SelectedRows[0].Cells[0].Value));

                // Define os campos do funcionário
                FormModelo formModelo = new FormModelo();
                formModelo.tipo = "Atualização";
                formModelo.status = modelo.status;
                formModelo.id_marca = modelo.id_marca;

                formModelo.tbCodigo.Text = modelo.id.ToString();
                formModelo.tbNome.Text = modelo.nome.ToString();
                formModelo.tbObservacao.Text = modelo.observacao;

                // Modo exclusivo (ShowDialog)
                formModelo.ShowDialog();

                // Atualiza a grid de consulta.
                btnPesquisar_Click(this, new EventArgs());
            }
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbCodigo.Enabled = cbOpcoes.SelectedIndex == 1;
            tbNome.Enabled = cbOpcoes.SelectedIndex == 2;
            cbStatus.Enabled = cbOpcoes.SelectedIndex == 3;
        }
    }
}
