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
            this.getSenha = new System.Windows.Forms.TextBox();
            this.getNome = new System.Windows.Forms.TextBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Tomato;
            this.panelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogin.Controls.Add(this.getBTentrar);
            this.panelLogin.Controls.Add(this.getSenha);
            this.panelLogin.Controls.Add(this.getNome);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLogin.Location = new System.Drawing.Point(535, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(316, 394);
            this.panelLogin.TabIndex = 0;
            // 
            // getBTentrar
            // 
            this.getBTentrar.BackColor = System.Drawing.Color.Tomato;
            this.getBTentrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.getBTentrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getBTentrar.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getBTentrar.ForeColor = System.Drawing.Color.White;
            this.getBTentrar.Location = new System.Drawing.Point(162, 338);
            this.getBTentrar.Name = "getBTentrar";
            this.getBTentrar.Size = new System.Drawing.Size(142, 44);
            this.getBTentrar.TabIndex = 1;
            this.getBTentrar.Text = "Acessar";
            this.getBTentrar.UseVisualStyleBackColor = false;
            this.getBTentrar.Click += new System.EventHandler(this.getBTentrar_Click);
            // 
            // getSenha
            // 
            this.getSenha.BackColor = System.Drawing.Color.Tomato;
            this.getSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getSenha.ForeColor = System.Drawing.Color.White;
            this.getSenha.Location = new System.Drawing.Point(26, 184);
            this.getSenha.Name = "getSenha";
            this.getSenha.Size = new System.Drawing.Size(250, 27);
            this.getSenha.TabIndex = 2;
            this.getSenha.Text = "Senha";
            // 
            // getNome
            // 
            this.getNome.BackColor = System.Drawing.Color.Tomato;
            this.getNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getNome.ForeColor = System.Drawing.SystemColors.Window;
            this.getNome.Location = new System.Drawing.Point(26, 131);
            this.getNome.Multiline = true;
            this.getNome.Name = "getNome";
            this.getNome.Size = new System.Drawing.Size(250, 30);
            this.getNome.TabIndex = 1;
            this.getNome.Text = "Usuarios";
            this.getNome.TextChanged += new System.EventHandler(this.getNome_TextChanged);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(21, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 112);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotelaria Vini";
            // 
            // PaginaLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::hotelaria.Properties.Resources.pexels_evie_shaffer_4074444;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(851, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaginaLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.paginaLogin_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button getBTentrar;
        public System.Windows.Forms.TextBox getSenha;
        public System.Windows.Forms.TextBox getNome;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label label1;
    }
}

