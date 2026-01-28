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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pnTituloFuncionario = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.gbFuncionario = new System.Windows.Forms.GroupBox();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            this.gbPeriodo = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rvVendas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RelVendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnTituloFuncionario.SuspendLayout();
            this.gbFuncionario.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.gbPeriodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RelVendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTituloFuncionario
            // 
            this.pnTituloFuncionario.Controls.Add(this.lbTitulo);
            this.pnTituloFuncionario.Location = new System.Drawing.Point(9, 12);
            this.pnTituloFuncionario.Name = "pnTituloFuncionario";
            this.pnTituloFuncionario.Size = new System.Drawing.Size(792, 39);
            this.pnTituloFuncionario.TabIndex = 71;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(246, 5);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(328, 29);
            this.lbTitulo.TabIndex = 65;
            this.lbTitulo.Text = "Relatório de Vendas  Detalhado";
            // 
            // gbFuncionario
            // 
            this.gbFuncionario.Controls.Add(this.cbFuncionario);
            this.gbFuncionario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFuncionario.Location = new System.Drawing.Point(581, 118);
            this.gbFuncionario.Name = "gbFuncionario";
            this.gbFuncionario.Size = new System.Drawing.Size(224, 72);
            this.gbFuncionario.TabIndex = 109;
            this.gbFuncionario.TabStop = false;
            this.gbFuncionario.Text = "Funcionário:";
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuncionario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(9, 28);
            this.cbFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(200, 27);
            this.cbFuncionario.TabIndex = 66;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.cbCliente);
            this.gbCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(351, 118);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(224, 72);
            this.gbCliente.TabIndex = 110;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente:";
            // 
            // cbCliente
            // 
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(9, 28);
            this.cbCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(200, 27);
            this.cbCliente.TabIndex = 66;
            // 
            // btSair
            // 
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSair.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Image = ((System.Drawing.Image)(resources.GetObject("btSair.Image")));
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(706, 60);
            this.btSair.Name = "btSair";
            this.btSair.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btSair.Size = new System.Drawing.Size(95, 50);
            this.btSair.TabIndex = 114;
            this.btSair.Text = "     Sair";
            this.btSair.UseVisualStyleBackColor = true;
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGerarRelatorio.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerarRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btGerarRelatorio.Image")));
            this.btGerarRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGerarRelatorio.Location = new System.Drawing.Point(521, 60);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btGerarRelatorio.Size = new System.Drawing.Size(176, 50);
            this.btGerarRelatorio.TabIndex = 113;
            this.btGerarRelatorio.Text = "     Gerar Relatório";
            this.btGerarRelatorio.UseVisualStyleBackColor = true;
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
            // 
            // gbPeriodo
            // 
            this.gbPeriodo.Controls.Add(this.label5);
            this.gbPeriodo.Controls.Add(this.label4);
            this.gbPeriodo.Controls.Add(this.dtpDataFinal);
            this.gbPeriodo.Controls.Add(this.dtpDataInicial);
            this.gbPeriodo.Location = new System.Drawing.Point(14, 118);
            this.gbPeriodo.Name = "gbPeriodo";
            this.gbPeriodo.Size = new System.Drawing.Size(327, 72);
            this.gbPeriodo.TabIndex = 108;
            this.gbPeriodo.TabStop = false;
            this.gbPeriodo.Text = "Período de Vendas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 19);
            this.label5.TabIndex = 46;
            this.label5.Text = "Até:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 19);
            this.label4.TabIndex = 46;
            this.label4.Text = "De:";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(200, 28);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(116, 27);
            this.dtpDataFinal.TabIndex = 1;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(40, 28);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(116, 27);
            this.dtpDataInicial.TabIndex = 0;
            // 
            // cbTipoRel
            // 
            this.cbTipoRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoRel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoRel.FormattingEnabled = true;
            this.cbTipoRel.Location = new System.Drawing.Point(261, 72);
            this.cbTipoRel.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoRel.Name = "cbTipoRel";
            this.cbTipoRel.Size = new System.Drawing.Size(244, 27);
            this.cbTipoRel.TabIndex = 112;
            this.cbTipoRel.SelectedIndexChanged += new System.EventHandler(this.cbTipoRel_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 23);
            this.label7.TabIndex = 111;
            this.label7.Text = "Selecione o Tipo de Relatório:";
            // 
            // rvVendas
            // 
            reportDataSource1.Name = "dsRelVenda";
            reportDataSource1.Value = this.RelVendaBindingSource;
            this.rvVendas.LocalReport.DataSources.Add(reportDataSource1);
            this.rvVendas.LocalReport.ReportEmbeddedResource = "CarrosFacil.Forms.Relatorios.RDLCs.RPTVendaDetalhado.rdlc";
            this.rvVendas.Location = new System.Drawing.Point(14, 214);
            this.rvVendas.Name = "rvVendas";
            this.rvVendas.ServerReport.BearerToken = null;
            this.rvVendas.Size = new System.Drawing.Size(791, 488);
            this.rvVendas.TabIndex = 115;
            // 
            // RelVendaBindingSource
            // 
            this.RelVendaBindingSource.DataSource = typeof(CarrosFacil.Entities.RelVenda);
            // 
            // formRelVendaDetalhado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 728);
            this.Controls.Add(this.rvVendas);
            this.Controls.Add(this.gbFuncionario);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btGerarRelatorio);
            this.Controls.Add(this.gbPeriodo);
            this.Controls.Add(this.cbTipoRel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pnTituloFuncionario);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formRelVendaDetalhado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formRelVendaDetalhado";
            this.Load += new System.EventHandler(this.formRelVendaDetalhado_Load);
            this.pnTituloFuncionario.ResumeLayout(false);
            this.pnTituloFuncionario.PerformLayout();
            this.gbFuncionario.ResumeLayout(false);
            this.gbCliente.ResumeLayout(false);
            this.gbPeriodo.ResumeLayout(false);
            this.gbPeriodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RelVendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnTituloFuncionario;
        private System.Windows.Forms.Label lbTitulo;
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
        private Microsoft.Reporting.WinForms.ReportViewer rvVendas;
        private System.Windows.Forms.BindingSource RelVendaBindingSource;
    }
}