namespace hotelaria
{
    partial class PaginaFuturasReservas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.getId = new System.Windows.Forms.TextBox();
            this.bLimpar = new System.Windows.Forms.Button();
            this.bAtualizar = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.getdia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.getmes = new System.Windows.Forms.TextBox();
            this.getano = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(996, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "RESERVAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(59, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "RESERVAS PARA O DIA :";
            // 
            // getId
            // 
            this.getId.BackColor = System.Drawing.Color.Snow;
            this.getId.Location = new System.Drawing.Point(60, 530);
            this.getId.Name = "getId";
            this.getId.Size = new System.Drawing.Size(503, 20);
            this.getId.TabIndex = 11;
            // 
            // bLimpar
            // 
            this.bLimpar.ForeColor = System.Drawing.Color.Tomato;
            this.bLimpar.Location = new System.Drawing.Point(198, 556);
            this.bLimpar.Name = "bLimpar";
            this.bLimpar.Size = new System.Drawing.Size(159, 23);
            this.bLimpar.TabIndex = 10;
            this.bLimpar.Text = "Limpar Seleção";
            this.bLimpar.UseVisualStyleBackColor = true;
            this.bLimpar.Click += new System.EventHandler(this.bLimpar_Click);
            // 
            // bAtualizar
            // 
            this.bAtualizar.ForeColor = System.Drawing.Color.Tomato;
            this.bAtualizar.Location = new System.Drawing.Point(363, 556);
            this.bAtualizar.Name = "bAtualizar";
            this.bAtualizar.Size = new System.Drawing.Size(200, 23);
            this.bAtualizar.TabIndex = 9;
            this.bAtualizar.Text = "Atualizar";
            this.bAtualizar.UseVisualStyleBackColor = true;
            this.bAtualizar.Click += new System.EventHandler(this.bAtualizar_Click);
            // 
            // listView
            // 
            this.listView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(49, 76);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1001, 382);
            this.listView.TabIndex = 8;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // getdia
            // 
            this.getdia.BackColor = System.Drawing.Color.Tomato;
            this.getdia.ForeColor = System.Drawing.Color.Snow;
            this.getdia.Location = new System.Drawing.Point(257, 53);
            this.getdia.Name = "getdia";
            this.getdia.Size = new System.Drawing.Size(48, 20);
            this.getdia.TabIndex = 15;
            this.getdia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.getdia.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(60, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "SELECIONE PELO ID DO RESERVA";
            // 
            // getmes
            // 
            this.getmes.BackColor = System.Drawing.Color.Tomato;
            this.getmes.ForeColor = System.Drawing.Color.Snow;
            this.getmes.Location = new System.Drawing.Point(311, 53);
            this.getmes.Name = "getmes";
            this.getmes.Size = new System.Drawing.Size(48, 20);
            this.getmes.TabIndex = 17;
            this.getmes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.getmes.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            // 
            // getano
            // 
            this.getano.BackColor = System.Drawing.Color.Tomato;
            this.getano.ForeColor = System.Drawing.Color.Snow;
            this.getano.Location = new System.Drawing.Point(365, 53);
            this.getano.Name = "getano";
            this.getano.Size = new System.Drawing.Size(67, 20);
            this.getano.TabIndex = 18;
            this.getano.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.getano.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(260, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Dia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(311, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mês";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(362, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ano";
            // 
            // PaginaFuturasReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 604);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.getano);
            this.Controls.Add(this.getmes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.getdia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getId);
            this.Controls.Add(this.bLimpar);
            this.Controls.Add(this.bAtualizar);
            this.Controls.Add(this.listView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaginaFuturasReservas";
            this.Text = "PaginaFuturasReservas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox getId;
        private System.Windows.Forms.Button bLimpar;
        private System.Windows.Forms.Button bAtualizar;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.TextBox getdia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox getmes;
        private System.Windows.Forms.TextBox getano;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}