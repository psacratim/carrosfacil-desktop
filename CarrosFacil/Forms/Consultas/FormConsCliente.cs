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
    public partial class FormConsCliente : Form
    {
        public FormConsCliente()
        {
            InitializeComponent();
        }

        private void FormConsCliente_Load(object sender, EventArgs e)
        {
            // CARREGANDO OPÇÕES DE CONSULTA
            cbOpcoes.Items.Add("Nome");
            cbOpcoes.Items.Add("CPF");
            cbOpcoes.Items.Add("Estado Civil");
            cbOpcoes.Items.Add("Sexo");
            cbOpcoes.Items.Add("Cidade");
            cbOpcoes.Items.Add("Usuario");
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

            //ESTADOS CIVIL
            cbEstadoCivil.Items.Add("Solteiro(a)");
            cbEstadoCivil.Items.Add("Casado(a)");
            cbEstadoCivil.Items.Add("Separado(a)");
            cbEstadoCivil.Items.Add("Divorciado(a)");
            cbEstadoCivil.Items.Add("Viúvo(a)");
            cbEstadoCivil.SelectedIndex = 0;

            // CARGO - ALIMENTADA PELO DB
            _ = Task.Run(() =>
            {
                // CIDADES
                Cliente cliente = new Cliente();
                DataTable cidades = cliente.CarregarCidades();

                this.Invoke((Action)(() =>
                {
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

            dgvClientes.DataSource = new Cliente().ConsultarPorNome(tbNome.Text, rbInicio.Checked);
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

            dgvClientes.DataSource = new Cliente().ConsultarPorCpf(mskCpf.Text);
        }

        private void PesquisarPorEstadoCivil()
        {
            if (cbEstadoCivil.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um estado civil válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbEstadoCivil.BackColor = Color.Red;
                cbEstadoCivil.Focus();
                return;
            }

            dgvClientes.DataSource = new Cliente().ConsultarPorEstadoCivil(cbEstadoCivil.SelectedItem.ToString());
        }

        private void PesquisarPorSexo()
        {
            dgvClientes.DataSource = new Cliente().ConsultarPorSexo(cbSexo.SelectedItem.ToString().Substring(0, 1));
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

            dgvClientes.DataSource = new Cliente().ConsultarPorCidade(cbCidade.SelectedValue.ToString());
        }

        private void PesquisarPorUsuario()
        {
            dgvClientes.DataSource = new Cliente().ConsultarPorUsuario(tbUsuario.Text);
        }

        private void PesquisarPorStatus()
        {
            dgvClientes.DataSource = new Cliente().ConsultarPorStatus(cbStatus.SelectedIndex);
        }

        private void PesquisarPorSexoCidade()
        {
            if (cbCidade.SelectedIndex == -1 || cbSexo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione uma cidade e sexo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvClientes.DataSource = new Cliente().ConsultarPorSexoCidade(cbCidade.SelectedValue.ToString(), cbSexo.SelectedItem.ToString().Substring(0, 1));
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            switch (cbOpcoes.SelectedIndex)
            {
                case 1:
                    PesquisarPorCPF();
                    break;

                case 2:
                    PesquisarPorEstadoCivil();
                    break;

                case 3:
                    PesquisarPorSexo();
                    break;

                case 4:
                    PesquisarPorCidade();
                    break;

                case 5:
                    PesquisarPorUsuario();
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
            cbEstadoCivil.Enabled = cbOpcoes.SelectedIndex == 2;
            cbSexo.Enabled = cbOpcoes.SelectedIndex == 3 || cbOpcoes.SelectedIndex == 7;
            cbCidade.Enabled = cbOpcoes.SelectedIndex == 4 || cbOpcoes.SelectedIndex == 7;
            tbUsuario.Enabled = cbOpcoes.SelectedIndex == 5;
            cbStatus.Enabled = cbOpcoes.SelectedIndex == 6;
        }

        private void dgvClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja alterar ou excluir o cliente selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                // Cria o funcionario e obtém os dados.
                Cliente cliente = new Cliente();
                cliente.ConsultaCliente(Convert.ToInt32(dgvClientes.SelectedRows[0].Cells[0].Value));

                // Cria o formulário
                FormCliente formCliente = new FormCliente();

                // Tem cep? Então o sistema não deve pegar o endereço do cep e sim o do banco.
                formCliente.tipo = "Atualização";
                if (cliente.cep != "")
                {
                    formCliente.IGNORE_FIRST_CEP_REQUEST = true;
                }

                // Define os campos do funcionário
                formCliente.tbCodigo.Text = cliente.id.ToString();
                formCliente.tbUsuario.Text = cliente.usuario;
                formCliente.tbSenha.Text = cliente.senha;
                formCliente.mtbTelefone1.Text = cliente.telefone1;
                formCliente.mtbTelefone2.Text = cliente.telefone2;
                formCliente.tbEmail.Text = cliente.email;
                formCliente.tbNome.Text = cliente.nome;
                formCliente.dtpDataNascimento.Value = cliente.data_nascimento;
                formCliente.sexo = cliente.sexo;

                formCliente.cbSexo.Text = cliente.sexo;
                formCliente.mtbCpf.Text = cliente.cpf;
                formCliente.mtbRg.Text = cliente.rg;
                formCliente.estado_civil = cliente.estado_civil;
                formCliente.mtbCep.Text = cliente.cep;
                formCliente.tbEndereco.Text = cliente.endereco;
                formCliente.tbNumero.Text = cliente.numero.ToString();
                formCliente.tbBairro.Text = cliente.bairro;
                formCliente.tbCidade.Text = cliente.cidade;
                formCliente.estado = cliente.estado;
                formCliente.tbComplemento.Text = cliente.complemento;
                formCliente.data_cadastro = cliente.data_cadastro;
                formCliente.status = cliente.status;

                // Modo exclusivo (ShowDialog)
                formCliente.ShowDialog();

                // Atualiza a grid de consulta.
                btnPesquisar_Click(this, new EventArgs());
            }
        }
    }
}
