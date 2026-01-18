
namespace CarrosFacil.Forms.Consultas
{
    partial class FormConsVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsVeiculo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.rbMenor = new System.Windows.Forms.RadioButton();
            this.rbMaior = new System.Windows.Forms.RadioButton();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.cbOpcoes = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbEstadoVeiculo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gbTipoBusca = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbDesconto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.tbEstoque = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvVeiculos = new System.Windows.Forms.DataGridView();
            this.gbTipoBusca.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 37);
            this.label1.TabIndex = 57;
            this.label1.Text = "Consulta de Veículos";
            // 
            // rbMenor
            // 
            this.rbMenor.AutoSize = true;
            this.rbMenor.Checked = true;
            this.rbMenor.Location = new System.Drawing.Point(75, 22);
            this.rbMenor.Name = "rbMenor";
            this.rbMenor.Size = new System.Drawing.Size(58, 17);
            this.rbMenor.TabIndex = 8;
            this.rbMenor.TabStop = true;
            this.rbMenor.Text = "Menor";
            this.rbMenor.UseVisualStyleBackColor = true;
            // 
            // rbMaior
            // 
            this.rbMaior.AutoSize = true;
            this.rbMaior.Location = new System.Drawing.Point(10, 22);
            this.rbMaior.Name = "rbMaior";
            this.rbMaior.Size = new System.Drawing.Size(55, 17);
            this.rbMaior.TabIndex = 7;
            this.rbMaior.Text = "Maior";
            this.rbMaior.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbStatus.Location = new System.Drawing.Point(165, 193);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(145, 25);
            this.cbStatus.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(165, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Status:";
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
            this.btnPesquisar.Location = new System.Drawing.Point(10, 245);
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
            this.btnSair.Location = new System.Drawing.Point(205, 245);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSair.Size = new System.Drawing.Size(105, 40);
            this.btnSair.TabIndex = 31;
            this.btnSair.Text = "      Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // cbOpcoes
            // 
            this.cbOpcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcoes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbOpcoes.Location = new System.Drawing.Point(10, 28);
            this.cbOpcoes.Name = "cbOpcoes";
            this.cbOpcoes.Size = new System.Drawing.Size(145, 25);
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
            // cbEstadoVeiculo
            // 
            this.cbEstadoVeiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoVeiculo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbEstadoVeiculo.Location = new System.Drawing.Point(10, 193);
            this.cbEstadoVeiculo.Name = "cbEstadoVeiculo";
            this.cbEstadoVeiculo.Size = new System.Drawing.Size(145, 25);
            this.cbEstadoVeiculo.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(10, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Estado do veículo:";
            // 
            // gbTipoBusca
            // 
            this.gbTipoBusca.Controls.Add(this.rbMenor);
            this.gbTipoBusca.Controls.Add(this.rbMaior);
            this.gbTipoBusca.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.gbTipoBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbTipoBusca.Location = new System.Drawing.Point(10, 110);
            this.gbTipoBusca.Name = "gbTipoBusca";
            this.gbTipoBusca.Size = new System.Drawing.Size(145, 50);
            this.gbTipoBusca.TabIndex = 13;
            this.gbTipoBusca.TabStop = false;
            this.gbTipoBusca.Text = "Busca Estoque";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.label11.Location = new System.Drawing.Point(350, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 15);
            this.label11.TabIndex = 59;
            this.label11.Text = "Clique no veículo para editar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbDesconto);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.cbOpcoes);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbEstadoVeiculo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.gbTipoBusca);
            this.panel1.Controls.Add(this.cbModelo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbCategoria);
            this.panel1.Controls.Add(this.tbEstoque);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 303);
            this.panel1.TabIndex = 58;
            // 
            // cbDesconto
            // 
            this.cbDesconto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDesconto.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDesconto.Location = new System.Drawing.Point(165, 28);
            this.cbDesconto.Name = "cbDesconto";
            this.cbDesconto.Size = new System.Drawing.Size(145, 25);
            this.cbDesconto.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(165, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "Desconto:";
            // 
            // cbModelo
            // 
            this.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbModelo.Location = new System.Drawing.Point(165, 78);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(145, 25);
            this.cbModelo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(165, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(165, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Estoque:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbCategoria.Location = new System.Drawing.Point(10, 78);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(145, 25);
            this.cbCategoria.TabIndex = 3;
            // 
            // tbEstoque
            // 
            this.tbEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbEstoque.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbEstoque.Location = new System.Drawing.Point(165, 130);
            this.tbEstoque.Name = "tbEstoque";
            this.tbEstoque.Size = new System.Drawing.Size(145, 25);
            this.tbEstoque.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria:";
            // 
            // dgvVeiculos
            // 
            this.dgvVeiculos.AllowUserToAddRows = false;
            this.dgvVeiculos.AllowUserToDeleteRows = false;
            this.dgvVeiculos.AllowUserToResizeRows = false;
            this.dgvVeiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVeiculos.BackgroundColor = System.Drawing.Color.White;
            this.dgvVeiculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVeiculos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVeiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVeiculos.ColumnHeadersHeight = 35;
            this.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(190)))), ((int)(((byte)(195)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVeiculos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVeiculos.EnableHeadersVisualStyles = false;
            this.dgvVeiculos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.dgvVeiculos.Location = new System.Drawing.Point(331, 77);
            this.dgvVeiculos.MultiSelect = false;
            this.dgvVeiculos.Name = "dgvVeiculos";
            this.dgvVeiculos.ReadOnly = true;
            this.dgvVeiculos.RowHeadersVisible = false;
            this.dgvVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVeiculos.Size = new System.Drawing.Size(680, 303);
            this.dgvVeiculos.TabIndex = 60;
            this.dgvVeiculos.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVeiculos_CellMouseClick);
            // 
            // FormConsVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1050, 392);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvVeiculos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Veículos";
            this.Load += new System.EventHandler(this.FormConsVeiculo_Load);
            this.gbTipoBusca.ResumeLayout(false);
            this.gbTipoBusca.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbMenor;
        private System.Windows.Forms.RadioButton rbMaior;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox cbOpcoes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbEstadoVeiculo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbTipoBusca;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbDesconto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox tbEstoque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvVeiculos;
    }
}