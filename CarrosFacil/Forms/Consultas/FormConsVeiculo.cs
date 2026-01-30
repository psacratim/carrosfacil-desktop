using CarrosFacil.Entities;
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

namespace CarrosFacil.Forms.Consultas
{
    public partial class FormConsVeiculo : Form
    {
        public FormConsVeiculo()
        {
            InitializeComponent();
        }

        private void FormConsVeiculo_Load(object sender, EventArgs e)
        {
            // Carrega as opções de busca disponíveis
            cbOpcoes.Items.Add("Desconto");
            cbOpcoes.Items.Add("Status");
            cbOpcoes.Items.Add("Modelo");
            cbOpcoes.Items.Add("Categoria");
            cbOpcoes.Items.Add("Estado do Veículo");
            cbOpcoes.Items.Add("Estoque");
            cbOpcoes.SelectedIndex = 0;

            // Carregar opções de desconto
            cbDesconto.Items.Add("Com Desconto");
            cbDesconto.Items.Add("Sem Desconto");
            cbDesconto.SelectedIndex = 0;

            // Carregar status
            cbStatus.Items.Add("Desativado");
            cbStatus.Items.Add("Ativado");
            cbStatus.SelectedIndex = 1;

            // Carregar estados de veículo
            cbEstadoVeiculo.Items.Add("Novo");
            cbEstadoVeiculo.Items.Add("Semi-novo");
            cbEstadoVeiculo.Items.Add("Usado");
            cbEstadoVeiculo.SelectedIndex = 0;

            // Carregar categorias
            // TODO: Pegar somente as usadas pelo banco
            cbCategoria.Items.Add("SUV");
            cbCategoria.Items.Add("Esportivo");
            cbCategoria.Items.Add("Utilitário");
            cbCategoria.Items.Add("Sedan");
            cbCategoria.Items.Add("Hatch");
            cbCategoria.SelectedIndex = 0;

            // Carregar modelos (DB)
            _ = Task.Run(() =>
            {
                Veiculo veiculo = new Veiculo();
                DataTable modelos = veiculo.CarregarModelos(); // Usa o método que traz id/nome
                this.Invoke((Action)(() =>
                {
                    cbModelo.DataSource = modelos;
                    cbModelo.DisplayMember = "modelo";
                    cbModelo.ValueMember = "id_modelo";
                }));
            });
        }

        private void PesquisarPorDesconto()
        {
            bool comDesconto = cbDesconto.SelectedIndex == 0;
            dgvVeiculos.DataSource = new Veiculo().ConsultarPorDesconto(comDesconto);
        }

        private void PesquisarPorStatus()
        {
            int status = cbStatus.SelectedIndex;
            dgvVeiculos.DataSource = new Veiculo().ConsultarPorStatus(status);
        }

        private void PesquisarPorModelo()
        {
            if (cbModelo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um modelo válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbModelo.Focus();
                return;
            }

            int codigoModelo = Convert.ToInt32(cbModelo.SelectedValue);
            dgvVeiculos.DataSource = new Veiculo().ConsultarPorModelo(codigoModelo);
        }

        private void PesquisarPorCategoria()
        {
            if (cbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma categoria válida.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCategoria.Focus();
                return;
            }

            dgvVeiculos.DataSource = new Veiculo().ConsultarPorCategoria(cbCategoria.SelectedItem.ToString());
        }

        private void PesquisarPorEstadoVeiculo()
        {
            if (cbEstadoVeiculo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um estado de veículo válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbEstadoVeiculo.Focus();
                return;
            }

            dgvVeiculos.DataSource = new Veiculo().ConsultarPorEstado(cbEstadoVeiculo.SelectedItem.ToString());
        }

        private void PesquisarPorEstoque()
        {
            if (tbEstoque.Text.Trim() == "")
            {
                MessageBox.Show("Digite uma quantidade válida para o estoque.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbEstoque.BackColor = Color.Red;
                tbEstoque.Focus();
                return;
            }

            int quantidade;
            if (!int.TryParse(tbEstoque.Text, out quantidade))
            {
                MessageBox.Show("Valor inválido no campo de estoque.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool maiorIgual = rbMaior.Checked;
            dgvVeiculos.DataSource = new Veiculo().ConsultarPorEstoque(quantidade, maiorIgual);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            switch (cbOpcoes.SelectedIndex)
            {
                case 0:
                    PesquisarPorDesconto();
                    break;
                case 1:
                    PesquisarPorStatus();
                    break;
                case 2:
                    PesquisarPorModelo();
                    break;
                case 3:
                    PesquisarPorCategoria();
                    break;
                case 4:
                    PesquisarPorEstadoVeiculo();
                    break;
                case 5:
                    PesquisarPorEstoque();
                    break;
                default:
                    MessageBox.Show("Selecione uma opção de busca válida.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvVeiculos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DialogResult resposta = MessageBox.Show("Deseja visualizar ou editar o veículo selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                int idVeiculo = Convert.ToInt32(dgvVeiculos.SelectedRows[0].Cells[0].Value);

                Veiculo veiculo = new Veiculo();
                veiculo.ConsultaVeiculo(idVeiculo);

                FormVeiculo formVeiculo = new FormVeiculo();

                // Define o tipo de operação
                formVeiculo.tipo = "Atualização";
                formVeiculo.tbCodigo.Text = veiculo.id.ToString();
                formVeiculo.id_modelo = veiculo.id_modelo;
                formVeiculo.categoria = veiculo.categoria;
                formVeiculo.estado_do_veiculo= veiculo.estado_do_veiculo;
                formVeiculo.tbTempoUso.Text = veiculo.tempo_de_uso.ToString();
                formVeiculo.tbPrecoCusto.Text = veiculo.preco_custo.ToString("N2");
                formVeiculo.tbPrecoVenda.Text = veiculo.preco_venda.ToString("N2");
                formVeiculo.tbPrecoDesconto.Text = veiculo.preco_desconto.ToString("N2");
                formVeiculo.tbDesconto.Text = veiculo.desconto.ToString();
                formVeiculo.rbDescontoNao.Checked = !veiculo.tem_desconto;
                formVeiculo.rbDescontoSim.Checked = veiculo.tem_desconto;
                formVeiculo.tbLucro.Text = veiculo.lucro.ToString();
                formVeiculo.tbKmsRodado.Text = veiculo.quilometragem.ToString();
                formVeiculo.cor = veiculo.cor;
                formVeiculo.tbDescricao.Text = veiculo.descricao;
                formVeiculo.tbAno.Text = veiculo.ano.ToString();
                formVeiculo.tipo_cambio = veiculo.tipo_cambio;
                formVeiculo.tipo_combustivel = veiculo.tipo_combustivel;
                formVeiculo.tbEstoque.Text = veiculo.estoque.ToString();
                formVeiculo.status = veiculo.status == 1 ? 1 : 0;

                formVeiculo.caracteristicasSelecionadas.AddRange(veiculo.RetornaCaracteristicas(idVeiculo));

                // Foto do veículo
                if (!string.IsNullOrWhiteSpace(veiculo.foto))
                {
                    try
                    {
                        string imagem = Uploader.CarregarImagemDoServidor(veiculo.foto);
                        if (imagem != "")
                        {
                            formVeiculo.pbFoto.LoadAsync(Uploader.CarregarImagemDoServidor(veiculo.foto));
                            formVeiculo.lbFoto.Text = veiculo.foto;
                            formVeiculo.imagem_atual = veiculo.foto;
                        } else
                        {
                            MessageBox.Show("O veículo não tem nenhuma foto, adicione se necessário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (WebException ex)
                    {
                        bool isNotFound = false;
                        if (ex.Status == WebExceptionStatus.ProtocolError && ex.Response != null)
                        {
                            var resp = (HttpWebResponse)ex.Response;
                            if (resp.StatusCode == HttpStatusCode.NotFound)
                            {
                                MessageBox.Show("O veículo não tem nenhuma foto, adicione se necessário.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                isNotFound = true;
                            }
                        }

                        if (!isNotFound) {
                            MessageBox.Show("Não foi possível carregar a foto do veículo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                // Exibe o formulário em modo modal
                formVeiculo.ShowDialog();

                // Atualiza a grid após o fechamento da tela de edição
                btnPesquisar_Click(this, new EventArgs());
            }
        }

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Desabilita todos os filtros
            cbDesconto.Enabled = false;
            cbStatus.Enabled = false;
            cbModelo.Enabled = false;
            cbCategoria.Enabled = false;
            cbEstadoVeiculo.Enabled = false;
            tbEstoque.Enabled = false;
            gbTipoBusca.Enabled = false;

            // Ativa apenas o necessário
            switch (cbOpcoes.SelectedIndex)
            {
                case 0:
                    cbDesconto.Enabled = true;
                    break;
                case 1:
                    cbStatus.Enabled = true;
                    break;
                case 2:
                    cbModelo.Enabled = true;
                    break;
                case 3:
                    cbCategoria.Enabled = true;
                    break;
                case 4:
                    cbEstadoVeiculo.Enabled = true;
                    break;
                case 5:
                    tbEstoque.Enabled = true;
                    gbTipoBusca.Enabled = true;
                    break;
                default:
                    break;
            }
        }
    }
}
