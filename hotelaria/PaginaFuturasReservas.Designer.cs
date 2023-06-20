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
            this.label2.Location = new System.Drawing.Point(1328, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "RESERVAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(79, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "RESERVAS PARA O DIA :";
            // 
            // getId
            // 
            this.getId.BackColor = System.Drawing.Color.Snow;
            this.getId.Location = new System.Drawing.Point(80, 652);
            this.getId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getId.Name = "getId";
            this.getId.Size = new System.Drawing.Size(669, 22);
            this.getId.TabIndex = 11;
            // 
            // bLimpar
            // 
            this.bLimpar.ForeColor = System.Drawing.Color.Tomato;
            this.bLimpar.Location = new System.Drawing.Point(264, 684);
            this.bLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bLimpar.Name = "bLimpar";
            this.bLimpar.Size = new System.Drawing.Size(212, 28);
            this.bLimpar.TabIndex = 10;
            this.bLimpar.Text = "Limpar Seleção";
            this.bLimpar.UseVisualStyleBackColor = true;
            this.bLimpar.Click += new System.EventHandler(this.bLimpar_Click);
            // 
            // bAtualizar
            // 
            this.bAtualizar.ForeColor = System.Drawing.Color.Tomato;
            this.bAtualizar.Location = new System.Drawing.Point(484, 684);
            this.bAtualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAtualizar.Name = "bAtualizar";
            this.bAtualizar.Size = new System.Drawing.Size(267, 28);
            this.bAtualizar.TabIndex = 9;
            this.bAtualizar.Text = "Atualizar";
            this.bAtualizar.UseVisualStyleBackColor = true;
            this.bAtualizar.Click += new System.EventHandler(this.bAtualizar_Click);
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(65, 94);
            this.listView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1333, 469);
            this.listView.TabIndex = 8;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // getdia
            // 
            this.getdia.BackColor = System.Drawing.Color.Tomato;
            this.getdia.ForeColor = System.Drawing.Color.Snow;
            this.getdia.Location = new System.Drawing.Point(343, 65);
            this.getdia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getdia.Name = "getdia";
            this.getdia.Size = new System.Drawing.Size(63, 22);
            this.getdia.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(80, 615);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "SELECIONE PELO ID DO RESERVA";
            // 
            // getmes
            // 
            this.getmes.BackColor = System.Drawing.Color.Tomato;
            this.getmes.ForeColor = System.Drawing.Color.Snow;
            this.getmes.Location = new System.Drawing.Point(415, 65);
            this.getmes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getmes.Name = "getmes";
            this.getmes.Size = new System.Drawing.Size(63, 22);
            this.getmes.TabIndex = 17;
            // 
            // getano
            // 
            this.getano.BackColor = System.Drawing.Color.Tomato;
            this.getano.ForeColor = System.Drawing.Color.Snow;
            this.getano.Location = new System.Drawing.Point(487, 65);
            this.getano.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getano.Name = "getano";
            this.getano.Size = new System.Drawing.Size(88, 22);
            this.getano.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(347, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Dia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(415, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mês";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(483, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Ano";
            // 
            // PaginaFuturasReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 743);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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