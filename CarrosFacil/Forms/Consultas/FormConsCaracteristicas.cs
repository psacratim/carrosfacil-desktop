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
    public partial class FormConsCaracteristicas : Form
    {
        public FormConsCaracteristicas()
        {
            InitializeComponent();
        }
        private void FormConsCaracteristicas_Load(object sender, EventArgs e)
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
            DialogResult resposta = MessageBox.Show("Deseja alterar ou excluir a caracteristica selecionada?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Caracteristica caracteristica = new Caracteristica();
                caracteristica.ConsultaCaracteristica(Convert.ToInt32(dgvCaracteristicas.SelectedRows[0].Cells[0].Value));

                FormCaracteristica formCaracteristica = new FormCaracteristica();
                formCaracteristica.tipo = "Atualização";
                formCaracteristica.status = caracteristica.status;

                formCaracteristica.tbCodigo.Text = caracteristica.id.ToString();
                formCaracteristica.tbNome.Text = caracteristica.nome.ToString();
                formCaracteristica.tbObservacao.Text = caracteristica.observacao.ToString();

                string imagemUrl = Uploader.CarregarImagemDoServidor(caracteristica.icone);
                if (imagemUrl != "")
                {
                    try
                    {
                        formCaracteristica.pbIcon.LoadAsync(imagemUrl);
                        formCaracteristica.lbIcone.Text = caracteristica.icone;
                        formCaracteristica.imagemAtual = caracteristica.icone;
                    }
                    catch (WebException ex)
                    {
                        bool isNotFound = false;
                        if (ex.Status == WebExceptionStatus.ProtocolError && ex.Response != null)
                        {
                            var resp = (HttpWebResponse)ex.Response;
                            if (resp.StatusCode == HttpStatusCode.NotFound)
                            {
                                MessageBox.Show("A característica não tem um ícone ainda, adicione se possível.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                isNotFound = true;
                            }
                        }

                        if (!isNotFound)
                        {
                            MessageBox.Show("Não foi possível acessar o ícone da caracteristica.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                } else
                {
                    MessageBox.Show("A característica não tem um ícone ainda, adicione se possível.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                    formCaracteristica.ShowDialog();

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
    }
}
