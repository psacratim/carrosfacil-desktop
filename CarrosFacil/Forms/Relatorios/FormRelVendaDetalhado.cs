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

namespace CarrosFacil.Forms.Relatorios
{
    public partial class formRelVendaDetalhado : Form
    {
        public formRelVendaDetalhado()
        {
            InitializeComponent();
        }

        private void formRelVendaDetalhado_Load(object sender, EventArgs e)
        {
            // CARREGAR COMBO TIPO DE RELATÓRIO
            cbTipoRel.Items.Add("Vendas por Período");
            cbTipoRel.Items.Add("Vendas por Cliente");
            cbTipoRel.Items.Add("Vendas por Funcionário");
            cbTipoRel.Items.Add("Vendas por Período e Cliente");
            cbTipoRel.Items.Add("Vendas por Período e Funcionário");
            cbTipoRel.SelectedIndex = 0;
            this.rvVendas.RefreshReport();

            Funcionario funcionario = new Funcionario();
            cbFuncionario.DataSource = funcionario.BuscarFuncionario();
            cbFuncionario.DisplayMember = "nome";
            cbFuncionario.ValueMember = "id";

            Cliente cliente = new Cliente();
            cbCliente.DataSource = cliente.BuscarCliente();
            cbCliente.DisplayMember = "nome";
            cbCliente.ValueMember = "id";
        }

        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoRel.SelectedIndex == 0)//Vendas por Período
            {
                gbPeriodo.Enabled = true;
                gbCliente.Enabled = false;
                gbFuncionario.Enabled = false;
            }
            if (cbTipoRel.SelectedIndex == 1)//Vendas por Cliente
            {
                gbPeriodo.Enabled = false;
                gbCliente.Enabled = true;
                gbFuncionario.Enabled = false;
            }
            if (cbTipoRel.SelectedIndex == 2)//Vendas por Funcionário
            {
                gbPeriodo.Enabled = false;
                gbCliente.Enabled = false;
                gbFuncionario.Enabled = true;
            }
            if (cbTipoRel.SelectedIndex == 3)//Vendas por Período e Cliente
            {
                gbPeriodo.Enabled = true;
                gbCliente.Enabled = true;
                gbFuncionario.Enabled = false;
            }
            if (cbTipoRel.SelectedIndex == 4)//Vendas por Período e Funcionário
            {
                gbPeriodo.Enabled = true;
                gbCliente.Enabled = false;
                gbFuncionario.Enabled = true;
            }
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            RelVenda relVenda = new RelVenda();
            int tipo_rel = Convert.ToInt32(cbTipoRel.SelectedIndex);

            switch (tipo_rel)
            {
                case 1:
                    if (cbCliente.SelectedIndex == -1)
                    {
                        cbCliente.Focus();
                        gbCliente.BackColor = Color.FromArgb(179, 221, 255);
                        MessageBox.Show("Por favor, selecione um cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }

                    int id_cliente = Convert.ToInt32(cbCliente.SelectedValue);
                    RelVendaBindingSource.DataSource = relVenda.GerarRelatorioDetalhadoCliente(id_cliente);
                    rvVendas.RefreshReport();
                    break;

                case 2:
                    if (cbFuncionario.SelectedIndex == -1)
                    {
                        cbFuncionario.Focus();
                        gbFuncionario.BackColor = Color.FromArgb(179, 221, 255);
                        MessageBox.Show("Por favor, selecione um funcionário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }

                    int id_funcionario = Convert.ToInt32(cbFuncionario.SelectedValue);
                    RelVendaBindingSource.DataSource = relVenda.GerarRelatorioDetalhadoCliente(id_funcionario);
                    rvVendas.RefreshReport();
                    break;

                case 3:
                    if (cbCliente.SelectedIndex == -1)
                    {
                        cbCliente.Focus();
                        gbCliente.BackColor = Color.FromArgb(179, 221, 255);
                        MessageBox.Show("Por favor, selecione um cliente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }

                    id_cliente = Convert.ToInt32(cbCliente.SelectedValue);
                    DateTime inicio = dtpDataInicial.Value;
                    DateTime fim = dtpDataFinal.Value;

                    RelVendaBindingSource.DataSource = relVenda.GerarRelatorioPorPeriodoCliente(inicio, fim, id_cliente);
                    rvVendas.RefreshReport();
                    break;

                case 4:
                    if (cbFuncionario.SelectedIndex == -1)
                    {
                        cbFuncionario.Focus();
                        gbFuncionario.BackColor = Color.FromArgb(179, 221, 255);
                        MessageBox.Show("Por favor, selecione um funcionário", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }

                    id_funcionario = Convert.ToInt32(cbFuncionario.SelectedValue);
                    inicio = dtpDataInicial.Value;
                    fim = dtpDataFinal.Value;

                    RelVendaBindingSource.DataSource = relVenda.GerarRelatorioDetalhadoPorPeriodoFuncionario(inicio, fim, id_funcionario);
                    rvVendas.RefreshReport();
                    break;
                default:
                    inicio = dtpDataInicial.Value;
                    fim = dtpDataFinal.Value;

                    RelVendaBindingSource.DataSource = relVenda.GerarRelatorioPorData(inicio, fim);
                    rvVendas.RefreshReport();
                    break;
            }
        }
    }
}
