using CarrosFacil.Entities;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrosFacil.Forms
{
    public partial class FormConsFuncionario : Form
    {
        public FormConsFuncionario()
        {
            InitializeComponent();
        }

        private void FormConsultaFuncionarioV2_Load(object sender, EventArgs e)
        {
            // CARREGANDO OPÇÕES DE CONSULTA
            cbOpcoes.Items.Add("Nome");
            cbOpcoes.Items.Add("CPF");
            cbOpcoes.Items.Add("Cargo");
            cbOpcoes.Items.Add("Sexo");
            cbOpcoes.Items.Add("Cidade");
            cbOpcoes.Items.Add("Data de Admissão");
            cbOpcoes.Items.Add("Status");
            cbOpcoes.Items.Add("Sexo e Cidade");
            cbOpcoes.SelectedIndex = 0;

            // CARREGANDO SEXOS
            cbSexo.Items.Add("Masculino");
            cbSexo.Items.Add("Feminino");
            cbSexo.Items.Add("Não Informado");
            cbSexo.SelectedIndex = 0;

            // Status
            cbStatus.Items.Add("Desativado");
            cbStatus.Items.Add("Ativado");
            cbStatus.SelectedIndex = 1;

            // CARGO - ALIMENTADA PELO DB
            _ = Task.Run(() =>
            {
                // CIDADES
                Funcionario funcionario = new Funcionario();
                DataTable cidades = funcionario.CarregarCidades();

                // Cargos
                Cargo cargo = new Cargo();
                DataTable cargos = cargo.CarregarCargo();

                this.Invoke((Action)(() =>
                {
                    cbCargo.DataSource = cargos;
                    cbCargo.DisplayMember = "nome";
                    cbCargo.ValueMember = "id";
                    if (cbCargo.Items.Count > 0) cbCargo.SelectedIndex = 0;

                    cbCidade.DataSource = cidades;
                    cbCidade.DisplayMember = "cidade";
                    cbCidade.ValueMember = "cidade";
                    cbCidade.SelectedValue = "Piracicaba";
                }));
            });
        }

        private void PesquisarPorNome()
        {
            if (tbNome.Text == "")
            {
                MessageBox.Show("Por favor, digite um nome válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNome.BackColor = Color.Red;
                tbNome.Focus();
                return;
            }

            dgvFuncionarios.DataSource = new Funcionario().ConsultarPorNome(tbNome.Text, rbInicio.Checked);
        }

        private void PesquisarPorCPF()
        {
            if (!mskCpf.MaskFull)
            {
                MessageBox.Show("Por favor, insira um cpf completo e válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskCpf.BackColor = Color.Red;
                mskCpf.Focus();
                return;
            }

            dgvFuncionarios.DataSource = new Funcionario().ConsultarPorCpf(mskCpf.Text);
        }

        private void PesquisarPorCargo()
        {
            if (cbCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um cargo válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCargo.BackColor = Color.Red;
                cbCargo.Focus();
                return;
            }

            dgvFuncionarios.DataSource = new Funcionario().ConsultarPorCargo((int)cbCargo.SelectedValue);
        }

        private void PesquisarPorSexo()
        {
            dgvFuncionarios.DataSource = new Funcionario().ConsultarPorSexo(cbSexo.SelectedItem.ToString().Substring(0, 1));
        }

        private void PesquisarPorCidade()
        {
            if (cbCidade.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione uma cidade válida.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCidade.BackColor = Color.Red;
                cbCidade.Focus();
                return;
            }

            dgvFuncionarios.DataSource = new Funcionario().ConsultarPorCidade(cbCidade.SelectedValue.ToString());
        }

        private void PesquisarPorDataAdmissao()
        {
            double difference = dtpDataInicial.Value.Subtract(dtpDataFinal.Value).TotalMilliseconds;
            if (difference > 0)
            {
                MessageBox.Show("A data inicial deve ser menor que a final", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvFuncionarios.DataSource = new Funcionario().ConsultarPorDataAdmissao(dtpDataInicial.Value, dtpDataFinal.Value);
        }

        private void PesquisarPorStatus()
        {
            dgvFuncionarios.DataSource = new Funcionario().ConsultarPorStatus(cbStatus.SelectedIndex);
        }

        private void PesquisarPorSexoCidade()
        {
            if (cbCidade.SelectedIndex == -1 || cbSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione uma cidade e sexo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvFuncionarios.DataSource = new Funcionario().ConsultarPorSexoCidade(cbCidade.SelectedValue.ToString(), cbSexo.SelectedItem.ToString().Substring(0, 1));
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            switch (cbOpcoes.SelectedIndex)
            {
                case 1:
                    PesquisarPorCPF();
                    break;

                case 2:
                    PesquisarPorCargo();
                    break;

                case 3:
                    PesquisarPorSexo();
                    break;

                case 4:
                    PesquisarPorCidade();
                    break;

                case 5:
                    PesquisarPorDataAdmissao();
                    break;

                case 6:
                    PesquisarPorStatus();
                    break;
                case 7:
                    PesquisarPorSexoCidade();
                    break;

                default:
                    PesquisarPorNome();
                    break;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbTipoBusca.Enabled = cbOpcoes.SelectedIndex == 0;
            tbNome.Enabled = cbOpcoes.SelectedIndex == 0;
            mskCpf.Enabled = cbOpcoes.SelectedIndex == 1;
            cbCargo.Enabled = cbOpcoes.SelectedIndex == 2;
            cbSexo.Enabled = cbOpcoes.SelectedIndex == 3 || cbOpcoes.SelectedIndex == 7;
            cbCidade.Enabled = cbOpcoes.SelectedIndex == 4 || cbOpcoes.SelectedIndex == 7;
            gbDataAdmissao.Enabled = cbOpcoes.SelectedIndex == 5;
            cbStatus.Enabled = cbOpcoes.SelectedIndex == 6;
        }

        private void dgvFuncionarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja alterar ou excluir o funcionário selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                // Cria o funcionario e obtém os dados.
                Funcionario funcionario = new Funcionario();
                funcionario.ConsultaFuncionario(Convert.ToInt32(dgvFuncionarios.SelectedRows[0].Cells[0].Value));

                // Cria o formulario de funcionario.
                FormFuncionario formFuncionario = new FormFuncionario();

                // Altera o tipo do funcionario.
                formFuncionario.tipo = "Atualização";

                // Define os campos do funcionário
                formFuncionario.tbCodigo.Text = funcionario.id.ToString();
                formFuncionario.tbUsuario.Text = funcionario.usuario;
                formFuncionario.tbSenha.Text = funcionario.senha;
                formFuncionario.tipo_acesso = funcionario.tipo_acesso;
                formFuncionario.mtbTelefoneRecado.Text = funcionario.telefone_recado;
                formFuncionario.mtbTelefoneCelular.Text = funcionario.telefone_celular;
                formFuncionario.mtbTelefoneResidencial.Text = funcionario.telefone_residencial;
                formFuncionario.tbEmail.Text = funcionario.email;
                formFuncionario.tbNome.Text = funcionario.nome;
                formFuncionario.dtpDataNascimento.Value = funcionario.data_nascimento;
                formFuncionario.tbNomeSocial.Text = funcionario.nome_social;
                formFuncionario.sexo = funcionario.sexo;

                formFuncionario.cbSexo.Text = funcionario.sexo;
                formFuncionario.mtbCpf.Text = funcionario.cpf;
                formFuncionario.mtbRg.Text = funcionario.rg;
                formFuncionario.cargo = funcionario.id_cargo;
                formFuncionario.estado_civil = funcionario.estado_civil;
                formFuncionario.tbSalario.Text = funcionario.salario.ToString().Replace(".", ",");
                if (funcionario.cep != "")
                {
                    formFuncionario.IGNORE_FIRST_CEP_REQUEST = true;
                }
                formFuncionario.mtbCep.Text = funcionario.cep;
                formFuncionario.tbEndereco.Text = funcionario.endereco;
                formFuncionario.tbNumero.Text = funcionario.numero.ToString();
                formFuncionario.tbBairro.Text = funcionario.bairro;
                formFuncionario.tbCidade.Text = funcionario.cidade;
                formFuncionario.estado = funcionario.estado;
                formFuncionario.tbComplemento.Text = funcionario.complemento;
                formFuncionario.data_cadastro = funcionario.data_cadastro;
                formFuncionario.status = funcionario.status;

                // Carregando foto
                string fotoUrl = Uploader.CarregarImagemDoServidor(funcionario.foto);
                if (fotoUrl != "")
                {
                    try
                    {
                        formFuncionario.pbFoto.Load(fotoUrl);
                        formFuncionario.lbFoto.Text = funcionario.foto;
                        formFuncionario.foto_atual = funcionario.foto;
                    }
                    catch (WebException ex)
                    {
                        bool isNotFound = false;
                        if (ex.Status == WebExceptionStatus.ProtocolError && ex.Response != null)
                        {
                            var resp = (HttpWebResponse)ex.Response;
                            if (resp.StatusCode == HttpStatusCode.NotFound)
                            {
                                MessageBox.Show("O funcionario não tem foto, adicione se necessário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                isNotFound = true;
                            }
                        }

                        if (!isNotFound)
                        {
                            MessageBox.Show("Não foi possível acessar a foto do funcionário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                // Modo exclusivo (ShowDialog)
                formFuncionario.ShowDialog();

                // Atualiza a grid de consulta.
                btnPesquisar_Click(this, new EventArgs());
            }
        }

        private void dgvFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
