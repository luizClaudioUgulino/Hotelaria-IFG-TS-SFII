namespace hotelaria
{
    partial class PaginaCadastrarQuarto
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
            this.getNumeroQ = new System.Windows.Forms.TextBox();
            this.getValorDiaria = new System.Windows.Forms.TextBox();
            this.getNumeroMaxP = new System.Windows.Forms.TextBox();
            this.getDetalhes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getNumeroQ
            // 
            this.getNumeroQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getNumeroQ.Location = new System.Drawing.Point(111, 42);
            this.getNumeroQ.Margin = new System.Windows.Forms.Padding(6);
            this.getNumeroQ.Name = "getNumeroQ";
            this.getNumeroQ.Size = new System.Drawing.Size(266, 57);
            this.getNumeroQ.TabIndex = 0;
            this.getNumeroQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // getValorDiaria
            // 
            this.getValorDiaria.Location = new System.Drawing.Point(44, 188);
            this.getValorDiaria.Margin = new System.Windows.Forms.Padding(6);
            this.getValorDiaria.Name = "getValorDiaria";
            this.getValorDiaria.Size = new System.Drawing.Size(212, 39);
            this.getValorDiaria.TabIndex = 1;
            this.getValorDiaria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // getNumeroMaxP
            // 
            this.getNumeroMaxP.Location = new System.Drawing.Point(44, 299);
            this.getNumeroMaxP.Margin = new System.Windows.Forms.Padding(6);
            this.getNumeroMaxP.Name = "getNumeroMaxP";
            this.getNumeroMaxP.Size = new System.Drawing.Size(212, 39);
            this.getNumeroMaxP.TabIndex = 2;
            this.getNumeroMaxP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.getNumeroMaxP.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // getDetalhes
            // 
            this.getDetalhes.Location = new System.Drawing.Point(44, 401);
            this.getDetalhes.Margin = new System.Windows.Forms.Padding(6);
            this.getDetalhes.Name = "getDetalhes";
            this.getDetalhes.Size = new System.Drawing.Size(606, 39);
            this.getDetalhes.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "n°";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(43, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor da Diaria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(38, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero máximo de pessoas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(43, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Detalhes do quarto";
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(564, 489);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(195, 48);
            this.buttonCadastrar.TabIndex = 8;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(765, 489);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(237, 48);
            this.buttonLimpar.TabIndex = 9;
            this.buttonLimpar.Text = "Limpar seleção";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // PaginaCadastrarQuarto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 598);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getDetalhes);
            this.Controls.Add(this.getNumeroMaxP);
            this.Controls.Add(this.getValorDiaria);
            this.Controls.Add(this.getNumeroQ);
            this.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Tomato;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PaginaCadastrarQuarto";
            this.Text = "PaginaCadastrarQuarto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox getNumeroQ;
        private System.Windows.Forms.TextBox getValorDiaria;
        private System.Windows.Forms.TextBox getNumeroMaxP;
        private System.Windows.Forms.TextBox getDetalhes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonLimpar;
    }
}