
namespace CarrosFacil.Forms
{
    partial class FormVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVeiculo));
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEstadoVeiculo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoCombustivel = new System.Windows.Forms.ComboBox();
            this.cbTipoCambio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTempoUso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPrecoCusto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbKmsRodado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbAno = new System.Windows.Forms.MaskedTextBox();
            this.tbLucro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbPrecoVenda = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbDescontoNao = new System.Windows.Forms.RadioButton();
            this.rbDescontoSim = new System.Windows.Forms.RadioButton();
            this.tbPrecoDesconto = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbPrecoVenda = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbDesconto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbDadosRegistro = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.gbEspecificacoes = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbEstoque = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCaracteristicas = new System.Windows.Forms.DataGridView();
            this.tbAdicionar = new System.Windows.Forms.Button();
            this.tbRemoverSelecionado = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbFoto = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.gbPrecoVenda.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbDadosRegistro.SuspendLayout();
            this.gbEspecificacoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteristicas)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // cbModelo
            // 
            this.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelo.Location = new System.Drawing.Point(15, 50);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(315, 25);
            this.cbModelo.TabIndex = 71;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(1190, 645);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSair.Size = new System.Drawing.Size(110, 40);
            this.btnSair.TabIndex = 70;
            this.btnSair.Text = "  Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDeletar.Enabled = false;
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnDeletar.ForeColor = System.Drawing.Color.White;
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.Location = new System.Drawing.Point(305, 645);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDeletar.Size = new System.Drawing.Size(130, 40);
            this.btnDeletar.TabIndex = 69;
            this.btnDeletar.Text = "  Excluir";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAtualizar.Enabled = false;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnAtualizar.ForeColor = System.Drawing.Color.White;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(165, 645);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAtualizar.Size = new System.Drawing.Size(130, 40);
            this.btnAtualizar.TabIndex = 68;
            this.btnAtualizar.Text = "  Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(25, 645);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCadastrar.Size = new System.Drawing.Size(130, 40);
            this.btnCadastrar.TabIndex = 67;
            this.btnCadastrar.Text = "  Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Location = new System.Drawing.Point(345, 50);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(315, 25);
            this.cbCategoria.TabIndex = 66;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label12.Location = new System.Drawing.Point(20, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(229, 37);
            this.label12.TabIndex = 65;
            this.label12.Text = "Cadastrar Veículo";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label26.Location = new System.Drawing.Point(24, 60);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(232, 15);
            this.label26.TabIndex = 64;
            this.label26.Text = "* Todos os campos com * são obrigatórios.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(15, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 63;
            this.label4.Text = "* Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(345, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 62;
            this.label1.Text = "* Categoria:";
            // 
            // cbEstadoVeiculo
            // 
            this.cbEstadoVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoVeiculo.Location = new System.Drawing.Point(130, 115);
            this.cbEstadoVeiculo.Name = "cbEstadoVeiculo";
            this.cbEstadoVeiculo.Size = new System.Drawing.Size(130, 25);
            this.cbEstadoVeiculo.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(130, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 80;
            this.label2.Text = "* Estado do Veículo:";
            // 
            // cbTipoCombustivel
            // 
            this.cbTipoCombustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCombustivel.Location = new System.Drawing.Point(15, 50);
            this.cbTipoCombustivel.Name = "cbTipoCombustivel";
            this.cbTipoCombustivel.Size = new System.Drawing.Size(120, 25);
            this.cbTipoCombustivel.TabIndex = 79;
            // 
            // cbTipoCambio
            // 
            this.cbTipoCambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCambio.Location = new System.Drawing.Point(145, 50);
            this.cbTipoCambio.Name = "cbTipoCambio";
            this.cbTipoCambio.Size = new System.Drawing.Size(150, 25);
            this.cbTipoCambio.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(15, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 77;
            this.label3.Text = "* Combustível:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(145, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 76;
            this.label6.Text = "* Tipo de Câmbio:";
            // 
            // tbTempoUso
            // 
            this.tbTempoUso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTempoUso.Location = new System.Drawing.Point(280, 115);
            this.tbTempoUso.MaxLength = 5;
            this.tbTempoUso.Name = "tbTempoUso";
            this.tbTempoUso.Size = new System.Drawing.Size(120, 25);
            this.tbTempoUso.TabIndex = 82;
            this.tbTempoUso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTempoUso_KeyPress_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.Location = new System.Drawing.Point(277, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 15);
            this.label7.TabIndex = 83;
            this.label7.Text = "* Tempo Uso (Dias):";
            // 
            // tbPrecoCusto
            // 
            this.tbPrecoCusto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrecoCusto.Location = new System.Drawing.Point(15, 50);
            this.tbPrecoCusto.MaxLength = 13;
            this.tbPrecoCusto.Name = "tbPrecoCusto";
            this.tbPrecoCusto.Size = new System.Drawing.Size(140, 25);
            this.tbPrecoCusto.TabIndex = 84;
            this.tbPrecoCusto.TextChanged += new System.EventHandler(this.tbPreco_TextChanged);
            this.tbPrecoCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPreco_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(15, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 85;
            this.label8.Text = "* Preço Custo:";
            // 
            // tbKmsRodado
            // 
            this.tbKmsRodado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbKmsRodado.Location = new System.Drawing.Point(515, 50);
            this.tbKmsRodado.MaxLength = 5;
            this.tbKmsRodado.Name = "tbKmsRodado";
            this.tbKmsRodado.Size = new System.Drawing.Size(145, 25);
            this.tbKmsRodado.TabIndex = 86;
            this.tbKmsRodado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKmsRodado_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.Location = new System.Drawing.Point(515, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 87;
            this.label9.Text = "* KMs:";
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.Location = new System.Drawing.Point(305, 50);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(110, 25);
            this.cbColor.TabIndex = 93;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label13.Location = new System.Drawing.Point(305, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 92;
            this.label13.Text = "* Cor:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label14.Location = new System.Drawing.Point(425, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 15);
            this.label14.TabIndex = 95;
            this.label14.Text = "* Ano:";
            // 
            // tbDescricao
            // 
            this.tbDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDescricao.Location = new System.Drawing.Point(15, 175);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(645, 65);
            this.tbDescricao.TabIndex = 102;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label18.Location = new System.Drawing.Point(15, 155);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 15);
            this.label18.TabIndex = 103;
            this.label18.Text = "* Descrição:";
            // 
            // tbAno
            // 
            this.tbAno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAno.Location = new System.Drawing.Point(425, 50);
            this.tbAno.Mask = "0000";
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(80, 25);
            this.tbAno.TabIndex = 106;
            // 
            // tbLucro
            // 
            this.tbLucro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLucro.Location = new System.Drawing.Point(15, 115);
            this.tbLucro.MaxLength = 5;
            this.tbLucro.Name = "tbLucro";
            this.tbLucro.Size = new System.Drawing.Size(140, 25);
            this.tbLucro.TabIndex = 107;
            this.tbLucro.TextChanged += new System.EventHandler(this.tbPercentualLucro_TextChanged);
            this.tbLucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPercentualLucro_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label10.Location = new System.Drawing.Point(15, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 15);
            this.label10.TabIndex = 108;
            this.label10.Text = "* Lucro (%):";
            // 
            // gbPrecoVenda
            // 
            this.gbPrecoVenda.Controls.Add(this.groupBox3);
            this.gbPrecoVenda.Controls.Add(this.tbPrecoDesconto);
            this.gbPrecoVenda.Controls.Add(this.label20);
            this.gbPrecoVenda.Controls.Add(this.tbPrecoVenda);
            this.gbPrecoVenda.Controls.Add(this.label17);
            this.gbPrecoVenda.Controls.Add(this.tbDesconto);
            this.gbPrecoVenda.Controls.Add(this.label5);
            this.gbPrecoVenda.Controls.Add(this.tbPrecoCusto);
            this.gbPrecoVenda.Controls.Add(this.label8);
            this.gbPrecoVenda.Controls.Add(this.tbLucro);
            this.gbPrecoVenda.Controls.Add(this.label10);
            this.gbPrecoVenda.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gbPrecoVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbPrecoVenda.Location = new System.Drawing.Point(220, 95);
            this.gbPrecoVenda.Name = "gbPrecoVenda";
            this.gbPrecoVenda.Size = new System.Drawing.Size(480, 160);
            this.gbPrecoVenda.TabIndex = 111;
            this.gbPrecoVenda.TabStop = false;
            this.gbPrecoVenda.Text = "Financeiro / Precificação";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbDescontoNao);
            this.groupBox3.Controls.Add(this.rbDescontoSim);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.groupBox3.Location = new System.Drawing.Point(170, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 55);
            this.groupBox3.TabIndex = 118;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ativar desconto?";
            // 
            // rbDescontoNao
            // 
            this.rbDescontoNao.AutoSize = true;
            this.rbDescontoNao.Checked = true;
            this.rbDescontoNao.Location = new System.Drawing.Point(75, 25);
            this.rbDescontoNao.Name = "rbDescontoNao";
            this.rbDescontoNao.Size = new System.Drawing.Size(47, 19);
            this.rbDescontoNao.TabIndex = 117;
            this.rbDescontoNao.TabStop = true;
            this.rbDescontoNao.Text = "Não";
            this.rbDescontoNao.UseVisualStyleBackColor = true;
            this.rbDescontoNao.CheckedChanged += new System.EventHandler(this.rbDescontoNao_CheckedChanged);
            // 
            // rbDescontoSim
            // 
            this.rbDescontoSim.AutoSize = true;
            this.rbDescontoSim.Location = new System.Drawing.Point(15, 25);
            this.rbDescontoSim.Name = "rbDescontoSim";
            this.rbDescontoSim.Size = new System.Drawing.Size(45, 19);
            this.rbDescontoSim.TabIndex = 116;
            this.rbDescontoSim.Text = "Sim";
            this.rbDescontoSim.UseVisualStyleBackColor = true;
            this.rbDescontoSim.CheckedChanged += new System.EventHandler(this.rbDescontoSim_CheckedChanged);
            // 
            // tbPrecoDesconto
            // 
            this.tbPrecoDesconto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.tbPrecoDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrecoDesconto.Enabled = false;
            this.tbPrecoDesconto.Location = new System.Drawing.Point(325, 50);
            this.tbPrecoDesconto.Name = "tbPrecoDesconto";
            this.tbPrecoDesconto.Size = new System.Drawing.Size(140, 25);
            this.tbPrecoDesconto.TabIndex = 113;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label20.Location = new System.Drawing.Point(325, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(101, 15);
            this.label20.TabIndex = 114;
            this.label20.Text = "* Preço Desconto:";
            // 
            // tbPrecoVenda
            // 
            this.tbPrecoVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.tbPrecoVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrecoVenda.Enabled = false;
            this.tbPrecoVenda.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tbPrecoVenda.Location = new System.Drawing.Point(170, 50);
            this.tbPrecoVenda.Name = "tbPrecoVenda";
            this.tbPrecoVenda.Size = new System.Drawing.Size(140, 25);
            this.tbPrecoVenda.TabIndex = 111;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label17.Location = new System.Drawing.Point(170, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 15);
            this.label17.TabIndex = 112;
            this.label17.Text = "* Preço Venda:";
            // 
            // tbDesconto
            // 
            this.tbDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDesconto.Enabled = false;
            this.tbDesconto.Location = new System.Drawing.Point(325, 115);
            this.tbDesconto.MaxLength = 3;
            this.tbDesconto.Name = "tbDesconto";
            this.tbDesconto.Size = new System.Drawing.Size(140, 25);
            this.tbDesconto.TabIndex = 109;
            this.tbDesconto.TextChanged += new System.EventHandler(this.tbDesconto_TextChanged);
            this.tbDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDesconto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(325, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 110;
            this.label5.Text = "Desconto (%):";
            // 
            // gbDadosRegistro
            // 
            this.gbDadosRegistro.Controls.Add(this.label19);
            this.gbDadosRegistro.Controls.Add(this.label16);
            this.gbDadosRegistro.Controls.Add(this.cbStatus);
            this.gbDadosRegistro.Controls.Add(this.tbCodigo);
            this.gbDadosRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gbDadosRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbDadosRegistro.Location = new System.Drawing.Point(25, 95);
            this.gbDadosRegistro.Name = "gbDadosRegistro";
            this.gbDadosRegistro.Size = new System.Drawing.Size(180, 160);
            this.gbDadosRegistro.TabIndex = 112;
            this.gbDadosRegistro.TabStop = false;
            this.gbDadosRegistro.Text = "Registro";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label19.Location = new System.Drawing.Point(15, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 15);
            this.label19.TabIndex = 37;
            this.label19.Text = "Código Veículo:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label16.Location = new System.Drawing.Point(15, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 15);
            this.label16.TabIndex = 39;
            this.label16.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Enabled = false;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(15, 115);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(150, 25);
            this.cbStatus.TabIndex = 31;
            // 
            // tbCodigo
            // 
            this.tbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Location = new System.Drawing.Point(15, 50);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(150, 25);
            this.tbCodigo.TabIndex = 31;
            // 
            // gbEspecificacoes
            // 
            this.gbEspecificacoes.Controls.Add(this.cbTipoCombustivel);
            this.gbEspecificacoes.Controls.Add(this.label3);
            this.gbEspecificacoes.Controls.Add(this.cbTipoCambio);
            this.gbEspecificacoes.Controls.Add(this.tbAno);
            this.gbEspecificacoes.Controls.Add(this.label6);
            this.gbEspecificacoes.Controls.Add(this.label13);
            this.gbEspecificacoes.Controls.Add(this.cbColor);
            this.gbEspecificacoes.Controls.Add(this.label9);
            this.gbEspecificacoes.Controls.Add(this.label14);
            this.gbEspecificacoes.Controls.Add(this.tbKmsRodado);
            this.gbEspecificacoes.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gbEspecificacoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbEspecificacoes.Location = new System.Drawing.Point(25, 260);
            this.gbEspecificacoes.Name = "gbEspecificacoes";
            this.gbEspecificacoes.Size = new System.Drawing.Size(675, 100);
            this.gbEspecificacoes.TabIndex = 113;
            this.gbEspecificacoes.TabStop = false;
            this.gbEspecificacoes.Text = "Especificações Técnicas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbEstoque);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cbModelo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbCategoria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.tbDescricao);
            this.groupBox1.Controls.Add(this.cbEstadoVeiculo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbTempoUso);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.groupBox1.Location = new System.Drawing.Point(25, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 260);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Veículo";
            // 
            // tbEstoque
            // 
            this.tbEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEstoque.Location = new System.Drawing.Point(15, 115);
            this.tbEstoque.MaxLength = 5;
            this.tbEstoque.Name = "tbEstoque";
            this.tbEstoque.Size = new System.Drawing.Size(100, 25);
            this.tbEstoque.TabIndex = 104;
            this.tbEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEstoque_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label15.Location = new System.Drawing.Point(15, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 15);
            this.label15.TabIndex = 105;
            this.label15.Text = "* Estoque:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCaracteristicas);
            this.groupBox2.Controls.Add(this.tbAdicionar);
            this.groupBox2.Controls.Add(this.tbRemoverSelecionado);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.groupBox2.Location = new System.Drawing.Point(715, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 265);
            this.groupBox2.TabIndex = 114;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Características Opcionais";
            // 
            // dgvCaracteristicas
            // 
            this.dgvCaracteristicas.BackgroundColor = System.Drawing.Color.White;
            this.dgvCaracteristicas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCaracteristicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaracteristicas.Location = new System.Drawing.Point(10, 55);
            this.dgvCaracteristicas.Name = "dgvCaracteristicas";
            this.dgvCaracteristicas.Size = new System.Drawing.Size(565, 200);
            this.dgvCaracteristicas.TabIndex = 115;
            this.dgvCaracteristicas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCaracteristicas_CellMouseClick);
            // 
            // tbAdicionar
            // 
            this.tbAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.tbAdicionar.FlatAppearance.BorderSize = 0;
            this.tbAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbAdicionar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.tbAdicionar.ForeColor = System.Drawing.Color.White;
            this.tbAdicionar.Location = new System.Drawing.Point(340, 20);
            this.tbAdicionar.Name = "tbAdicionar";
            this.tbAdicionar.Size = new System.Drawing.Size(100, 30);
            this.tbAdicionar.TabIndex = 117;
            this.tbAdicionar.Text = "Adicionar";
            this.tbAdicionar.UseVisualStyleBackColor = false;
            this.tbAdicionar.Click += new System.EventHandler(this.tbAdicionar_Click);
            // 
            // tbRemoverSelecionado
            // 
            this.tbRemoverSelecionado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.tbRemoverSelecionado.FlatAppearance.BorderSize = 0;
            this.tbRemoverSelecionado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbRemoverSelecionado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.tbRemoverSelecionado.ForeColor = System.Drawing.Color.White;
            this.tbRemoverSelecionado.Location = new System.Drawing.Point(445, 20);
            this.tbRemoverSelecionado.Name = "tbRemoverSelecionado";
            this.tbRemoverSelecionado.Size = new System.Drawing.Size(130, 30);
            this.tbRemoverSelecionado.TabIndex = 118;
            this.tbRemoverSelecionado.Text = "Remover Sel.";
            this.tbRemoverSelecionado.UseVisualStyleBackColor = false;
            this.tbRemoverSelecionado.Click += new System.EventHandler(this.tbRemoverSelecionado_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbFoto);
            this.groupBox4.Controls.Add(this.pbFoto);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.groupBox4.Location = new System.Drawing.Point(715, 365);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(585, 260);
            this.groupBox4.TabIndex = 116;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Galeria do Veículo";
            // 
            // lbFoto
            // 
            this.lbFoto.AutoSize = true;
            this.lbFoto.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbFoto.Location = new System.Drawing.Point(210, 230);
            this.lbFoto.Name = "lbFoto";
            this.lbFoto.Size = new System.Drawing.Size(152, 13);
            this.lbFoto.TabIndex = 40;
            this.lbFoto.Text = "Clique na foto para carregar";
            // 
            // pbFoto
            // 
            this.pbFoto.BackColor = System.Drawing.Color.White;
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbFoto.Image")));
            this.pbFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbFoto.InitialImage")));
            this.pbFoto.Location = new System.Drawing.Point(180, 25);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(225, 200);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            this.pbFoto.Click += new System.EventHandler(this.pbFoto_Click);
            // 
            // FormVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1320, 702);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbEspecificacoes);
            this.Controls.Add(this.gbDadosRegistro);
            this.Controls.Add(this.gbPrecoVenda);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label26);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciando - Veículo";
            this.Load += new System.EventHandler(this.FormVeiculo_Load);
            this.gbPrecoVenda.ResumeLayout(false);
            this.gbPrecoVenda.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbDadosRegistro.ResumeLayout(false);
            this.gbDadosRegistro.PerformLayout();
            this.gbEspecificacoes.ResumeLayout(false);
            this.gbEspecificacoes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaracteristicas)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbModelo;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnDeletar;
        public System.Windows.Forms.Button btnAtualizar;
        public System.Windows.Forms.Button btnCadastrar;
        public System.Windows.Forms.ComboBox cbCategoria;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label26;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbEstadoVeiculo;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbTipoCombustivel;
        public System.Windows.Forms.ComboBox cbTipoCambio;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbTempoUso;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tbPrecoCusto;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tbKmsRodado;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cbColor;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox tbDescricao;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.MaskedTextBox tbAno;
        public System.Windows.Forms.TextBox tbLucro;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.GroupBox gbPrecoVenda;
        public System.Windows.Forms.GroupBox gbDadosRegistro;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox tbCodigo;
        public System.Windows.Forms.ComboBox cbStatus;
        public System.Windows.Forms.GroupBox gbEspecificacoes;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgvCaracteristicas;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox tbPrecoDesconto;
        public System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox tbPrecoVenda;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox tbDesconto;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbEstoque;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.GroupBox groupBox4;
        public System.Windows.Forms.PictureBox pbFoto;
        public System.Windows.Forms.Label lbFoto;
        public System.Windows.Forms.RadioButton rbDescontoNao;
        public System.Windows.Forms.RadioButton rbDescontoSim;
        public System.Windows.Forms.Button tbAdicionar;
        public System.Windows.Forms.Button tbRemoverSelecionado;
    }
}