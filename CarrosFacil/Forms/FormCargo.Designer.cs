
namespace CarrosFacil
{
    partial class FormCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCargo));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tbObservacao = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbDadosRegistro = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbDadosRegistro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12 (Título Principal)
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label12.Location = new System.Drawing.Point(20, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(211, 37);
            this.label12.TabIndex = 49;
            this.label12.Text = "Cadastrar Cargo";
            // 
            // label26 (Instruções)
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label26.Location = new System.Drawing.Point(24, 60);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(234, 15);
            this.label26.TabIndex = 48;
            this.label26.Text = "* Todos os campos com * são obrigatórios.";
            // 
            // gbDadosRegistro
            // 
            this.gbDadosRegistro.Controls.Add(this.label27);
            this.gbDadosRegistro.Controls.Add(this.label28);
            this.gbDadosRegistro.Controls.Add(this.tbCodigo);
            this.gbDadosRegistro.Controls.Add(this.cbStatus);
            this.gbDadosRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gbDadosRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbDadosRegistro.Location = new System.Drawing.Point(25, 95);
            this.gbDadosRegistro.Name = "gbDadosRegistro";
            this.gbDadosRegistro.Size = new System.Drawing.Size(180, 185);
            this.gbDadosRegistro.TabIndex = 115;
            this.gbDadosRegistro.TabStop = false;
            this.gbDadosRegistro.Text = "Registro";
            // 
            // label28 (Código Cargo)
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label28.Location = new System.Drawing.Point(15, 35);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(83, 15);
            this.label28.TabIndex = 37;
            this.label28.Text = "Código Cargo:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.BackColor = System.Drawing.Color.White;
            this.tbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbCodigo.Location = new System.Drawing.Point(15, 55);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(150, 27);
            this.tbCodigo.TabIndex = 31;
            // 
            // label27 (Status)
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label27.Location = new System.Drawing.Point(15, 105);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(42, 15);
            this.label27.TabIndex = 39;
            this.label27.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Enabled = false;
            this.cbStatus.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(15, 125);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(150, 28);
            this.cbStatus.TabIndex = 36;
            // 
            // groupBox1 (Dados do Cargo)
            // 
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbObservacao);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.groupBox1.Location = new System.Drawing.Point(220, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 185);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cargo";
            // 
            // label9 (Nome)
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.Location = new System.Drawing.Point(15, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 15);
            this.label9.TabIndex = 43;
            this.label9.Text = "* Nome do cargo:";
            // 
            // tbNome
            // 
            this.tbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbNome.Location = new System.Drawing.Point(15, 55);
            this.tbNome.MaxLength = 60;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(445, 27);
            this.tbNome.TabIndex = 42;
            // 
            // label8 (Observação)
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(15, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 45;
            this.label8.Text = "Observação:";
            // 
            // tbObservacao
            // 
            this.tbObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbObservacao.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbObservacao.Location = new System.Drawing.Point(15, 125);
            this.tbObservacao.MaxLength = 250;
            this.tbObservacao.Name = "tbObservacao";
            this.tbObservacao.Size = new System.Drawing.Size(445, 27);
            this.tbObservacao.TabIndex = 44;
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
            this.btnCadastrar.Location = new System.Drawing.Point(25, 310);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCadastrar.Size = new System.Drawing.Size(130, 40);
            this.btnCadastrar.TabIndex = 51;
            this.btnCadastrar.Text = "  Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
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
            this.btnAtualizar.Location = new System.Drawing.Point(165, 310);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAtualizar.Size = new System.Drawing.Size(130, 40);
            this.btnAtualizar.TabIndex = 52;
            this.btnAtualizar.Text = "  Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
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
            this.btnDeletar.Location = new System.Drawing.Point(305, 310);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDeletar.Size = new System.Drawing.Size(130, 40);
            this.btnDeletar.TabIndex = 53;
            this.btnDeletar.Text = "  Excluir";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
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
            this.btnSair.Location = new System.Drawing.Point(585, 310);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSair.Size = new System.Drawing.Size(110, 40);
            this.btnSair.TabIndex = 54;
            this.btnSair.Text = "  Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(720, 380);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDadosRegistro);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label26);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCargo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciando - Cargo";
            this.Load += new System.EventHandler(this.FormCargo_Load);
            this.gbDadosRegistro.ResumeLayout(false);
            this.gbDadosRegistro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbDadosRegistro;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnDeletar;
        public System.Windows.Forms.Button btnAtualizar;
        public System.Windows.Forms.Button btnCadastrar;
        public System.Windows.Forms.TextBox tbObservacao;
        public System.Windows.Forms.TextBox tbNome;
        public System.Windows.Forms.TextBox tbCodigo;
        public System.Windows.Forms.ComboBox cbStatus;
    }
}