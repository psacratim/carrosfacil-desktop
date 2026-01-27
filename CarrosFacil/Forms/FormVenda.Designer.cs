
namespace CarrosFacil.Forms
{
    partial class FormVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenda));
            this.pnTituloVenda = new System.Windows.Forms.Panel();
            this.labelVendaAviso = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDataVenda = new System.Windows.Forms.TextBox();
            this.gbFuncionario = new System.Windows.Forms.GroupBox();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.txtPesqCliente = new System.Windows.Forms.TextBox();
            this.btBuscaCliente = new System.Windows.Forms.Button();
            this.gbProdutos = new System.Windows.Forms.GroupBox();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.txtPesqProduto = new System.Windows.Forms.TextBox();
            this.btBuscaProduto = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQtdeEstoque = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.gbItensVenda = new System.Windows.Forms.GroupBox();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.gbPagamneto = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbDesconto = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbValorTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbTroco = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbDinheiroFisico = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbValorPago = new System.Windows.Forms.TextBox();
            this.lbFormaPagamento = new System.Windows.Forms.Label();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.btFechaVenda = new System.Windows.Forms.Button();
            this.timerPrincipal = new System.Windows.Forms.Timer(this.components);
            this.cbParcelas = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTotalPago = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTotalDesconto = new System.Windows.Forms.TextBox();
            this.pnTituloVenda.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbFuncionario.SuspendLayout();
            this.gbClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.gbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.gbItensVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.gbPagamneto.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTituloVenda
            // 
            this.pnTituloVenda.BackColor = System.Drawing.Color.GhostWhite;
            this.pnTituloVenda.Controls.Add(this.labelVendaAviso);
            this.pnTituloVenda.Controls.Add(this.lbTitulo);
            this.pnTituloVenda.Controls.Add(this.btSair);
            this.pnTituloVenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTituloVenda.Location = new System.Drawing.Point(0, 0);
            this.pnTituloVenda.Name = "pnTituloVenda";
            this.pnTituloVenda.Size = new System.Drawing.Size(1300, 85);
            this.pnTituloVenda.TabIndex = 231;
            // 
            // labelVendaAviso
            // 
            this.labelVendaAviso.AutoSize = true;
            this.labelVendaAviso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelVendaAviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.labelVendaAviso.Location = new System.Drawing.Point(24, 55);
            this.labelVendaAviso.Name = "labelVendaAviso";
            this.labelVendaAviso.Size = new System.Drawing.Size(412, 15);
            this.labelVendaAviso.TabIndex = 0;
            this.labelVendaAviso.Text = "Utilize a pesquisa lateral para alimentar o carrinho e o checkout para finalizar." +
    "";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lbTitulo.Location = new System.Drawing.Point(20, 15);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(194, 37);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Realizar Venda";
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btSair.ForeColor = System.Drawing.Color.White;
            this.btSair.Location = new System.Drawing.Point(1180, 15);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(100, 35);
            this.btSair.TabIndex = 2;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDataVenda);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.groupBox3.Location = new System.Drawing.Point(25, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 65);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data";
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.BackColor = System.Drawing.Color.White;
            this.txtDataVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDataVenda.Enabled = false;
            this.txtDataVenda.Location = new System.Drawing.Point(10, 28);
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.Size = new System.Drawing.Size(100, 23);
            this.txtDataVenda.TabIndex = 0;
            this.txtDataVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbFuncionario
            // 
            this.gbFuncionario.Controls.Add(this.cbFuncionario);
            this.gbFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbFuncionario.Location = new System.Drawing.Point(155, 95);
            this.gbFuncionario.Name = "gbFuncionario";
            this.gbFuncionario.Size = new System.Drawing.Size(370, 65);
            this.gbFuncionario.TabIndex = 4;
            this.gbFuncionario.TabStop = false;
            this.gbFuncionario.Text = "* Vendedor Responsável";
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuncionario.Location = new System.Drawing.Point(10, 28);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(350, 23);
            this.cbFuncionario.TabIndex = 0;
            // 
            // gbClientes
            // 
            this.gbClientes.Controls.Add(this.dgvCliente);
            this.gbClientes.Controls.Add(this.txtPesqCliente);
            this.gbClientes.Controls.Add(this.btBuscaCliente);
            this.gbClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbClientes.Location = new System.Drawing.Point(25, 170);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Size = new System.Drawing.Size(500, 180);
            this.gbClientes.TabIndex = 3;
            this.gbClientes.TabStop = false;
            this.gbClientes.Text = "* Selecionar Cliente";
            // 
            // dgvCliente
            // 
            this.dgvCliente.BackgroundColor = System.Drawing.Color.White;
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCliente.Location = new System.Drawing.Point(10, 65);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(480, 105);
            this.dgvCliente.TabIndex = 0;
            // 
            // txtPesqCliente
            // 
            this.txtPesqCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesqCliente.Location = new System.Drawing.Point(10, 30);
            this.txtPesqCliente.Name = "txtPesqCliente";
            this.txtPesqCliente.Size = new System.Drawing.Size(435, 23);
            this.txtPesqCliente.TabIndex = 1;
            // 
            // btBuscaCliente
            // 
            this.btBuscaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btBuscaCliente.FlatAppearance.BorderSize = 0;
            this.btBuscaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscaCliente.Image = ((System.Drawing.Image)(resources.GetObject("btBuscaCliente.Image")));
            this.btBuscaCliente.Location = new System.Drawing.Point(450, 25);
            this.btBuscaCliente.Name = "btBuscaCliente";
            this.btBuscaCliente.Padding = new System.Windows.Forms.Padding(5);
            this.btBuscaCliente.Size = new System.Drawing.Size(40, 32);
            this.btBuscaCliente.TabIndex = 2;
            this.btBuscaCliente.UseVisualStyleBackColor = false;
            this.btBuscaCliente.Click += new System.EventHandler(this.btBuscaCliente_Click);
            // 
            // gbProdutos
            // 
            this.gbProdutos.Controls.Add(this.dgvProduto);
            this.gbProdutos.Controls.Add(this.txtPesqProduto);
            this.gbProdutos.Controls.Add(this.btBuscaProduto);
            this.gbProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbProdutos.Location = new System.Drawing.Point(25, 360);
            this.gbProdutos.Name = "gbProdutos";
            this.gbProdutos.Size = new System.Drawing.Size(500, 300);
            this.gbProdutos.TabIndex = 2;
            this.gbProdutos.TabStop = false;
            this.gbProdutos.Text = "* Pesquisar Produto";
            // 
            // dgvProduto
            // 
            this.dgvProduto.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduto.Location = new System.Drawing.Point(10, 65);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.RowHeadersVisible = false;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(480, 225);
            this.dgvProduto.TabIndex = 0;
            this.dgvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellClick);
            // 
            // txtPesqProduto
            // 
            this.txtPesqProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesqProduto.Location = new System.Drawing.Point(10, 30);
            this.txtPesqProduto.Name = "txtPesqProduto";
            this.txtPesqProduto.Size = new System.Drawing.Size(435, 23);
            this.txtPesqProduto.TabIndex = 1;
            // 
            // btBuscaProduto
            // 
            this.btBuscaProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btBuscaProduto.FlatAppearance.BorderSize = 0;
            this.btBuscaProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBuscaProduto.Image = ((System.Drawing.Image)(resources.GetObject("btBuscaProduto.Image")));
            this.btBuscaProduto.Location = new System.Drawing.Point(450, 25);
            this.btBuscaProduto.Name = "btBuscaProduto";
            this.btBuscaProduto.Padding = new System.Windows.Forms.Padding(5);
            this.btBuscaProduto.Size = new System.Drawing.Size(40, 32);
            this.btBuscaProduto.TabIndex = 2;
            this.btBuscaProduto.UseVisualStyleBackColor = false;
            this.btBuscaProduto.Click += new System.EventHandler(this.btBuscaProduto_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtProduto);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtQtdeEstoque);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.txtQtde);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txtValor);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtTotal);
            this.groupBox5.Controls.Add(this.btAdicionar);
            this.groupBox5.Controls.Add(this.btRemover);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.groupBox5.Location = new System.Drawing.Point(540, 95);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(735, 150);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Configuração do Item Selecionado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Item:";
            // 
            // txtProduto
            // 
            this.txtProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProduto.Enabled = false;
            this.txtProduto.Location = new System.Drawing.Point(10, 43);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(552, 23);
            this.txtProduto.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(578, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Estoque:";
            // 
            // txtQtdeEstoque
            // 
            this.txtQtdeEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdeEstoque.Enabled = false;
            this.txtQtdeEstoque.Location = new System.Drawing.Point(578, 43);
            this.txtQtdeEstoque.Name = "txtQtdeEstoque";
            this.txtQtdeEstoque.Size = new System.Drawing.Size(147, 23);
            this.txtQtdeEstoque.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Qtde:";
            // 
            // txtQtde
            // 
            this.txtQtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtde.Location = new System.Drawing.Point(10, 103);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(80, 23);
            this.txtQtde.TabIndex = 5;
            this.txtQtde.TextChanged += new System.EventHandler(this.txtQtde_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Vlr. Unitário:";
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(100, 103);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(120, 23);
            this.txtValor.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total do Item:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(230, 103);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(120, 23);
            this.txtTotal.TabIndex = 9;
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btAdicionar.FlatAppearance.BorderSize = 0;
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btAdicionar.ForeColor = System.Drawing.Color.White;
            this.btAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdicionar.Location = new System.Drawing.Point(455, 95);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btAdicionar.Size = new System.Drawing.Size(130, 40);
            this.btAdicionar.TabIndex = 10;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = false;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btRemover
            // 
            this.btRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btRemover.FlatAppearance.BorderSize = 0;
            this.btRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemover.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btRemover.ForeColor = System.Drawing.Color.White;
            this.btRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRemover.Location = new System.Drawing.Point(595, 95);
            this.btRemover.Name = "btRemover";
            this.btRemover.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btRemover.Size = new System.Drawing.Size(130, 40);
            this.btRemover.TabIndex = 11;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = false;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // gbItensVenda
            // 
            this.gbItensVenda.Controls.Add(this.dgvItens);
            this.gbItensVenda.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbItensVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbItensVenda.Location = new System.Drawing.Point(540, 255);
            this.gbItensVenda.Name = "gbItensVenda";
            this.gbItensVenda.Size = new System.Drawing.Size(735, 405);
            this.gbItensVenda.TabIndex = 0;
            this.gbItensVenda.TabStop = false;
            this.gbItensVenda.Text = "Itens da Venda Atual";
            // 
            // dgvItens
            // 
            this.dgvItens.BackgroundColor = System.Drawing.Color.White;
            this.dgvItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItens.Location = new System.Drawing.Point(10, 25);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(715, 370);
            this.dgvItens.TabIndex = 0;
            // 
            // gbPagamneto
            // 
            this.gbPagamneto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.gbPagamneto.Controls.Add(this.label10);
            this.gbPagamneto.Controls.Add(this.tbTotalDesconto);
            this.gbPagamneto.Controls.Add(this.label9);
            this.gbPagamneto.Controls.Add(this.tbTotalPago);
            this.gbPagamneto.Controls.Add(this.cbParcelas);
            this.gbPagamneto.Controls.Add(this.label16);
            this.gbPagamneto.Controls.Add(this.tbDesconto);
            this.gbPagamneto.Controls.Add(this.panel2);
            this.gbPagamneto.Controls.Add(this.panel1);
            this.gbPagamneto.Controls.Add(this.label1);
            this.gbPagamneto.Controls.Add(this.tbQuantidade);
            this.gbPagamneto.Controls.Add(this.label15);
            this.gbPagamneto.Controls.Add(this.tbValorTotal);
            this.gbPagamneto.Controls.Add(this.label14);
            this.gbPagamneto.Controls.Add(this.tbTroco);
            this.gbPagamneto.Controls.Add(this.label12);
            this.gbPagamneto.Controls.Add(this.tbDinheiroFisico);
            this.gbPagamneto.Controls.Add(this.label8);
            this.gbPagamneto.Controls.Add(this.label2);
            this.gbPagamneto.Controls.Add(this.tbValorPago);
            this.gbPagamneto.Controls.Add(this.lbFormaPagamento);
            this.gbPagamneto.Controls.Add(this.cbFormaPagamento);
            this.gbPagamneto.Controls.Add(this.btFechaVenda);
            this.gbPagamneto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbPagamneto.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gbPagamneto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.gbPagamneto.Location = new System.Drawing.Point(0, 666);
            this.gbPagamneto.Name = "gbPagamneto";
            this.gbPagamneto.Size = new System.Drawing.Size(1300, 136);
            this.gbPagamneto.TabIndex = 6;
            this.gbPagamneto.TabStop = false;
            this.gbPagamneto.Text = "Checkout / Finalização";
            this.gbPagamneto.Enter += new System.EventHandler(this.gbPagamneto_Enter);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(362, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 19);
            this.label16.TabIndex = 30;
            this.label16.Text = "Desconto (%):";
            // 
            // tbDesconto
            // 
            this.tbDesconto.Enabled = false;
            this.tbDesconto.Location = new System.Drawing.Point(362, 71);
            this.tbDesconto.MaxLength = 2;
            this.tbDesconto.Name = "tbDesconto";
            this.tbDesconto.Size = new System.Drawing.Size(97, 25);
            this.tbDesconto.TabIndex = 31;
            this.tbDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDesconto.TextChanged += new System.EventHandler(this.tbDesconto_TextChanged);
            this.tbDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDesconto_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(203)))));
            this.panel2.Location = new System.Drawing.Point(711, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 95);
            this.panel2.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(114)))), ((int)(((byte)(203)))));
            this.panel1.Location = new System.Drawing.Point(470, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 97);
            this.panel1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(731, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Qtd Itens:";
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Enabled = false;
            this.tbQuantidade.Location = new System.Drawing.Point(731, 105);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(136, 25);
            this.tbQuantidade.TabIndex = 27;
            this.tbQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(873, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 19);
            this.label15.TabIndex = 24;
            this.label15.Text = "Total (R$):";
            // 
            // tbValorTotal
            // 
            this.tbValorTotal.Enabled = false;
            this.tbValorTotal.Location = new System.Drawing.Point(873, 50);
            this.tbValorTotal.Name = "tbValorTotal";
            this.tbValorTotal.Size = new System.Drawing.Size(147, 25);
            this.tbValorTotal.TabIndex = 25;
            this.tbValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbValorTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDinheiroPago_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(608, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 19);
            this.label14.TabIndex = 22;
            this.label14.Text = "Troco (R$):";
            // 
            // tbTroco
            // 
            this.tbTroco.Enabled = false;
            this.tbTroco.Location = new System.Drawing.Point(608, 71);
            this.tbTroco.MaxLength = 10;
            this.tbTroco.Name = "tbTroco";
            this.tbTroco.Size = new System.Drawing.Size(93, 25);
            this.tbTroco.TabIndex = 23;
            this.tbTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(487, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "Dinheiro (R$):";
            // 
            // tbDinheiroFisico
            // 
            this.tbDinheiroFisico.Enabled = false;
            this.tbDinheiroFisico.Location = new System.Drawing.Point(487, 71);
            this.tbDinheiroFisico.MaxLength = 10;
            this.tbDinheiroFisico.Name = "tbDinheiroFisico";
            this.tbDinheiroFisico.Size = new System.Drawing.Size(115, 25);
            this.tbDinheiroFisico.TabIndex = 21;
            this.tbDinheiroFisico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDinheiroFisico.TextChanged += new System.EventHandler(this.tbDinheiroFisico_TextChanged);
            this.tbDinheiroFisico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDinheiroFisico_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Parcelas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Valor Pago (R$):";
            // 
            // tbValorPago
            // 
            this.tbValorPago.Enabled = false;
            this.tbValorPago.Location = new System.Drawing.Point(168, 71);
            this.tbValorPago.MaxLength = 10;
            this.tbValorPago.Name = "tbValorPago";
            this.tbValorPago.Size = new System.Drawing.Size(119, 25);
            this.tbValorPago.TabIndex = 10;
            this.tbValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbValorPago.TextChanged += new System.EventHandler(this.tbValorPago_TextChanged);
            this.tbValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lbFormaPagamento
            // 
            this.lbFormaPagamento.AutoSize = true;
            this.lbFormaPagamento.Location = new System.Drawing.Point(12, 50);
            this.lbFormaPagamento.Name = "lbFormaPagamento";
            this.lbFormaPagamento.Size = new System.Drawing.Size(135, 19);
            this.lbFormaPagamento.TabIndex = 2;
            this.lbFormaPagamento.Text = "* Forma Pagamento:";
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPagamento.Location = new System.Drawing.Point(12, 71);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(148, 25);
            this.cbFormaPagamento.TabIndex = 3;
            this.cbFormaPagamento.SelectedIndexChanged += new System.EventHandler(this.cbFormaPagamento_SelectedIndexChanged_1);
            // 
            // btFechaVenda
            // 
            this.btFechaVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btFechaVenda.FlatAppearance.BorderSize = 0;
            this.btFechaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFechaVenda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btFechaVenda.ForeColor = System.Drawing.Color.White;
            this.btFechaVenda.Image = ((System.Drawing.Image)(resources.GetObject("btFechaVenda.Image")));
            this.btFechaVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFechaVenda.Location = new System.Drawing.Point(1050, 50);
            this.btFechaVenda.Name = "btFechaVenda";
            this.btFechaVenda.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btFechaVenda.Size = new System.Drawing.Size(225, 60);
            this.btFechaVenda.TabIndex = 17;
            this.btFechaVenda.Text = "    FINALIZAR VENDA";
            this.btFechaVenda.UseVisualStyleBackColor = false;
            this.btFechaVenda.Click += new System.EventHandler(this.btFechaVenda_Click);
            // 
            // cbParcelas
            // 
            this.cbParcelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParcelas.Enabled = false;
            this.cbParcelas.Location = new System.Drawing.Point(297, 71);
            this.cbParcelas.Name = "cbParcelas";
            this.cbParcelas.Size = new System.Drawing.Size(59, 25);
            this.cbParcelas.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(731, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 19);
            this.label9.TabIndex = 33;
            this.label9.Text = "Total Pago (R$):";
            // 
            // tbTotalPago
            // 
            this.tbTotalPago.Enabled = false;
            this.tbTotalPago.Location = new System.Drawing.Point(731, 50);
            this.tbTotalPago.Name = "tbTotalPago";
            this.tbTotalPago.Size = new System.Drawing.Size(136, 25);
            this.tbTotalPago.TabIndex = 34;
            this.tbTotalPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(873, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 19);
            this.label10.TabIndex = 35;
            this.label10.Text = "Total Desconto (R$):";
            // 
            // tbTotalDesconto
            // 
            this.tbTotalDesconto.Enabled = false;
            this.tbTotalDesconto.Location = new System.Drawing.Point(873, 105);
            this.tbTotalDesconto.Name = "tbTotalDesconto";
            this.tbTotalDesconto.Size = new System.Drawing.Size(147, 25);
            this.tbTotalDesconto.TabIndex = 36;
            this.tbTotalDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1300, 802);
            this.Controls.Add(this.gbItensVenda);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gbProdutos);
            this.Controls.Add(this.gbClientes);
            this.Controls.Add(this.gbFuncionario);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbPagamneto);
            this.Controls.Add(this.pnTituloVenda);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDV - CarrosFácil";
            this.Load += new System.EventHandler(this.formVenda49_Load);
            this.pnTituloVenda.ResumeLayout(false);
            this.pnTituloVenda.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbFuncionario.ResumeLayout(false);
            this.gbClientes.ResumeLayout(false);
            this.gbClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.gbProdutos.ResumeLayout(false);
            this.gbProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gbItensVenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.gbPagamneto.ResumeLayout(false);
            this.gbPagamneto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.Label lbFormaPagamento;
        private System.Windows.Forms.GroupBox gbClientes;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.TextBox txtPesqCliente;
        private System.Windows.Forms.Button btBuscaCliente;
        private System.Windows.Forms.TextBox txtQtdeEstoque;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.GroupBox gbProdutos;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.TextBox txtPesqProduto;
        private System.Windows.Forms.Button btBuscaProduto;
        private System.Windows.Forms.Button btFechaVenda;
        private System.Windows.Forms.GroupBox gbItensVenda;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Panel pnTituloVenda;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.GroupBox gbFuncionario;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDataVenda;
        private System.Windows.Forms.GroupBox gbPagamneto;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelVendaAviso;
        private System.Windows.Forms.Timer timerPrincipal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbValorTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbTroco;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbDinheiroFisico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbValorPago;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbDesconto;
        private System.Windows.Forms.ComboBox cbParcelas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTotalPago;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTotalDesconto;
    }
}