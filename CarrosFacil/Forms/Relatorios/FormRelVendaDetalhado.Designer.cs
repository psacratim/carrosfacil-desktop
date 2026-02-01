namespace CarrosFacil.Forms.Relatorios
{
    partial class formRelVendaDetalhado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRelVendaDetalhado));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RelVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnTituloFuncionario = new System.Windows.Forms.Panel();
            this.labelAviso = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbTipoRel = new System.Windows.Forms.GroupBox();
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.gbFuncionario = new System.Windows.Forms.GroupBox();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.gbPeriodo = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.rvVendas = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.RelVendaBindingSource)).BeginInit();
            this.pnTituloFuncionario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbTipoRel.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.gbFuncionario.SuspendLayout();
            this.gbPeriodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // RelVendaBindingSource
            // 
            this.RelVendaBindingSource.DataSource = typeof(CarrosFacil.Entities.RelVenda);
            // 
            // pnTituloFuncionario
            // 
            this.pnTituloFuncionario.BackColor = System.Drawing.Color.GhostWhite;
            this.pnTituloFuncionario.Controls.Add(this.labelAviso);
            this.pnTituloFuncionario.Controls.Add(this.lbTitulo);
            this.pnTituloFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTituloFuncionario.Location = new System.Drawing.Point(0, 0);
            this.pnTituloFuncionario.Name = "pnTituloFuncionario";
            this.pnTituloFuncionario.Size = new System.Drawing.Size(1067, 80);
            this.pnTituloFuncionario.TabIndex = 20;
            // 
            // labelAviso
            // 
            this.labelAviso.AutoSize = true;
            this.labelAviso.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelAviso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.labelAviso.Location = new System.Drawing.Point(24, 52);
            this.labelAviso.Name = "labelAviso";
            this.labelAviso.Size = new System.Drawing.Size(381, 15);
            this.labelAviso.TabIndex = 22;
            this.labelAviso.Text = "Analise o desempenho das vendas por período, cliente ou colaborador.";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lbTitulo.Location = new System.Drawing.Point(20, 15);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(391, 37);
            this.lbTitulo.TabIndex = 21;
            this.lbTitulo.Text = "Relatório de Vendas Detalhado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbTipoRel);
            this.panel1.Controls.Add(this.gbCliente);
            this.panel1.Controls.Add(this.gbFuncionario);
            this.panel1.Controls.Add(this.gbPeriodo);
            this.panel1.Controls.Add(this.btGerarRelatorio);
            this.panel1.Controls.Add(this.btSair);
            this.panel1.Location = new System.Drawing.Point(27, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 488);
            this.panel1.TabIndex = 25;
            // 
            // gbTipoRel
            // 
            this.gbTipoRel.Controls.Add(this.cbTipoRel);
            this.gbTipoRel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbTipoRel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbTipoRel.Location = new System.Drawing.Point(13, 12);
            this.gbTipoRel.Name = "gbTipoRel";
            this.gbTipoRel.Size = new System.Drawing.Size(180, 60);
            this.gbTipoRel.TabIndex = 0;
            this.gbTipoRel.TabStop = false;
            this.gbTipoRel.Text = "* Tipo de Relatório";
            // 
            // cbTipoRel
            // 
            this.cbTipoRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoRel.Location = new System.Drawing.Point(10, 25);
            this.cbTipoRel.Name = "cbTipoRel";
            this.cbTipoRel.Size = new System.Drawing.Size(160, 23);
            this.cbTipoRel.TabIndex = 1;
            this.cbTipoRel.SelectedIndexChanged += new System.EventHandler(this.cbTipoRel_SelectedIndexChanged);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.cbCliente);
            this.gbCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbCliente.Location = new System.Drawing.Point(13, 78);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(180, 60);
            this.gbCliente.TabIndex = 2;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.Location = new System.Drawing.Point(10, 25);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(160, 23);
            this.cbCliente.TabIndex = 3;
            // 
            // gbFuncionario
            // 
            this.gbFuncionario.Controls.Add(this.cbFuncionario);
            this.gbFuncionario.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbFuncionario.Location = new System.Drawing.Point(13, 144);
            this.gbFuncionario.Name = "gbFuncionario";
            this.gbFuncionario.Size = new System.Drawing.Size(180, 60);
            this.gbFuncionario.TabIndex = 4;
            this.gbFuncionario.TabStop = false;
            this.gbFuncionario.Text = "Funcionário";
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuncionario.Location = new System.Drawing.Point(10, 25);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(160, 23);
            this.cbFuncionario.TabIndex = 5;
            // 
            // gbPeriodo
            // 
            this.gbPeriodo.Controls.Add(this.label5);
            this.gbPeriodo.Controls.Add(this.label4);
            this.gbPeriodo.Controls.Add(this.dtpDataFinal);
            this.gbPeriodo.Controls.Add(this.dtpDataInicial);
            this.gbPeriodo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.gbPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbPeriodo.Location = new System.Drawing.Point(13, 210);
            this.gbPeriodo.Name = "gbPeriodo";
            this.gbPeriodo.Size = new System.Drawing.Size(180, 85);
            this.gbPeriodo.TabIndex = 6;
            this.gbPeriodo.TabStop = false;
            this.gbPeriodo.Text = "Período";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Até:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "De:";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(40, 52);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(130, 23);
            this.dtpDataFinal.TabIndex = 1;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(40, 22);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(130, 23);
            this.dtpDataInicial.TabIndex = 0;
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
            this.btGerarRelatorio.Location = new System.Drawing.Point(13, 366);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btGerarRelatorio.Size = new System.Drawing.Size(180, 40);
            this.btGerarRelatorio.TabIndex = 7;
            this.btGerarRelatorio.Text = "   Gerar Relatório";
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
            this.btSair.Location = new System.Drawing.Point(13, 421);
            this.btSair.Name = "btSair";
            this.btSair.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btSair.Size = new System.Drawing.Size(180, 40);
            this.btSair.TabIndex = 8;
            this.btSair.Text = "   Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // rvVendas
            // 
            reportDataSource2.Name = "dsRelVenda";
            reportDataSource2.Value = this.RelVendaBindingSource;
            this.rvVendas.LocalReport.DataSources.Add(reportDataSource2);
            this.rvVendas.LocalReport.ReportEmbeddedResource = "CarrosFacil.Forms.Relatorios.RDLCs.RPTVendaDetalhado.rdlc";
            this.rvVendas.Location = new System.Drawing.Point(252, 101);
            this.rvVendas.Name = "rvVendas";
            this.rvVendas.ServerReport.BearerToken = null;
            this.rvVendas.Size = new System.Drawing.Size(791, 488);
            this.rvVendas.TabIndex = 24;
            // 
            // formRelVendaDetalhado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1067, 613);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rvVendas);
            this.Controls.Add(this.pnTituloFuncionario);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formRelVendaDetalhado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Vendas Detalhado";
            this.Load += new System.EventHandler(this.formRelVendaDetalhado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RelVendaBindingSource)).EndInit();
            this.pnTituloFuncionario.ResumeLayout(false);
            this.pnTituloFuncionario.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbTipoRel.ResumeLayout(false);
            this.gbCliente.ResumeLayout(false);
            this.gbFuncionario.ResumeLayout(false);
            this.gbPeriodo.ResumeLayout(false);
            this.gbPeriodo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTituloFuncionario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox gbTipoRel;
        private System.Windows.Forms.GroupBox gbFuncionario;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btGerarRelatorio;
        private System.Windows.Forms.GroupBox gbPeriodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        public System.Windows.Forms.ComboBox cbTipoRel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelAviso;
        private Microsoft.Reporting.WinForms.ReportViewer rvVendas;
        private System.Windows.Forms.BindingSource RelVendaBindingSource;
    }
}