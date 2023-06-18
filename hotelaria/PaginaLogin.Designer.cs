namespace hotelaria
{
    partial class PaginaLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLogin = new System.Windows.Forms.Panel();
            this.getBTentrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.getSenha = new System.Windows.Forms.TextBox();
            this.getNome = new System.Windows.Forms.TextBox();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.getBTentrar);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.getSenha);
            this.panelLogin.Controls.Add(this.getNome);
            this.panelLogin.Location = new System.Drawing.Point(62, 84);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(245, 187);
            this.panelLogin.TabIndex = 0;
            // 
            // getBTentrar
            // 
            this.getBTentrar.Location = new System.Drawing.Point(100, 149);
            this.getBTentrar.Name = "getBTentrar";
            this.getBTentrar.Size = new System.Drawing.Size(142, 23);
            this.getBTentrar.TabIndex = 1;
            this.getBTentrar.Text = "Entrar";
            this.getBTentrar.UseVisualStyleBackColor = true;
            this.getBTentrar.Click += new System.EventHandler(this.getBTentrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Associado";
            // 
            // getSenha
            // 
            this.getSenha.Location = new System.Drawing.Point(26, 110);
            this.getSenha.Name = "getSenha";
            this.getSenha.Size = new System.Drawing.Size(100, 20);
            this.getSenha.TabIndex = 2;
            // 
            // getNome
            // 
            this.getNome.Location = new System.Drawing.Point(26, 71);
            this.getNome.Name = "getNome";
            this.getNome.Size = new System.Drawing.Size(100, 20);
            this.getNome.TabIndex = 1;
            // 
            // PaginaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 411);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaginaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.paginaLogin_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button getBTentrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox getSenha;
        public System.Windows.Forms.TextBox getNome;
    }
}

