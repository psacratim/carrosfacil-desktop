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
    public partial class FormRelClientes : Form
    {
        public FormRelClientes()
        {
            InitializeComponent();
        }

        private void FormRelClientes_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO TIPO DE RELATÓRIO
            // TODO: 1. Relátorio de compras e 
            cbTipoRel.Items.Add("Aniversariantes do Mês");  
            cbTipoRel.Items.Add("Cidade");
            cbTipoRel.Items.Add("Idade");
            cbTipoRel.Items.Add("Sexo");
            cbTipoRel.Items.Add("Status");
            cbTipoRel.SelectedIndex = 0;

            //CARREGAR COMBO MÊS
            cbMes.Items.Add("Escolha um Mês");
            cbMes.Items.Add("Janeiro");
            cbMes.Items.Add("Fevereiro");
            cbMes.Items.Add("Março");
            cbMes.Items.Add("Abril");
            cbMes.Items.Add("Maio");
            cbMes.Items.Add("Junho");
            cbMes.Items.Add("Julho");
            cbMes.Items.Add("Agosto");
            cbMes.Items.Add("Setembro");
            cbMes.Items.Add("Outubro");
            cbMes.Items.Add("Novembro");
            cbMes.Items.Add("Dezembro");
            cbMes.SelectedIndex = 0;

            //CARREGAR COMBO SEXO
            cbSexo.Items.Add("Escolha um Sexo");
            cbSexo.Items.Add("Feminino");
            cbSexo.Items.Add("Masculino");
            cbSexo.Items.Add("Não Informado");
            cbSexo.SelectedIndex = 0;

            //CARREGAR COMBO CIDADE E CARGO DE FORMA ASYNC (ASYNC EVITA: O SISTEMA NÃO IRÁ TRAVAR POR CONTA DO BANCO LENTO).
            _ = Task.Run(() => 
            {
                // OBTENDO AS CIDADES DO BANCO
                Cliente cliente = new Cliente();
                DataTable cidades = cliente.CarregarCidades();

                // VOLTANDO AO THREAD ANTERIOR
                this.Invoke((Action)(() =>
                {
                    cbCidade.DataSource = cidades;
                    cbCidade.DisplayMember = "cidade";
                    cbCidade.ValueMember = "cidade";
                    cbCidade.SelectedValue = "Piracicaba";
                }));
            });
            this.rvClientes.RefreshReport();
            this.rvClientes.RefreshReport();
            this.rvClientes.RefreshReport();
        }

        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoRel.SelectedIndex == 0)//Aniversariantes do Mês
            {
                gbAniversariantes.Enabled = true;
                gbIdade.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 1)//Cidade
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = true;
            }

            if (cbTipoRel.SelectedIndex == 2)//Idade
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = true;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 3)//Sexo
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = true;
                gbCidade.Enabled = false;
            }
            if (cbTipoRel.SelectedIndex == 4)//Status
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbStatus.Enabled = true;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o relatório de clientes?", "Sistema Carros Fácil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            int relatorio = Convert.ToInt32(cbTipoRel.SelectedIndex);

            switch (relatorio)
            {
                case 1:
                    string cidade = cbCidade.SelectedValue.ToString();

                    ClienteBindingSource.DataSource = cliente.RelatorioPorCidade(cidade);
                    rvClientes.RefreshReport();
                    break;

                case 2:
                    if (string.IsNullOrEmpty(txtIdadeInicial.Text) || string.IsNullOrEmpty(txtIdadeFinal.Text))
                    {
                        MessageBox.Show("Por favor, insira as duas idades válidas.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int idadeInicial = Convert.ToInt32(txtIdadeInicial.Text);
                    int idadeFinal = Convert.ToInt32(txtIdadeFinal.Text);
                    if (idadeInicial > idadeFinal)
                    {
                        MessageBox.Show("A idade inicial não pode ser maior que a final.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    ClienteBindingSource.DataSource = cliente.RelatorioPorIdade(idadeInicial, idadeFinal);
                    rvClientes.RefreshReport();
                    break;

                case 3:
                    if (cbSexo.SelectedIndex == 0)
                    {
                        MessageBox.Show("Por favor, selecione um sexo válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string sexo;
                    switch (cbSexo.SelectedIndex)
                    {
                        case 1:
                            sexo = "F";
                            break;
                        case 2:
                            sexo = "M";
                            break;
                        default:
                            sexo = "N";
                            break;
                    }


                    ClienteBindingSource.DataSource = cliente.RelatorioPorSexo(sexo);
                    rvClientes.RefreshReport();
                    break;

                case 4:
                    int status = rbAtivo.Checked ? 1 : 0;

                    ClienteBindingSource.DataSource = cliente.RelatorioPorStatus(status);
                    rvClientes.RefreshReport();
                    break;

                default:
                    int mes = cbMes.SelectedIndex;
                    if (mes == 0)
                    {
                        MessageBox.Show("Por favor, selecione um mês válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    ClienteBindingSource.DataSource = cliente.RelatorioPorMesAniversario(mes);
                    rvClientes.RefreshReport();
                    break;
            }
        }
    }
}
