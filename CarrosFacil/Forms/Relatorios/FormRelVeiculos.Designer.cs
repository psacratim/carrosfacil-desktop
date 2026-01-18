namespace CarrosFacil.Forms.Relatorios
{
    partial class FormRelVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelVeiculo));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.VeiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.gbModelo = new System.Windows.Forms.GroupBox();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.gbLucro = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtLucroMaximo = new System.Windows.Forms.TextBox();
            this.txtLucroMinimo = new System.Windows.Forms.TextBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.pnTituloFuncionario = new System.Windows.Forms.Panel();
            this.labelAviso = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.gbTipoRel = new System.Windows.Forms.GroupBox();
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.btSair = new System.Windows.Forms.Button();
            this.rvVeiculo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.VeiculoBindingSource)).BeginInit();
            this.gbCategoria.SuspendLayout();
            this.gbEstado.SuspendLayout();
            this.gbModelo.SuspendLayout();
            this.gbLucro.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.pnTituloFuncionario.SuspendLayout();
            this.gbTipoRel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.cbCategoria);
            this.gbCategoria.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbCategoria.Location = new System.Drawing.Point(13, 144);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(180, 60);
            this.gbCategoria.TabIndex = 0;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(10, 25);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(160, 23);
            this.cbCategoria.TabIndex = 1;
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
            this.btGerarRelatorio.Location = new System.Drawing.Point(13, 419);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btGerarRelatorio.Size = new System.Drawing.Size(180, 40);
            this.btGerarRelatorio.TabIndex = 2;
            this.btGerarRelatorio.Text = "  Gerar Relatório";
            this.btGerarRelatorio.UseVisualStyleBackColor = false;
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.cbEstado);
            this.gbEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbEstado.Location = new System.Drawing.Point(13, 276);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(180, 60);
            this.gbEstado.TabIndex = 2;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado Veículo";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(10, 25);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(158, 23);
            this.cbEstado.TabIndex = 3;
            // 
            // gbModelo
            // 
            this.gbModelo.Controls.Add(this.cbModelo);
            this.gbModelo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbModelo.Location = new System.Drawing.Point(13, 210);
            this.gbModelo.Name = "gbModelo";
            this.gbModelo.Size = new System.Drawing.Size(180, 60);
            this.gbModelo.TabIndex = 4;
            this.gbModelo.TabStop = false;
            this.gbModelo.Text = "Modelo";
            // 
            // cbModelo
            // 
            this.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(10, 25);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(160, 23);
            this.cbModelo.TabIndex = 5;
            // 
            // gbLucro
            // 
            this.gbLucro.Controls.Add(this.label14);
            this.gbLucro.Controls.Add(this.label13);
            this.gbLucro.Controls.Add(this.txtLucroMaximo);
            this.gbLucro.Controls.Add(this.txtLucroMinimo);
            this.gbLucro.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbLucro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbLucro.Location = new System.Drawing.Point(13, 342);
            this.gbLucro.Name = "gbLucro";
            this.gbLucro.Size = new System.Drawing.Size(180, 60);
            this.gbLucro.TabIndex = 6;
            this.gbLucro.TabStop = false;
            this.gbLucro.Text = "Faixa de Lucro (%)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(92, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 15);
            this.label14.TabIndex = 10;
            this.label14.Text = "Até:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "De:";
            // 
            // txtLucroMaximo
            // 
            this.txtLucroMaximo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLucroMaximo.Location = new System.Drawing.Point(125, 26);
            this.txtLucroMaximo.Name = "txtLucroMaximo";
            this.txtLucroMaximo.Size = new System.Drawing.Size(45, 23);
            this.txtLucroMaximo.TabIndex = 8;
            // 
            // txtLucroMinimo
            // 
            this.txtLucroMinimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLucroMinimo.Location = new System.Drawing.Point(40, 26);
            this.txtLucroMinimo.Name = "txtLucroMinimo";
            this.txtLucroMinimo.Size = new System.Drawing.Size(45, 23);
            this.txtLucroMinimo.TabIndex = 7;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbStatus.Location = new System.Drawing.Point(13, 78);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(180, 60);
            this.gbStatus.TabIndex = 18;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(106, 27);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(62, 19);
            this.rbInativo.TabIndex = 17;
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
            this.rbAtivo.TabIndex = 16;
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
            this.pnTituloFuncionario.Size = new System.Drawing.Size(1041, 80);
            this.pnTituloFuncionario.TabIndex = 20;
            // 
            // labelAviso
            // 
            this.labelAviso.AutoSize = true;
            this.labelAviso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelAviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.labelAviso.Location = new System.Drawing.Point(24, 52);
            this.labelAviso.Name = "labelAviso";
            this.labelAviso.Size = new System.Drawing.Size(365, 15);
            this.labelAviso.TabIndex = 22;
            this.labelAviso.Text = "Filtre a frota por categoria, modelo ou rentabilidade para o relatório.";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lbTitulo.Location = new System.Drawing.Point(20, 15);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(271, 37);
            this.lbTitulo.TabIndex = 21;
            this.lbTitulo.Text = "Relatório de Veículos";
            // 
            // gbTipoRel
            // 
            this.gbTipoRel.Controls.Add(this.cbTipoRel);
            this.gbTipoRel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbTipoRel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbTipoRel.Location = new System.Drawing.Point(13, 12);
            this.gbTipoRel.Name = "gbTipoRel";
            this.gbTipoRel.Size = new System.Drawing.Size(180, 60);
            this.gbTipoRel.TabIndex = 22;
            this.gbTipoRel.TabStop = false;
            this.gbTipoRel.Text = "* Tipo de Relatório";
            // 
            // cbTipoRel
            // 
            this.cbTipoRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoRel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbTipoRel.FormattingEnabled = true;
            this.cbTipoRel.Location = new System.Drawing.Point(10, 25);
            this.cbTipoRel.Name = "cbTipoRel";
            this.cbTipoRel.Size = new System.Drawing.Size(160, 23);
            this.cbTipoRel.TabIndex = 4;
            this.cbTipoRel.SelectedIndexChanged += new System.EventHandler(this.cbTipoRel_SelectedIndexChanged);
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
            this.btSair.Location = new System.Drawing.Point(13, 465);
            this.btSair.Name = "btSair";
            this.btSair.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btSair.Size = new System.Drawing.Size(180, 40);
            this.btSair.TabIndex = 23;
            this.btSair.Text = "  Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // rvVeiculo
            // 
            reportDataSource1.Name = "dsVeiculos";
            reportDataSource1.Value = this.VeiculoBindingSource;
            this.rvVeiculo.LocalReport.DataSources.Add(reportDataSource1);
            this.rvVeiculo.LocalReport.ReportEmbeddedResource = "CarrosFacil.Forms.Relatorios.RDLCs.RPTVeiculos.rdlc";
            this.rvVeiculo.Location = new System.Drawing.Point(252, 101);
            this.rvVeiculo.Name = "rvVeiculo";
            this.rvVeiculo.ServerReport.BearerToken = null;
            this.rvVeiculo.Size = new System.Drawing.Size(759, 524);
            this.rvVeiculo.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbTipoRel);
            this.panel1.Controls.Add(this.gbStatus);
            this.panel1.Controls.Add(this.btSair);
            this.panel1.Controls.Add(this.gbCategoria);
            this.panel1.Controls.Add(this.btGerarRelatorio);
            this.panel1.Controls.Add(this.gbLucro);
            this.panel1.Controls.Add(this.gbModelo);
            this.panel1.Controls.Add(this.gbEstado);
            this.panel1.Location = new System.Drawing.Point(27, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 524);
            this.panel1.TabIndex = 25;
            // 
            // FormRelVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1041, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rvVeiculo);
            this.Controls.Add(this.pnTituloFuncionario);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRelVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios de Veículos";
            this.Load += new System.EventHandler(this.FormRelVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VeiculoBindingSource)).EndInit();
            this.gbCategoria.ResumeLayout(false);
            this.gbEstado.ResumeLayout(false);
            this.gbModelo.ResumeLayout(false);
            this.gbLucro.ResumeLayout(false);
            this.gbLucro.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.pnTituloFuncionario.ResumeLayout(false);
            this.pnTituloFuncionario.PerformLayout();
            this.gbTipoRel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btGerarRelatorio;
        public System.Windows.Forms.ComboBox cbTipoRel;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.GroupBox gbModelo;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.GroupBox gbLucro;
        private System.Windows.Forms.TextBox txtLucroMaximo;
        private System.Windows.Forms.TextBox txtLucroMinimo;
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
        private Microsoft.Reporting.WinForms.ReportViewer rvVeiculo;
        private System.Windows.Forms.BindingSource VeiculoBindingSource;
        private System.Windows.Forms.Panel panel1;
    }
}