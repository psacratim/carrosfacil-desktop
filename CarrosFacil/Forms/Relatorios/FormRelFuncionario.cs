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
    public partial class FormRelFuncionario : Form
    {
        public FormRelFuncionario()
        {
            InitializeComponent();
        }

        private void formRelFuncionario_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO TIPO DE RELATÓRIO
            cbTipoRel.Items.Add("Aniversariantes do Mês");     
            cbTipoRel.Items.Add("Cargo");
            cbTipoRel.Items.Add("Cidade");
            cbTipoRel.Items.Add("Data de Admissão");
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
                Funcionario funcionario = new Funcionario();
                DataTable cidades = funcionario.CarregarCidades();

                // OBTENDO OS CARGOS DO BANCO
                Cargo cargo = new Cargo();
                DataTable cargos = cargo.CarregarCargo();

                // VOLTANDO AO THREAD ANTERIOR
                this.Invoke((Action)(() =>
                {
                    cbCargo.DataSource = cargos;
                    cbCargo.DisplayMember = "nome";
                    cbCargo.ValueMember = "id";
                    if (cbCargo.Items.Count > 0) cbCargo.SelectedIndex = 0;

                    cbCidade.DataSource = cidades;
                    cbCidade.DisplayMember = "cidade";
                    cbCidade.ValueMember = "cidade";
                    cbCidade.SelectedIndex = -1;
                }));
            });
            this.rvFuncionario.RefreshReport();
            this.rvFuncionario.RefreshReport();
            this.rvFuncionario.RefreshReport();
            this.rvFuncionario.RefreshReport();
        }

        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoRel.SelectedIndex == 0)//Aniversariantes do Mês
            {
                gbAniversariantes.Enabled = true;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCargo.Enabled = false;
                gbCidade.Enabled = false;
            }
           
            if (cbTipoRel.SelectedIndex == 1)//Cargo
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCargo.Enabled = true;
                gbCidade.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 2)//Cidade
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCargo.Enabled = false;
                gbCidade.Enabled = true;
            }

            if (cbTipoRel.SelectedIndex == 3)//Data de Admissão
            {
                gbAniversariantes.Enabled = false;
                gbDataAdmissao.Enabled = true;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCargo.Enabled = false;
                gbCidade.Enabled = false;
            }
            if (cbTipoRel.SelectedIndex == 4)//Idade
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = true;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCargo.Enabled = false;
                gbCidade.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 5)//Sexo
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = true;
                gbCargo.Enabled = false;
                gbCidade.Enabled = false;
            }
            if (cbTipoRel.SelectedIndex == 6)//Status
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = true;
                gbSexo.Enabled = false;
                gbCargo.Enabled = false;
                gbCidade.Enabled = false;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fechar o relatório de funcionário???", "Sistema - CarrosFácil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            int relatorio = Convert.ToInt32(cbTipoRel.SelectedIndex);

            switch (relatorio)
            {
                case 1:
                    int cargo = Convert.ToInt32(cbCargo.SelectedValue);
                    if (cargo == 0)
                    {
                        MessageBox.Show("Por favor, selecione um cargo válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    FuncionarioBindingSource.DataSource = funcionario.RelatorioPorCargo(cargo);
                    rvFuncionario.RefreshReport();
                    break;

                case 2:
                    if (cbCidade.SelectedIndex == -1)
                    {
                        MessageBox.Show("Por favor, selecione uma cidade válida.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string cidade = cbCidade.SelectedValue.ToString();

                    FuncionarioBindingSource.DataSource = funcionario.RelatorioPorCidade(cidade);
                    rvFuncionario.RefreshReport();
                    break;

                case 3:
                    DateTime dataInicio = dtpDataInicial.Value;
                    DateTime dataFim = dtpDataFinal.Value;

                    FuncionarioBindingSource.DataSource = funcionario.RelatorioPorDataAdmissao(dataInicio, dataFim);
                    rvFuncionario.RefreshReport();
                    break;

                case 4:
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

                    FuncionarioBindingSource.DataSource = funcionario.RelatorioPorIdade(idadeInicial, idadeFinal);
                    rvFuncionario.RefreshReport();
                    break;

                case 5:
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


                    FuncionarioBindingSource.DataSource = funcionario.RelatorioPorSexo(sexo);
                    rvFuncionario.RefreshReport();
                    break;

                case 6:
                    int status = rbAtivo.Checked ? 1 : 0;

                    FuncionarioBindingSource.DataSource = funcionario.RelatorioPorStatus(status);
                    rvFuncionario.RefreshReport();
                    break;

                default:
                    int mes = cbMes.SelectedIndex;
                    if (mes == 0)
                    {
                        MessageBox.Show("Por favor, selecione um mês válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    FuncionarioBindingSource.DataSource = funcionario.RelatorioPorMesAniversario(mes);
                    rvFuncionario.RefreshReport();
                    break;
            }
        }

        private void pnTituloFuncionario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
