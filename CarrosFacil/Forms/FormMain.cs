using CarrosFacil.Forms;
using CarrosFacil.Forms.Consultas;
using CarrosFacil.Forms.Relatorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrosFacil
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: Remover!
            UniversalMocker.Iniciar(this);
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timerPrincipal_Tick(object sender, EventArgs e)
        {
            statusLbData.Text = DateTime.Now.ToShortDateString();
            statusLbHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Deseja fechar o sistema?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void abrirFormulario<T>(T form, string errorMessage)
        {
            if (!(form is Form))
            {
                MessageBox.Show("Somente formulários devem ser abertos com abrirFormulario()", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var myForm = form as Form;
            if (Application.OpenForms.OfType<T>().Count() > 0)
            {
                MessageBox.Show(errorMessage, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            myForm.Show();
        }
        private void menuCadCargos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormCargo(), "O cadastro de cargos já está aberto.");
        }

        private void menuCadFuncionarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormFuncionario(), "O cadastro de funcionários já está aberto.");
        }

        private void menuCadMarcas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormMarca(), "O cadastro de marcas já está aberto.");
        }

        private void menuCadModelos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormModelo(), "O cadastro de modelos já está aberto.");
        }

        private void menuCadCaracteristicas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormCaracteristica(), "O cadastro de características já está aberto.");
        }

        private void menuCadCliente_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormCliente(), "O cadastro de cliente já está aberto.");
        }

        private void menuCadVeiculo_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormVeiculo(), "O cadastro de veículos já está aberto.");
        }

        private void menuConsFuncionarios_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormConsFuncionario(), "A consulta de funcionarios já está aberta.");
        }

        private void menuConsClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormConsCliente(), "A consulta de clientes já está aberta.");
        }

        private void menuConsVeiculos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormConsVeiculo(), "A consulta de veiculos já está aberta.");
        }

        private void menuConsModelos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormConsModelo(), "A consulta de modelos já está aberta.");
        }

        private void menuConsCargos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormConsCargo(), "A consulta de cargos já está aberta.");
        }

        private void menuConsCaracteristicas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormConsCaracteristicas(), "A consulta de caracteristicas já está aberta!");
        }

        private void menuConsMarcas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormConsMarca(), "A consulta de marcas já está aberta!");
        }

        private void menuRelFuncionario_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormRelFuncionario(), "O relátorio de funcionários já está aberto!");
        }

        private void menuRelClientes_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormRelClientes(), "O relátorio de clientes já está aberto!");
        }

        private void menuRelVeiculos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormRelVeiculo(), "O relátorio de veiculos já está aberto!");
        }

        private void menuVendas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FormVenda(), "O menu de vendas já está aberto!");
        }

    }
}
