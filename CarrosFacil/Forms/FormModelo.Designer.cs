
namespace CarrosFacil
{
    partial class FormModelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModelo));
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbObservacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.gbDadosRegistro = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbDadosRegistro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(340, 55);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(180, 28);
            this.cbMarca.TabIndex = 55;
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
            this.btnSair.Location = new System.Drawing.Point(645, 330);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSair.Size = new System.Drawing.Size(110, 40);
            this.btnSair.TabIndex = 54;
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
            this.btnDeletar.Location = new System.Drawing.Point(305, 330);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnDeletar.Size = new System.Drawing.Size(130, 40);
            this.btnDeletar.TabIndex = 53;
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
            this.btnAtualizar.Location = new System.Drawing.Point(165, 330);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnAtualizar.Size = new System.Drawing.Size(130, 40);
            this.btnAtualizar.TabIndex = 52;
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
            this.btnCadastrar.Location = new System.Drawing.Point(25, 330);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCadastrar.Size = new System.Drawing.Size(130, 40);
            this.btnCadastrar.TabIndex = 51;
            this.btnCadastrar.Text = "  Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label12.Location = new System.Drawing.Point(20, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(235, 37);
            this.label12.TabIndex = 49;
            this.label12.Text = "Cadastrar Modelo";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.label26.Location = new System.Drawing.Point(24, 60);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(233, 15);
            this.label26.TabIndex = 48;
            this.label26.Text = "* Todos os campos com * são obrigatórios.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(340, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "* Marca:";
            // 
            // tbNome
            // 
            this.tbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbNome.Location = new System.Drawing.Point(15, 55);
            this.tbNome.MaxLength = 80;
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(310, 27);
            this.tbNome.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(15, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 45;
            this.label3.Text = "* Nome:";
            // 
            // tbObservacao
            // 
            this.tbObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbObservacao.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbObservacao.Location = new System.Drawing.Point(15, 125);
            this.tbObservacao.MaxLength = 250;
            this.tbObservacao.Name = "tbObservacao";
            this.tbObservacao.Size = new System.Drawing.Size(505, 27);
            this.tbObservacao.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(15, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 57;
            this.label2.Text = "Observação:";
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
            this.cbStatus.TabIndex = 59;
            // 
            // gbDadosRegistro
            // 
            this.gbDadosRegistro.Controls.Add(this.label27);
            this.gbDadosRegistro.Controls.Add(this.cbStatus);
            this.gbDadosRegistro.Controls.Add(this.label28);
            this.gbDadosRegistro.Controls.Add(this.tbCodigo);
            this.gbDadosRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.gbDadosRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbDadosRegistro.Location = new System.Drawing.Point(25, 95);
            this.gbDadosRegistro.Name = "gbDadosRegistro";
            this.gbDadosRegistro.Size = new System.Drawing.Size(180, 185);
            this.gbDadosRegistro.TabIndex = 114;
            this.gbDadosRegistro.TabStop = false;
            this.gbDadosRegistro.Text = "Registro";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label27.Location = new System.Drawing.Point(15, 105);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(42, 15);
            this.label27.TabIndex = 39;
            this.label27.Text = "Status:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label28.Location = new System.Drawing.Point(15, 35);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(93, 15);
            this.label28.TabIndex = 37;
            this.label28.Text = "Código Modelo:";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbMarca);
            this.groupBox1.Controls.Add(this.tbObservacao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.groupBox1.Location = new System.Drawing.Point(220, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 185);
            this.groupBox1.TabIndex = 115;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Modelo";
            // 
            // FormModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(780, 400);
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
            this.Name = "FormModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciando - Modelo";
            this.Load += new System.EventHandler(this.FormModelo_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnDeletar;
        public System.Windows.Forms.Button btnAtualizar;
        public System.Windows.Forms.Button btnCadastrar;
        public System.Windows.Forms.GroupBox gbDadosRegistro;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cbMarca;
        public System.Windows.Forms.TextBox tbNome;
        public System.Windows.Forms.TextBox tbObservacao;
        public System.Windows.Forms.ComboBox cbStatus;
        public System.Windows.Forms.TextBox tbCodigo;
    }
}