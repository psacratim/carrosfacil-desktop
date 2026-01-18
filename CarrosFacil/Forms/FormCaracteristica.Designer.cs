namespace CarrosFacil.Forms
{
    partial class FormCaracteristica
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaracteristica));
            this.tbObservacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.gbDadosRegistro = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbIcone = new System.Windows.Forms.Label();
            this.gbIcone = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.gbDadosRegistro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbIcone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbObservacao
            // 
            this.tbObservacao.Location = new System.Drawing.Point(9, 91);
            this.tbObservacao.Name = "tbObservacao";
            this.tbObservacao.Size = new System.Drawing.Size(343, 25);
            this.tbObservacao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Observação:";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(527, 321);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(86, 35);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
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
            this.btnDeletar.Location = new System.Drawing.Point(261, 321);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnDeletar.Size = new System.Drawing.Size(111, 35);
            this.btnDeletar.TabIndex = 29;
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
            this.btnAtualizar.Location = new System.Drawing.Point(141, 321);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnAtualizar.Size = new System.Drawing.Size(111, 35);
            this.btnAtualizar.TabIndex = 28;
            this.btnAtualizar.Text = "    Atualizar";
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
            this.btnCadastrar.Location = new System.Drawing.Point(21, 321);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.btnCadastrar.Size = new System.Drawing.Size(111, 35);
            this.btnCadastrar.TabIndex = 27;
            this.btnCadastrar.Text = "    Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label12.Location = new System.Drawing.Point(17, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(335, 37);
            this.label12.TabIndex = 30;
            this.label12.Text = "Cadastro de Característica";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(48)))), ((int)(((byte)(49)))));
            this.label26.Location = new System.Drawing.Point(21, 48);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(253, 15);
            this.label26.TabIndex = 31;
            this.label26.Text = "* Todos os campos marcados são obrigatórios.";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(9, 43);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(343, 25);
            this.tbNome.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(9, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "* Nome:";
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.White;
            this.pbIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbIcon.Image")));
            this.pbIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbIcon.InitialImage")));
            this.pbIcon.Location = new System.Drawing.Point(17, 35);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(172, 139);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 1;
            this.pbIcon.TabStop = false;
            this.pbIcon.Click += new System.EventHandler(this.pbIcon_Click);
            // 
            // gbDadosRegistro
            // 
            this.gbDadosRegistro.Controls.Add(this.label27);
            this.gbDadosRegistro.Controls.Add(this.label28);
            this.gbDadosRegistro.Controls.Add(this.tbCodigo);
            this.gbDadosRegistro.Controls.Add(this.cbStatus);
            this.gbDadosRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gbDadosRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbDadosRegistro.Location = new System.Drawing.Point(21, 78);
            this.gbDadosRegistro.Name = "gbDadosRegistro";
            this.gbDadosRegistro.Size = new System.Drawing.Size(369, 78);
            this.gbDadosRegistro.TabIndex = 2;
            this.gbDadosRegistro.TabStop = false;
            this.gbDadosRegistro.Text = "Identificação";
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label27.Location = new System.Drawing.Point(129, 21);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(86, 15);
            this.label27.TabIndex = 0;
            this.label27.Text = "Status:";
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label28.Location = new System.Drawing.Point(9, 21);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(86, 15);
            this.label28.TabIndex = 1;
            this.label28.Text = "Código:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.tbCodigo.Enabled = false;
            this.tbCodigo.Location = new System.Drawing.Point(9, 39);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(103, 25);
            this.tbCodigo.TabIndex = 2;
            // 
            // cbStatus
            // 
            this.cbStatus.Location = new System.Drawing.Point(129, 39);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(223, 25);
            this.cbStatus.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbObservacao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.groupBox1.Location = new System.Drawing.Point(21, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 139);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da Característica";
            // 
            // lbIcone
            // 
            this.lbIcone.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lbIcone.Location = new System.Drawing.Point(17, 182);
            this.lbIcone.Name = "lbIcone";
            this.lbIcone.Size = new System.Drawing.Size(171, 30);
            this.lbIcone.TabIndex = 0;
            this.lbIcone.Text = "Clique na área acima para alterar o ícone";
            this.lbIcone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbIcone
            // 
            this.gbIcone.Controls.Add(this.lbIcone);
            this.gbIcone.Controls.Add(this.pbIcon);
            this.gbIcone.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.gbIcone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.gbIcone.Location = new System.Drawing.Point(407, 78);
            this.gbIcone.Name = "gbIcone";
            this.gbIcone.Size = new System.Drawing.Size(206, 225);
            this.gbIcone.TabIndex = 0;
            this.gbIcone.TabStop = false;
            this.gbIcone.Text = "Ícone";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormCaracteristica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(639, 377);
            this.Controls.Add(this.gbIcone);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDadosRegistro);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label26);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormCaracteristica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestão - Característica";
            this.Load += new System.EventHandler(this.FormCaracteristica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.gbDadosRegistro.ResumeLayout(false);
            this.gbDadosRegistro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbIcone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbDadosRegistro;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbIcone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox tbObservacao;
        public System.Windows.Forms.TextBox tbNome;
        public System.Windows.Forms.PictureBox pbIcon;
        public System.Windows.Forms.TextBox tbCodigo;
        public System.Windows.Forms.ComboBox cbStatus;
        public System.Windows.Forms.Label lbIcone;
    }
}