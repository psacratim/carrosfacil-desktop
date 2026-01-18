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
    public partial class FormConsCargo : Form
    {
        public FormConsCargo()
        {
            InitializeComponent();
        }

        private void FormConsCargo_Load(object sender, EventArgs e)
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
            var cargo = new Cargo();
            switch (cbOpcoes.SelectedIndex)
            {
                case 1:
                    if (tbCodigo.Text == "")
                    {
                        MessageBox.Show("Por favor, insira um código para pesquisar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var codigo = Convert.ToInt32(tbCodigo.Text);
                    dgvCargos.DataSource = cargo.ConsultarPorCodigo(codigo);
                    break;

                case 2:
                    var nome = tbNome.Text;
                    if (nome == "")
                    {
                        MessageBox.Show("Por favor, insira um nome para pesquisar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    dgvCargos.DataSource = cargo.ConsultarPorNome(nome);
                    break;

                case 3:
                    dgvCargos.DataSource = cargo.ConsultarPorStatus(cbStatus.SelectedIndex);
                    break;

                default:
                    dgvCargos.DataSource = cargo.ConsultarSemFiltro();
                    break;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvCargos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja alterar ou excluir o cargo selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Cargo cargo = new Cargo();
                cargo.ConsultaCargo(Convert.ToInt32(dgvCargos.SelectedRows[0].Cells[0].Value));

                FormCargo formCargo = new FormCargo();
                formCargo.tipo = "Atualização";
                formCargo.status = cargo.status;

                formCargo.tbCodigo.Text = cargo.id.ToString();
                formCargo.tbNome.Text = cargo.nome.ToString();
                formCargo.tbObservacao.Text = cargo.observacao;

                formCargo.ShowDialog();

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

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbCodigo.Enabled = cbOpcoes.SelectedIndex == 1;
            tbNome.Enabled = cbOpcoes.SelectedIndex == 2;
            cbStatus.Enabled = cbOpcoes.SelectedIndex == 3;
        }
    }
}
