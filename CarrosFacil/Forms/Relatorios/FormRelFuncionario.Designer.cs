namespace CarrosFacil.Forms.Relatorios
{
    partial class FormRelFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelFuncionario));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.FuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnTituloFuncionario = new System.Windows.Forms.Panel();
            this.labelAviso = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.gbTipoRel = new System.Windows.Forms.GroupBox();
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.gbCargo = new System.Windows.Forms.GroupBox();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.gbDataAdmissao = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.gbCidade = new System.Windows.Forms.GroupBox();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.gbAniversariantes = new System.Windows.Forms.GroupBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.gbIdade = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIdadeFinal = new System.Windows.Forms.TextBox();
            this.txtIdadeInicial = new System.Windows.Forms.TextBox();
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.rvFuncionario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.FuncionarioBindingSource)).BeginInit();
            this.pnTituloFuncionario.SuspendLayout();
            this.gbTipoRel.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbCargo.SuspendLayout();
            this.gbSexo.SuspendLayout();
            this.gbDataAdmissao.SuspendLayout();
            this.gbCidade.SuspendLayout();
            this.gbAniversariantes.SuspendLayout();
            this.gbIdade.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTituloFuncionario
            // 
            this.pnTituloFuncionario.BackColor = System.Drawing.Color.GhostWhite;
            this.pnTituloFuncionario.Controls.Add(this.labelAviso);
            this.pnTituloFuncionario.Controls.Add(this.lbTitulo);
            this.pnTituloFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTituloFuncionario.Location = new System.Drawing.Point(0, 0);
            this.pnTituloFuncionario.Name = "pnTituloFuncionario";
            this.pnTituloFuncionario.Size = new System.Drawing.Size(1201, 80);
            this.pnTituloFuncionario.TabIndex = 22;
            // 
            // labelAviso
            // 
            this.labelAviso.AutoSize = true;
            this.labelAviso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelAviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.labelAviso.Location = new System.Drawing.Point(24, 52);
            this.labelAviso.Name = "labelAviso";
            this.labelAviso.Size = new System.Drawing.Size(355, 15);
            this.labelAviso.TabIndex = 0;
            this.labelAviso.Text = "Selecione os filtros e clique em Gerar para visualizar o documento.";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lbTitulo.Location = new System.Drawing.Point(20, 15);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(328, 37);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Relatório de Funcionários";
            // 
            // gbTipoRel
            // 
            this.gbTipoRel.Controls.Add(this.cbTipoRel);
            this.gbTipoRel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbTipoRel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbTipoRel.Location = new System.Drawing.Point(12, 13);
            this.gbTipoRel.Name = "gbTipoRel";
            this.gbTipoRel.Size = new System.Drawing.Size(190, 65);
            this.gbTipoRel.TabIndex = 35;
            this.gbTipoRel.TabStop = false;
            this.gbTipoRel.Text = "* Tipo de Relatório";
            // 
            // cbTipoRel
            // 
            this.cbTipoRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoRel.Location = new System.Drawing.Point(10, 28);
            this.cbTipoRel.Name = "cbTipoRel";
            this.cbTipoRel.Size = new System.Drawing.Size(170, 23);
            this.cbTipoRel.TabIndex = 0;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbStatus.Location = new System.Drawing.Point(209, 13);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(145, 65);
            this.gbStatus.TabIndex = 34;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rbInativo
            // 
            this.rbInativo.Location = new System.Drawing.Point(75, 28);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(64, 24);
            this.rbInativo.TabIndex = 0;
            this.rbInativo.Text = "Inativo";
            // 
            // rbAtivo
            // 
            this.rbAtivo.Checked = true;
            this.rbAtivo.Location = new System.Drawing.Point(10, 28);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(59, 24);
            this.rbAtivo.TabIndex = 1;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            // 
            // gbCargo
            // 
            this.gbCargo.Controls.Add(this.cbCargo);
            this.gbCargo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbCargo.Location = new System.Drawing.Point(12, 100);
            this.gbCargo.Name = "gbCargo";
            this.gbCargo.Size = new System.Drawing.Size(190, 65);
            this.gbCargo.TabIndex = 33;
            this.gbCargo.TabStop = false;
            this.gbCargo.Text = "Cargo";
            // 
            // cbCargo
            // 
            this.cbCargo.Location = new System.Drawing.Point(10, 28);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(170, 23);
            this.cbCargo.TabIndex = 0;
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.cbSexo);
            this.gbSexo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbSexo.Location = new System.Drawing.Point(12, 171);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(161, 65);
            this.gbSexo.TabIndex = 31;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // cbSexo
            // 
            this.cbSexo.Location = new System.Drawing.Point(10, 28);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(145, 23);
            this.cbSexo.TabIndex = 1;
            // 
            // gbDataAdmissao
            // 
            this.gbDataAdmissao.Controls.Add(this.label8);
            this.gbDataAdmissao.Controls.Add(this.label6);
            this.gbDataAdmissao.Controls.Add(this.dtpDataFinal);
            this.gbDataAdmissao.Controls.Add(this.dtpDataInicial);
            this.gbDataAdmissao.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbDataAdmissao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbDataAdmissao.Location = new System.Drawing.Point(12, 251);
            this.gbDataAdmissao.Name = "gbDataAdmissao";
            this.gbDataAdmissao.Size = new System.Drawing.Size(342, 65);
            this.gbDataAdmissao.TabIndex = 32;
            this.gbDataAdmissao.TabStop = false;
            this.gbDataAdmissao.Text = "Data Admissão";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "De:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(174, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Até:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(207, 28);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(125, 23);
            this.dtpDataFinal.TabIndex = 2;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(38, 28);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(130, 23);
            this.dtpDataInicial.TabIndex = 3;
            // 
            // gbCidade
            // 
            this.gbCidade.Controls.Add(this.cbCidade);
            this.gbCidade.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbCidade.Location = new System.Drawing.Point(12, 322);
            this.gbCidade.Name = "gbCidade";
            this.gbCidade.Size = new System.Drawing.Size(342, 56);
            this.gbCidade.TabIndex = 30;
            this.gbCidade.TabStop = false;
            this.gbCidade.Text = "Cidade";
            // 
            // cbCidade
            // 
            this.cbCidade.Location = new System.Drawing.Point(10, 25);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(322, 23);
            this.cbCidade.TabIndex = 1;
            // 
            // gbAniversariantes
            // 
            this.gbAniversariantes.Controls.Add(this.cbMes);
            this.gbAniversariantes.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbAniversariantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbAniversariantes.Location = new System.Drawing.Point(209, 100);
            this.gbAniversariantes.Name = "gbAniversariantes";
            this.gbAniversariantes.Size = new System.Drawing.Size(145, 65);
            this.gbAniversariantes.TabIndex = 29;
            this.gbAniversariantes.TabStop = false;
            this.gbAniversariantes.Text = "Mês Aniversário";
            // 
            // cbMes
            // 
            this.cbMes.Location = new System.Drawing.Point(10, 28);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(129, 23);
            this.cbMes.TabIndex = 1;
            // 
            // gbIdade
            // 
            this.gbIdade.Controls.Add(this.label14);
            this.gbIdade.Controls.Add(this.label13);
            this.gbIdade.Controls.Add(this.txtIdadeFinal);
            this.gbIdade.Controls.Add(this.txtIdadeInicial);
            this.gbIdade.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbIdade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbIdade.Location = new System.Drawing.Point(179, 180);
            this.gbIdade.Name = "gbIdade";
            this.gbIdade.Size = new System.Drawing.Size(175, 56);
            this.gbIdade.TabIndex = 28;
            this.gbIdade.TabStop = false;
            this.gbIdade.Text = "Faixa Etária";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(90, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Até:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "De:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIdadeFinal
            // 
            this.txtIdadeFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdadeFinal.Location = new System.Drawing.Point(125, 25);
            this.txtIdadeFinal.Name = "txtIdadeFinal";
            this.txtIdadeFinal.Size = new System.Drawing.Size(40, 23);
            this.txtIdadeFinal.TabIndex = 2;
            // 
            // txtIdadeInicial
            // 
            this.txtIdadeInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdadeInicial.Location = new System.Drawing.Point(37, 25);
            this.txtIdadeInicial.Name = "txtIdadeInicial";
            this.txtIdadeInicial.Size = new System.Drawing.Size(40, 23);
            this.txtIdadeInicial.TabIndex = 3;
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btGerarRelatorio.FlatAppearance.BorderSize = 0;
            this.btGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGerarRelatorio.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btGerarRelatorio.ForeColor = System.Drawing.Color.White;
            this.btGerarRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btGerarRelatorio.Image")));
            this.btGerarRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGerarRelatorio.Location = new System.Drawing.Point(12, 393);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btGerarRelatorio.Size = new System.Drawing.Size(200, 40);
            this.btGerarRelatorio.TabIndex = 26;
            this.btGerarRelatorio.Text = "  Gerar Relatório";
            this.btGerarRelatorio.UseVisualStyleBackColor = false;
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btSair.FlatAppearance.BorderSize = 0;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btSair.ForeColor = System.Drawing.Color.White;
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(254, 393);
            this.btSair.Name = "btSair";
            this.btSair.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btSair.Size = new System.Drawing.Size(100, 40);
            this.btSair.TabIndex = 27;
            this.btSair.Text = "  Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // rvFuncionario
            // 
            this.rvFuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            reportDataSource1.Name = "dsFuncionario";
            reportDataSource1.Value = this.FuncionarioBindingSource;
            this.rvFuncionario.LocalReport.DataSources.Add(reportDataSource1);
            this.rvFuncionario.LocalReport.ReportEmbeddedResource = "CarrosFacil.Forms.Relatorios.RDLCs.RPTFuncionario.rdlc";
            this.rvFuncionario.Location = new System.Drawing.Point(416, 102);
            this.rvFuncionario.Name = "rvFuncionario";
            this.rvFuncionario.ServerReport.BearerToken = null;
            this.rvFuncionario.Size = new System.Drawing.Size(759, 448);
            this.rvFuncionario.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbTipoRel);
            this.panel1.Controls.Add(this.gbStatus);
            this.panel1.Controls.Add(this.btSair);
            this.panel1.Controls.Add(this.btGerarRelatorio);
            this.panel1.Controls.Add(this.gbCargo);
            this.panel1.Controls.Add(this.gbAniversariantes);
            this.panel1.Controls.Add(this.gbCidade);
            this.panel1.Controls.Add(this.gbIdade);
            this.panel1.Controls.Add(this.gbDataAdmissao);
            this.panel1.Controls.Add(this.gbSexo);
            this.panel1.Location = new System.Drawing.Point(27, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 448);
            this.panel1.TabIndex = 36;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FormRelFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1201, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rvFuncionario);
            this.Controls.Add(this.pnTituloFuncionario);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRelFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios de Funcionários";
            this.Load += new System.EventHandler(this.formRelFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FuncionarioBindingSource)).EndInit();
            this.pnTituloFuncionario.ResumeLayout(false);
            this.pnTituloFuncionario.PerformLayout();
            this.gbTipoRel.ResumeLayout(false);
            this.gbStatus.ResumeLayout(false);
            this.gbCargo.ResumeLayout(false);
            this.gbSexo.ResumeLayout(false);
            this.gbDataAdmissao.ResumeLayout(false);
            this.gbCidade.ResumeLayout(false);
            this.gbAniversariantes.ResumeLayout(false);
            this.gbIdade.ResumeLayout(false);
            this.gbIdade.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCargo;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Button btGerarRelatorio;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.GroupBox gbDataAdmissao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        public System.Windows.Forms.ComboBox cbTipoRel;
        private System.Windows.Forms.GroupBox gbCidade;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.GroupBox gbAniversariantes;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.GroupBox gbIdade;
        private System.Windows.Forms.TextBox txtIdadeFinal;
        private System.Windows.Forms.TextBox txtIdadeInicial;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelAviso;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.Panel pnTituloFuncionario;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox gbTipoRel;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.BindingSource FuncionarioBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rvFuncionario;
        private System.Windows.Forms.Panel panel1;
    }
}