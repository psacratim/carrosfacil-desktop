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

namespace CarrosFacil.Forms
{
    public partial class FormSelecionarCaracteristicas : Form
    {
        private FormVeiculo formVeiculo;

        public FormSelecionarCaracteristicas(FormVeiculo formVeiculo)
        {
            this.formVeiculo = formVeiculo;

            InitializeComponent();
        }

        private void FormSelecionarCaracteristicas_Load(object sender, EventArgs e)
        {
            // Status
            cbStatus.Items.Add("Desativado");
            cbStatus.Items.Add("Ativado");
            cbStatus.SelectedIndex = 1;

            // Opcoes de filtro
            cbOpcoes.Items.Add("- Nenhum Filtro -");
            cbOpcoes.Items.Add("Filtrar por código");
            cbOpcoes.Items.Add("Filtrar por nome");
            cbOpcoes.Items.Add("Filtrar por status");
            cbOpcoes.SelectedIndex = 0;

            // Carrega todas as caracteristicas do form
            dgvCaracteristicas.DataSource = new Caracteristica().CarregarCaracteristicas();

            // Muda a cor das selecionadas
            foreach (DataGridViewRow row in dgvCaracteristicas.Rows)
            {
                if (formVeiculo.caracteristicasSelecionadas.Contains((int)row.Cells[0].Value))
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.SelectionBackColor = Color.Green;
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var caracteristica = new Caracteristica();
            switch (cbOpcoes.SelectedIndex)
            {
                case 1:
                    if (tbCodigo.Text == "")
                    {
                        MessageBox.Show("Por favor, insira um código para pesquisar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var codigo = Convert.ToInt32(tbCodigo.Text);
                    dgvCaracteristicas.DataSource = caracteristica.ConsultarPorCodigo(codigo);
                    break;

                case 2:
                    var nome = tbNome.Text;
                    if (nome == "")
                    {
                        MessageBox.Show("Por favor, insira um nome para pesquisar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    dgvCaracteristicas.DataSource = caracteristica.ConsultarPorNome(nome);
                    break;

                case 3:
                    dgvCaracteristicas.DataSource = caracteristica.ConsultarPorStatus(cbStatus.SelectedIndex);
                    break;

                default:
                    dgvCaracteristicas.DataSource = caracteristica.ConsultarSemFiltro();
                    break;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            formVeiculo.dgvCaracteristicas.DataSource = dgvCaracteristicas.DataSource;
            formVeiculo.AtualizarCaracteristicasUsadas();
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

        private void dgvCaracteristicas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Adiciona ou remove a caracteristica
            int codigoCaracteristica = Convert.ToInt32(dgvCaracteristicas.SelectedRows[0].Cells[0].Value);
            if (formVeiculo.caracteristicasSelecionadas.Contains(codigoCaracteristica))
            {
                formVeiculo.caracteristicasSelecionadas.Remove(codigoCaracteristica);
            } else
            {
                formVeiculo.caracteristicasSelecionadas.Add(codigoCaracteristica);
            }

            // Muda a cor da celula pra verde caso esteja selecionado
            var cor = formVeiculo.caracteristicasSelecionadas.Contains(codigoCaracteristica) ? Color.Green : Color.Gray;
            dgvCaracteristicas.SelectedRows[0].DefaultCellStyle.BackColor = cor;
            dgvCaracteristicas.SelectedRows[0].DefaultCellStyle.SelectionBackColor = cor;
        }
    }
}
