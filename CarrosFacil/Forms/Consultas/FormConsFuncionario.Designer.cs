
using CarrosFacil.FormElements;

namespace CarrosFacil.Forms
{
    partial class FormConsFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsFuncionario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.cbOpcoes = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbDataAdmissao = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.gbTipoBusca = new System.Windows.Forms.GroupBox();
            this.rbContem = new System.Windows.Forms.RadioButton();
            this.rbInicio = new System.Windows.Forms.RadioButton();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.gbDataAdmissao.SuspendLayout();
            this.gbTipoBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.mskCpf);
            this.panel1.Controls.Add(this.cbOpcoes);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbCargo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.gbDataAdmissao);
            this.panel1.Controls.Add(this.gbTipoBusca);
            this.panel1.Controls.Add(this.cbSexo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbCidade);
            this.panel1.Controls.Add(this.tbNome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 423);
            this.panel1.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(10, 368);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnPesquisar.Size = new System.Drawing.Size(185, 40);
            this.btnPesquisar.TabIndex = 28;
            this.btnPesquisar.Text = "      Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
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
            this.btnSair.Location = new System.Drawing.Point(205, 368);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSair.Size = new System.Drawing.Size(105, 40);
            this.btnSair.TabIndex = 31;
            this.btnSair.Text = "      Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label10.Location = new System.Drawing.Point(205, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "CPF:";
            // 
            // mskCpf
            // 
            this.mskCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskCpf.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mskCpf.Location = new System.Drawing.Point(205, 28);
            this.mskCpf.Mask = "000,000,000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(105, 25);
            this.mskCpf.TabIndex = 24;
            // 
            // cbOpcoes
            // 
            this.cbOpcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcoes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbOpcoes.Location = new System.Drawing.Point(10, 28);
            this.cbOpcoes.Name = "cbOpcoes";
            this.cbOpcoes.Size = new System.Drawing.Size(190, 25);
            this.cbOpcoes.TabIndex = 20;
            this.cbOpcoes.SelectedIndexChanged += new System.EventHandler(this.cbOpcoes_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.Location = new System.Drawing.Point(10, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "Filtro:";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatus.Location = new System.Drawing.Point(10, 323);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(300, 25);
            this.cbStatus.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.Location = new System.Drawing.Point(10, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Status:";
            // 
            // cbCargo
            // 
            this.cbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCargo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCargo.Location = new System.Drawing.Point(10, 273);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(300, 25);
            this.cbCargo.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(10, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cargo:";
            // 
            // gbDataAdmissao
            // 
            this.gbDataAdmissao.Controls.Add(this.label6);
            this.gbDataAdmissao.Controls.Add(this.label5);
            this.gbDataAdmissao.Controls.Add(this.dtpDataFinal);
            this.gbDataAdmissao.Controls.Add(this.dtpDataInicial);
            this.gbDataAdmissao.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.gbDataAdmissao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbDataAdmissao.Location = new System.Drawing.Point(10, 170);
            this.gbDataAdmissao.Name = "gbDataAdmissao";
            this.gbDataAdmissao.Size = new System.Drawing.Size(300, 75);
            this.gbDataAdmissao.TabIndex = 14;
            this.gbDataAdmissao.TabStop = false;
            this.gbDataAdmissao.Text = "Data de Admissão";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Até:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "De:";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(155, 40);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(130, 22);
            this.dtpDataFinal.TabIndex = 3;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(10, 40);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(130, 22);
            this.dtpDataInicial.TabIndex = 2;
            // 
            // gbTipoBusca
            // 
            this.gbTipoBusca.Controls.Add(this.rbContem);
            this.gbTipoBusca.Controls.Add(this.rbInicio);
            this.gbTipoBusca.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.gbTipoBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbTipoBusca.Location = new System.Drawing.Point(10, 110);
            this.gbTipoBusca.Name = "gbTipoBusca";
            this.gbTipoBusca.Size = new System.Drawing.Size(145, 50);
            this.gbTipoBusca.TabIndex = 13;
            this.gbTipoBusca.TabStop = false;
            this.gbTipoBusca.Text = "Tipo de Busca";
            // 
            // rbContem
            // 
            this.rbContem.AutoSize = true;
            this.rbContem.Checked = true;
            this.rbContem.Location = new System.Drawing.Point(65, 22);
            this.rbContem.Name = "rbContem";
            this.rbContem.Size = new System.Drawing.Size(65, 17);
            this.rbContem.TabIndex = 8;
            this.rbContem.TabStop = true;
            this.rbContem.Text = "Contém";
            this.rbContem.UseVisualStyleBackColor = true;
            // 
            // rbInicio
            // 
            this.rbInicio.AutoSize = true;
            this.rbInicio.Location = new System.Drawing.Point(10, 22);
            this.rbInicio.Name = "rbInicio";
            this.rbInicio.Size = new System.Drawing.Size(52, 17);
            this.rbInicio.TabIndex = 7;
            this.rbInicio.Text = "Início";
            this.rbInicio.UseVisualStyleBackColor = true;
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSexo.Location = new System.Drawing.Point(165, 78);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(145, 25);
            this.cbSexo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(165, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(165, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome:";
            // 
            // cbCidade
            // 
            this.cbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCidade.Location = new System.Drawing.Point(10, 78);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(145, 25);
            this.cbCidade.TabIndex = 3;
            // 
            // tbNome
            // 
            this.tbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbNome.Location = new System.Drawing.Point(165, 130);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(145, 25);
            this.tbNome.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consulta Funcionários";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.label11.Location = new System.Drawing.Point(350, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Clique no funcionário para editar";
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToDeleteRows = false;
            this.dgvFuncionarios.AllowUserToResizeRows = false;
            this.dgvFuncionarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFuncionarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFuncionarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFuncionarios.ColumnHeadersHeight = 35;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFuncionarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFuncionarios.EnableHeadersVisualStyles = false;
            this.dgvFuncionarios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.dgvFuncionarios.Location = new System.Drawing.Point(350, 75);
            this.dgvFuncionarios.MultiSelect = false;
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.RowHeadersVisible = false;
            this.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionarios.Size = new System.Drawing.Size(710, 423);
            this.dgvFuncionarios.TabIndex = 52;
            this.dgvFuncionarios.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFuncionarios_CellMouseClick);
            // 
            // FormConsFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1080, 517);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Funcionários";
            this.Load += new System.EventHandler(this.FormConsultaFuncionarioV2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbDataAdmissao.ResumeLayout(false);
            this.gbDataAdmissao.PerformLayout();
            this.gbTipoBusca.ResumeLayout(false);
            this.gbTipoBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbInicio;
        private System.Windows.Forms.RadioButton rbContem;
        private System.Windows.Forms.GroupBox gbTipoBusca;
        private System.Windows.Forms.GroupBox gbDataAdmissao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbOpcoes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
    }
}