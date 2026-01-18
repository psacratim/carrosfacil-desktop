using CarrosFacil.Entities;
using Nito.Disposables;
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
    public partial class FormVeiculo : Form
    {
        public FormVeiculo()
        {
            InitializeComponent();
        }

        public int status, id_modelo;
        public string tipo, imagem_atual, tipo_combustivel, tipo_cambio, cor, categoria, estado_do_veiculo;
        public List<int> caracteristicasSelecionadas = new List<int>();

        private void FormVeiculo_Load(object sender, EventArgs e)
        {
            // Status
            cbStatus.Items.Add("Desativado");
            cbStatus.Items.Add("Ativado");
            cbStatus.SelectedIndex = 1;

            // Estado do veículo
            cbEstadoVeiculo.Items.Add("Usado");
            cbEstadoVeiculo.Items.Add("Semi-novo");
            cbEstadoVeiculo.Items.Add("Novo");
            cbEstadoVeiculo.SelectedIndex = -1;

            // Tipo de combustivel
            cbTipoCombustivel.DataSource = new[]
            {
                new {Id = "Gasolina", Nome = "Gasolina" },
                new {Id = "Etanol", Nome = "Etanol" },
                new {Id = "Flex", Nome = "Flex" },
                new {Id = "Diesel", Nome = "Diesel" },
                new {Id = "GNV", Nome = "Gás Natural Veicular" },
            };
            cbTipoCombustivel.DisplayMember = "Nome";
            cbTipoCombustivel.ValueMember = "Id";


            // Tipo de câmbio
            cbTipoCambio.DataSource = new[]
            {
                new {Id = "Manual", Nome = "Manual" },
                new {Id = "Auto Trad.", Nome = "Automático Tradicional" },
                new {Id = "CVT", Nome = "(CVT) Transmissão Continuamente Variável" },
                new {Id = "Auto Mono.", Nome = "Automatizado Monoembreagem" },
                new {Id = "DCT", Nome = "(DCT) Automático de Dupla Embreagem" },
            };
            cbTipoCambio.DisplayMember = "Nome";
            cbTipoCambio.ValueMember = "Id";
            cbTipoCambio.SelectedIndex = -1;

            // Cores do veículo
            cbColor.Items.Add("Branco");
            cbColor.Items.Add("Preto");
            cbColor.Items.Add("Prata");
            cbColor.Items.Add("Cinza");
            cbColor.Items.Add("Vermelho");
            cbColor.Items.Add("Azul");
            cbColor.Items.Add("Verde");
            cbColor.Items.Add("Amarelo");
            cbColor.Items.Add("Laranja");
            cbColor.Items.Add("Marrom");
            cbColor.Items.Add("Bege");
            cbColor.Items.Add("Bordo");
            cbColor.Items.Add("Dourado");
            cbColor.Items.Add("Roxo");
            cbColor.Items.Add("Rosa");
            cbColor.Items.Add("Grafite");
            cbColor.Items.Add("Champagne");
            cbColor.Items.Add("Vinho");
            cbColor.SelectedIndex = -1;

            // Carros de passeio
            cbCategoria.Items.Add("Hatchback");
            cbCategoria.Items.Add("Sedan");
            cbCategoria.Items.Add("SUV");
            cbCategoria.Items.Add("Crossover");
            cbCategoria.Items.Add("Cupê");
            cbCategoria.Items.Add("Conversível");
            cbCategoria.Items.Add("Perua / Station Wagon");
            cbCategoria.Items.Add("Roadster");
            cbCategoria.Items.Add("Esportivo");
            cbCategoria.Items.Add("Compacto");
            cbCategoria.Items.Add("Minivan");
            cbCategoria.Items.Add("Pickup");

            // Utilitários e comerciais leves
            cbCategoria.Items.Add("Van");
            cbCategoria.Items.Add("Furgão");
            cbCategoria.Items.Add("Caminhonete");

            // Esportivos e luxo
            cbCategoria.Items.Add("Esportivo");
            cbCategoria.Items.Add("Superesportivo");
            cbCategoria.Items.Add("Luxo / Premium");
            cbCategoria.Items.Add("Gran Turismo (GT)");
            cbCategoria.Items.Add("Roadster");
            cbCategoria.Items.Add("Conversível Esportivo");

            // Caminhões e veículos pesados
            cbCategoria.Items.Add("Caminhão Leve");
            cbCategoria.Items.Add("Caminhão Médio");
            cbCategoria.Items.Add("Caminhão Pesado");
            cbCategoria.Items.Add("Carreta");

            // Motos e similares
            cbCategoria.Items.Add("Motocicleta");
            cbCategoria.Items.Add("Scooter");
            cbCategoria.Items.Add("Triciclo");
            cbCategoria.Items.Add("Quadriciclo");

            // Veículos especiais
            cbCategoria.Items.Add("Buggy");
            cbCategoria.Items.Add("Off-Road / 4x4");
            cbCategoria.Items.Add("Motorhome");

            // Configuração final
            cbCategoria.SelectedIndex = -1;

            // Modelos - ALIMENTADO PELO DB
            _ = Task.Run(() =>
            {
                Modelo modelo = new Modelo();
                DataTable modelos = modelo.CarregarModelos();

                this.Invoke((Action)(() =>
                {
                    cbModelo.DataSource = modelos;
                    cbModelo.DisplayMember = "nome";
                    cbModelo.ValueMember = "id";

                    AtualizarCaracteristicasUsadas();

                    // Atualiza os dados após carregar tudo
                    if (tipo == "Atualização")
                    {

                        cbModelo.SelectedValue = id_modelo;
                        cbEstadoVeiculo.SelectedItem = estado_do_veiculo;
                        cbColor.SelectedItem = cor;
                        cbTipoCambio.SelectedValue = tipo_cambio;
                        cbTipoCombustivel.SelectedValue = tipo_combustivel;
                        cbStatus.SelectedIndex = status;
                        cbCategoria.SelectedItem = categoria;

                        cbStatus.Enabled = true;
                        btnCadastrar.Enabled = false;
                        btnAtualizar.Enabled = true;
                        btnDeletar.Enabled = true;
                    }
                    else
                    {
                        cbModelo.SelectedIndex = -1;

                        cbStatus.Enabled = false;
                        btnCadastrar.Enabled = true;
                        btnAtualizar.Enabled = false;
                        btnDeletar.Enabled = false;
                    }
                }));
            });
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Aviso - Preencha os campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                DefinirCorCamposObrigatorios(Color.FromArgb(179, 221, 255));
                tbTempoUso.Focus();
                return;
            }

            if (tbPrecoVenda.Text == "")
            {
                MessageBox.Show("Por favor, insira o preço do veículo e o percentual de lucro.", "Aviso - Preencha os campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                tbPrecoCusto.BackColor = Color.Red;
                tbLucro.BackColor = Color.Red;
                return;
            }

            Veiculo veiculo = new Veiculo();
            veiculo.id_modelo = (int) cbModelo.SelectedValue;
            veiculo.categoria = cbCategoria.SelectedItem.ToString();
            veiculo.estado_do_veiculo = cbEstadoVeiculo.SelectedItem.ToString();
            veiculo.tempo_de_uso = Convert.ToInt32(tbTempoUso.Text);
            veiculo.preco_custo = Convert.ToDecimal(tbPrecoCusto.Text.Replace(".", "").Replace(",", "."));
            veiculo.preco_venda = Convert.ToDecimal(tbPrecoVenda.Text.Replace(".", "").Replace(",", "."));
            veiculo.preco_desconto = Convert.ToDecimal(tbPrecoDesconto.Text.Replace(".", "").Replace(",", "."));
            if (rbDescontoSim.Checked)
            {
                try
                {
                    veiculo.desconto = Convert.ToInt32(tbDesconto.Text);
                } catch (FormatException)
                {
                    MessageBox.Show("Erro: Somente número é permitido no campo de desconto.", "Aviso - Preencha os campos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            veiculo.tem_desconto = rbDescontoSim.Checked;
            if (veiculo.tem_desconto && veiculo.preco_desconto < veiculo.preco_custo)
            {
                MessageBox.Show("O preço com desconto é menor que o de custo, diminua o desconto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            veiculo.lucro = Convert.ToInt32(tbLucro.Text);
            veiculo.quilometragem = Convert.ToInt32(tbKmsRodado.Text);
            veiculo.cor = cbColor.SelectedItem.ToString();
            veiculo.descricao = tbDescricao.Text;
            veiculo.ano = Convert.ToInt32(tbAno.Text);
            veiculo.tipo_cambio = cbTipoCambio.SelectedValue.ToString();
            veiculo.tipo_combustivel = cbTipoCombustivel.SelectedValue.ToString();
            veiculo.estoque = Convert.ToInt32(tbEstoque.Text);
            veiculo.status = 1;
            veiculo.caracteristicas = caracteristicasSelecionadas;

            // SALVANDO A FOTO NO BANCO DE DADOS!
            string fotoVeiculo = await Uploader.EnviarImagem(lbFoto.Text);
            if (fotoVeiculo.Contains("error"))
            {
                MessageBox.Show("Erro ao salvar a foto, veículo será salvo sem foto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                veiculo.foto = fotoVeiculo;
            }

            int response = veiculo.Cadastrar();
            if (response == 0)
            {
                MessageBox.Show("Não foi possível cadastrar o veículo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Veiculo cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Limpar();
            }
        }


        private bool ValidarCampos()
        {
            if (cbModelo.SelectedIndex == -1 ||
            cbCategoria.SelectedIndex == -1 ||
            cbEstadoVeiculo.SelectedIndex == -1 ||
            tbTempoUso.Text == "" ||
            tbKmsRodado.Text == "" ||
            cbColor.SelectedIndex == -1 ||
            tbDescricao.Text == "" ||
            tbAno.Text == "" ||
            cbTipoCambio.SelectedIndex == -1 ||
            cbTipoCombustivel.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        private void DefinirCorCamposObrigatorios(Color color)
        {
            cbModelo.BackColor = color;
            cbCategoria.BackColor = color;
            cbEstadoVeiculo.BackColor = color;
            tbTempoUso.BackColor = color;
            tbKmsRodado.BackColor = color;
            cbColor.BackColor = color;
            tbDescricao.BackColor = color;
            tbAno.BackColor = color;
            cbTipoCambio.BackColor = color;
            cbTipoCombustivel.BackColor = color;
            tbPrecoCusto.BackColor = color;
            tbLucro.BackColor = color;
        }

        private void Limpar()
        {
            cbModelo.SelectedIndex = -1;
            cbCategoria.SelectedIndex = -1;
            cbEstadoVeiculo.SelectedIndex = -1;
            tbTempoUso.Clear();
            tbKmsRodado.Clear();
            cbColor.SelectedIndex = -1;
            tbDescricao.Clear();
            tbAno.Clear();
            tbEstoque.Clear();
            cbTipoCambio.SelectedIndex = -1;
            tbPrecoVenda.Clear();
            tbPrecoCusto.Clear();
            tbLucro.Clear();
            tbDesconto.Clear();
            tbPrecoDesconto.Clear();
            rbDescontoSim.Checked = false;
            rbDescontoNao.Checked = true;
            lbFoto.Text = "Nenhuma foto selecionada";
            pbFoto.Image = pbFoto.InitialImage;

            cbTipoCombustivel.SelectedIndex = -1;
            dgvCaracteristicas.DataSource = null;
            cbModelo.SelectedIndex = -1;
            cbTipoCambio.SelectedIndex = -1;
        }
        private void tbPercentualLucro_TextChanged(object sender, EventArgs e)
        {
            AtualizarPrecoVendas();
        }

        private void tbPreco_TextChanged(object sender, EventArgs e)
        {
            AtualizarPrecoVendas();
        }

        private void AtualizarPrecoVendas()
        {
            if (tbPrecoCusto.Text == "" || tbLucro.Text == "") return;

            decimal precoCusto = SafeDecimalConvert(tbPrecoCusto.Text, "Por favor, digite apenas números válidos!");
            decimal percentualLucro = SafeDecimalConvert(tbLucro.Text, "Por favor, digite apenas números válidos!");

            if (percentualLucro < 1)
            {
                MessageBox.Show("Por favor, insira um lucro maior ou igual a 1%.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal fatorLucro = 1 + (percentualLucro / 100); // Output (Example): 1.5 (+50%)
            decimal precoVenda = precoCusto * fatorLucro;
            decimal precoDesconto = 0;

            if (rbDescontoSim.Checked)
            {
                decimal desconto = 1 - SafeDecimalConvert(tbDesconto.Text, "Por favor, digite um desconto entre 1% e 100%!") / 100;
                precoDesconto = precoVenda * desconto;
            }

            tbPrecoVenda.Text = precoVenda.ToString("N2");
            tbPrecoDesconto.Text = precoDesconto.ToString("N2");
        }

        private decimal SafeDecimalConvert(string text, string errorMessage)
        {
            try
            {
                return Convert.ToDecimal(text);
            } catch (FormatException)
            {
                MessageBox.Show(errorMessage, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
        }

        private void tbTempoUso_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Char 08: BACKSPACE
            // Char 27: Escape
            // Char 44: ,
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 27 && e.KeyChar != 01)
            {
                e.Handled = true;
                MessageBox.Show("Esse campo aceita somente números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbDescontoSim_CheckedChanged(object sender, EventArgs e)
        {
            tbDesconto.Enabled = true;
        }

        private void rbDescontoNao_CheckedChanged(object sender, EventArgs e)
        {
            tbPrecoDesconto.Text = "0";
            tbDesconto.Enabled = false;
        }

        private void tbDesconto_TextChanged(object sender, EventArgs e)
        {
            AtualizarPrecoVendas();
        }

        private void pbFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageSelectDialog = new OpenFileDialog();
            imageSelectDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            imageSelectDialog.Title = "Selecionar foto";

            if (imageSelectDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbFoto.Image = new Bitmap(imageSelectDialog.FileName);
                    lbFoto.Text = imageSelectDialog.FileName.Replace("\\", "//");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro ao carregar imagem, tente novamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
                        if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44 && e.KeyChar != 27 && e.KeyChar != 01 && e.KeyChar != 46)
            {
                e.Handled = true;
                MessageBox.Show("Esse campo aceita somente números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 44 && e.KeyChar != 27 && e.KeyChar != 01 && e.KeyChar != 46)
            {
                e.Handled = true;
                MessageBox.Show("Esse campo aceita somente números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvCaracteristicas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void tbAdicionar_Click(object sender, EventArgs e)
        {
            var formSelecionarCaracteristicas = new FormSelecionarCaracteristicas(this);
            formSelecionarCaracteristicas.Show();
        }

        private void tbPercentualLucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 27 && e.KeyChar != 01)
            {
                e.Handled = true;
                MessageBox.Show("Esse campo aceita somente números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbRemoverSelecionado_Click(object sender, EventArgs e)
        {
            if (dgvCaracteristicas.CurrentCell == null)
            {
                MessageBox.Show("Por favor, clique na característica que deseja remover.", "Nenhuma seleção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataGridViewRow currentRow = dgvCaracteristicas.Rows[dgvCaracteristicas.CurrentCell.RowIndex];

                int idParaRemover = Convert.ToInt32(currentRow.Cells[0].Value);

                if (caracteristicasSelecionadas.Contains(idParaRemover))
                {
                    caracteristicasSelecionadas.Remove(idParaRemover);
                }

                AtualizarCaracteristicasUsadas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao remover a característica: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (tipo != "Atualização")
            {
                MessageBox.Show("Erro: Para excluir um veiculo, entre no modo de atualização.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbCodigo.Text, out int codigo))
            {
                MessageBox.Show("Erro: Não foi possível válidar o código desse veiculo. Re-abra no modo atualização.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Confirme: Você realmente quer excluír esse veículo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                if (Veiculo.Excluir(codigo) == 0)
                {
                    MessageBox.Show("Erro: Não foi possível excluir o veiculo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                MessageBox.Show("Sucesso: Veiculo excluído com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void tbKmsRodado_KeyPress_1(TextBox sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 27 && e.KeyChar != 01)
            {
                e.Handled = true;
                MessageBox.Show("Esse campo aceita somente números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas o último digito da placa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbKmsRodado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 27 && e.KeyChar != 01)
            {
                e.Handled = true;
                MessageBox.Show("Esse campo aceita somente números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                DefinirCorCamposObrigatorios(Color.FromArgb(179, 221, 255));
                tbTempoUso.Focus();
                return;
            }

            if (tbPrecoVenda.Text == "")
            {
                MessageBox.Show("Por favor, insira o preço do veículo e o percentual de lucro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                tbPrecoCusto.BackColor = Color.Red;
                tbLucro.BackColor = Color.Red;
                return;
            }

            decimal preco_custo = Convert.ToDecimal(tbPrecoCusto.Text.Replace(".", ""));
            decimal preco_venda = Convert.ToDecimal(tbPrecoVenda.Text.Replace(".", ""));
            decimal preco_desconto = Convert.ToDecimal(tbPrecoDesconto.Text.Replace(".", "")); ;
            if (rbDescontoSim.Checked && preco_desconto < preco_custo)
            {
                MessageBox.Show("O preço com desconto não pode ser menor que o de custo, ajuste o desconto ou desative.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                tbDesconto.BackColor = Color.Red;
                tbDesconto.Focus();
                return;
            }

            Veiculo veiculo = new Veiculo();
            veiculo.id = Convert.ToInt32(tbCodigo.Text);
            veiculo.id_modelo = (int)cbModelo.SelectedValue;
            veiculo.categoria = cbCategoria.SelectedItem.ToString();
            veiculo.estado_do_veiculo = cbEstadoVeiculo.SelectedItem.ToString();
            veiculo.tempo_de_uso = Convert.ToInt32(tbTempoUso.Text);
            veiculo.preco_custo = preco_custo;
            veiculo.preco_venda = preco_venda;
            veiculo.preco_desconto = preco_desconto;
            veiculo.desconto = Convert.ToInt32(tbDesconto.Text);
            veiculo.tem_desconto = rbDescontoSim.Checked;
            if (veiculo.tem_desconto && veiculo.preco_desconto < veiculo.preco_custo)
            {
                MessageBox.Show("O preço com desconto é menor que o de custo, diminua o desconto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            veiculo.lucro = Convert.ToInt32(tbLucro.Text);
            veiculo.quilometragem = Convert.ToInt32(tbKmsRodado.Text);
            veiculo.cor = cbColor.SelectedItem.ToString();
            veiculo.descricao = tbDescricao.Text;
            veiculo.ano = Convert.ToInt32(tbAno.Text);
            veiculo.tipo_cambio = cbTipoCambio.SelectedValue.ToString();
            veiculo.tipo_combustivel = cbTipoCombustivel.SelectedValue.ToString();
            veiculo.estoque = Convert.ToInt32(tbEstoque.Text);
            veiculo.status = cbStatus.SelectedIndex;
            veiculo.caracteristicas = caracteristicasSelecionadas;

            // SALVANDO A FOTO NO BANCO DE DADOS!
            if (imagem_atual != lbFoto.Text)
            {
                string fotoVeiculo = await Uploader.EnviarImagem(lbFoto.Text);
                if (fotoVeiculo.Contains("error"))
                {
                    MessageBox.Show("Erro ao salvar a foto, veículo será salvo sem foto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    veiculo.foto = fotoVeiculo;
                }
            }

            int response = veiculo.AtualizarVeiculo();
            if (response == 0)
            {
                MessageBox.Show("Não foi possível atualizar o veículo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Veiculo atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        public void AtualizarCaracteristicasUsadas()
        {

            if (caracteristicasSelecionadas.Count > 0)
            {
                dgvCaracteristicas.DataSource = new Caracteristica().ConsultarPorCodigos(caracteristicasSelecionadas);
            }
            else
            {
                dgvCaracteristicas.DataSource = null;
            }

            foreach (DataGridViewRow row in dgvCaracteristicas.SelectedRows)
            {
                int codigoCaracteristica = Convert.ToInt32(row.Cells[0].Value);
                if (caracteristicasSelecionadas.Contains(codigoCaracteristica))
                {
                    caracteristicasSelecionadas.Remove(codigoCaracteristica);
                }
                else
                {
                    caracteristicasSelecionadas.Add(codigoCaracteristica);
                }

                // Muda a cor da celula pra verde caso esteja selecionado
                var cor = caracteristicasSelecionadas.Contains(codigoCaracteristica) ? Color.Green : Color.Gray;
                dgvCaracteristicas.SelectedRows[0].DefaultCellStyle.BackColor = cor;
                dgvCaracteristicas.SelectedRows[0].DefaultCellStyle.SelectionBackColor = cor;
            }
        }

        private void btnAddCaracteristica_Click(object sender, EventArgs e)
        {

        }

        private void btnDelCaracteristica_Click(object sender, EventArgs e)
        {

        }
    }
}
