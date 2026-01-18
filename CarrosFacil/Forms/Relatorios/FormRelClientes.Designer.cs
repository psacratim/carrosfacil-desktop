namespace CarrosFacil.Forms.Relatorios
{
    partial class FormRelClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelClientes));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.gbCidade = new System.Windows.Forms.GroupBox();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.gbAniversariantes = new System.Windows.Forms.GroupBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.gbIdade = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIdadeFinal = new System.Windows.Forms.TextBox();
            this.txtIdadeInicial = new System.Windows.Forms.TextBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.pnTituloFuncionario = new System.Windows.Forms.Panel();
            this.labelAviso = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.gbTipoRel = new System.Windows.Forms.GroupBox();
            this.rvClientes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).BeginInit();
            this.gbSexo.SuspendLayout();
            this.gbCidade.SuspendLayout();
            this.gbAniversariantes.SuspendLayout();
            this.gbIdade.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.pnTituloFuncionario.SuspendLayout();
            this.gbTipoRel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btGerarRelatorio.Location = new System.Drawing.Point(15, 423);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btGerarRelatorio.Size = new System.Drawing.Size(200, 40);
            this.btGerarRelatorio.TabIndex = 0;
            this.btGerarRelatorio.Text = "  Gerar Relatório";
            this.btGerarRelatorio.UseVisualStyleBackColor = false;
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.cbSexo);
            this.gbSexo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbSexo.Location = new System.Drawing.Point(15, 346);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(200, 60);
            this.gbSexo.TabIndex = 1;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbSexo.Location = new System.Drawing.Point(10, 25);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(100, 23);
            this.cbSexo.TabIndex = 2;
            // 
            // cbTipoRel
            // 
            this.cbTipoRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoRel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbTipoRel.Location = new System.Drawing.Point(10, 25);
            this.cbTipoRel.Name = "cbTipoRel";
            this.cbTipoRel.Size = new System.Drawing.Size(180, 23);
            this.cbTipoRel.TabIndex = 3;
            this.cbTipoRel.SelectedIndexChanged += new System.EventHandler(this.cbTipoRel_SelectedIndexChanged);
            // 
            // gbCidade
            // 
            this.gbCidade.Controls.Add(this.cbCidade);
            this.gbCidade.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbCidade.Location = new System.Drawing.Point(15, 280);
            this.gbCidade.Name = "gbCidade";
            this.gbCidade.Size = new System.Drawing.Size(200, 60);
            this.gbCidade.TabIndex = 4;
            this.gbCidade.TabStop = false;
            this.gbCidade.Text = "Cidade";
            // 
            // cbCidade
            // 
            this.cbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidade.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbCidade.Location = new System.Drawing.Point(10, 25);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(180, 23);
            this.cbCidade.TabIndex = 5;
            // 
            // gbAniversariantes
            // 
            this.gbAniversariantes.Controls.Add(this.cbMes);
            this.gbAniversariantes.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbAniversariantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbAniversariantes.Location = new System.Drawing.Point(15, 148);
            this.gbAniversariantes.Name = "gbAniversariantes";
            this.gbAniversariantes.Size = new System.Drawing.Size(200, 60);
            this.gbAniversariantes.TabIndex = 6;
            this.gbAniversariantes.TabStop = false;
            this.gbAniversariantes.Text = "Mês Aniversário";
            // 
            // cbMes
            // 
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbMes.Location = new System.Drawing.Point(10, 25);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(180, 23);
            this.cbMes.TabIndex = 7;
            // 
            // gbIdade
            // 
            this.gbIdade.Controls.Add(this.label14);
            this.gbIdade.Controls.Add(this.label13);
            this.gbIdade.Controls.Add(this.txtIdadeFinal);
            this.gbIdade.Controls.Add(this.txtIdadeInicial);
            this.gbIdade.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbIdade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbIdade.Location = new System.Drawing.Point(15, 214);
            this.gbIdade.Name = "gbIdade";
            this.gbIdade.Size = new System.Drawing.Size(200, 60);
            this.gbIdade.TabIndex = 8;
            this.gbIdade.TabStop = false;
            this.gbIdade.Text = "Faixa Etária";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(99, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 15);
            this.label14.TabIndex = 12;
            this.label14.Text = "Até:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "De:";
            // 
            // txtIdadeFinal
            // 
            this.txtIdadeFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdadeFinal.Location = new System.Drawing.Point(133, 27);
            this.txtIdadeFinal.Name = "txtIdadeFinal";
            this.txtIdadeFinal.Size = new System.Drawing.Size(57, 23);
            this.txtIdadeFinal.TabIndex = 10;
            // 
            // txtIdadeInicial
            // 
            this.txtIdadeInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdadeInicial.Location = new System.Drawing.Point(32, 27);
            this.txtIdadeInicial.Name = "txtIdadeInicial";
            this.txtIdadeInicial.Size = new System.Drawing.Size(50, 23);
            this.txtIdadeInicial.TabIndex = 9;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbStatus.Location = new System.Drawing.Point(15, 82);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(200, 60);
            this.gbStatus.TabIndex = 19;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(128, 27);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(62, 19);
            this.rbInativo.TabIndex = 18;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Checked = true;
            this.rbAtivo.Location = new System.Drawing.Point(10, 27);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(53, 19);
            this.rbAtivo.TabIndex = 17;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // pnTituloFuncionario
            // 
            this.pnTituloFuncionario.BackColor = System.Drawing.Color.GhostWhite;
            this.pnTituloFuncionario.Controls.Add(this.labelAviso);
            this.pnTituloFuncionario.Controls.Add(this.lbTitulo);
            this.pnTituloFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTituloFuncionario.Location = new System.Drawing.Point(0, 0);
            this.pnTituloFuncionario.Name = "pnTituloFuncionario";
            this.pnTituloFuncionario.Size = new System.Drawing.Size(1058, 80);
            this.pnTituloFuncionario.TabIndex = 22;
            // 
            // labelAviso
            // 
            this.labelAviso.AutoSize = true;
            this.labelAviso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelAviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.labelAviso.Location = new System.Drawing.Point(24, 52);
            this.labelAviso.Name = "labelAviso";
            this.labelAviso.Size = new System.Drawing.Size(289, 15);
            this.labelAviso.TabIndex = 21;
            this.labelAviso.Text = "Selecione os filtros abaixo para extrair as informações.";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lbTitulo.Location = new System.Drawing.Point(20, 15);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(268, 37);
            this.lbTitulo.TabIndex = 20;
            this.lbTitulo.Text = "Relatório de Clientes";
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
            this.btSair.Location = new System.Drawing.Point(15, 469);
            this.btSair.Name = "btSair";
            this.btSair.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btSair.Size = new System.Drawing.Size(200, 40);
            this.btSair.TabIndex = 24;
            this.btSair.Text = "  Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // gbTipoRel
            // 
            this.gbTipoRel.Controls.Add(this.cbTipoRel);
            this.gbTipoRel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbTipoRel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbTipoRel.Location = new System.Drawing.Point(15, 16);
            this.gbTipoRel.Name = "gbTipoRel";
            this.gbTipoRel.Size = new System.Drawing.Size(200, 60);
            this.gbTipoRel.TabIndex = 23;
            this.gbTipoRel.TabStop = false;
            this.gbTipoRel.Text = "* Tipo de Relatório";
            // 
            // rvClientes
            // 
            reportDataSource2.Name = "dsClientes";
            reportDataSource2.Value = this.ClienteBindingSource;
            this.rvClientes.LocalReport.DataSources.Add(reportDataSource2);
            this.rvClientes.LocalReport.ReportEmbeddedResource = "CarrosFacil.Forms.Relatorios.RDLCs.RPTCliente.rdlc";
            this.rvClientes.Location = new System.Drawing.Point(278, 97);
            this.rvClientes.Name = "rvClientes";
            this.rvClientes.ServerReport.BearerToken = null;
            this.rvClientes.Size = new System.Drawing.Size(759, 525);
            this.rvClientes.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btGerarRelatorio);
            this.panel1.Controls.Add(this.gbTipoRel);
            this.panel1.Controls.Add(this.btSair);
            this.panel1.Controls.Add(this.gbSexo);
            this.panel1.Controls.Add(this.gbStatus);
            this.panel1.Controls.Add(this.gbIdade);
            this.panel1.Controls.Add(this.gbCidade);
            this.panel1.Controls.Add(this.gbAniversariantes);
            this.panel1.Location = new System.Drawing.Point(27, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 525);
            this.panel1.TabIndex = 26;
            // 
            // FormRelClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1058, 643);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rvClientes);
            this.Controls.Add(this.pnTituloFuncionario);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRelClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios de Clientes";
            this.Load += new System.EventHandler(this.FormRelClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).EndInit();
            this.gbSexo.ResumeLayout(false);
            this.gbCidade.ResumeLayout(false);
            this.gbAniversariantes.ResumeLayout(false);
            this.gbIdade.ResumeLayout(false);
            this.gbIdade.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.pnTituloFuncionario.ResumeLayout(false);
            this.pnTituloFuncionario.PerformLayout();
            this.gbTipoRel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btGerarRelatorio;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.ComboBox cbSexo;
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
        private System.Windows.Forms.BindingSource ClienteBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rvClientes;
        private System.Windows.Forms.Panel panel1;
    }
}