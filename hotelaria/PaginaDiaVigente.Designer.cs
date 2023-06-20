namespace hotelaria
{
    partial class PaginaDiaVigente
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
            this.listView = new System.Windows.Forms.ListView();
            this.bAtualizar = new System.Windows.Forms.Button();
            this.bLimpar = new System.Windows.Forms.Button();
            this.getId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.setdia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(85, 73);
            this.listView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1333, 469);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // bAtualizar
            // 
            this.bAtualizar.Location = new System.Drawing.Point(489, 663);
            this.bAtualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAtualizar.Name = "bAtualizar";
            this.bAtualizar.Size = new System.Drawing.Size(267, 28);
            this.bAtualizar.TabIndex = 1;
            this.bAtualizar.Text = "Atualizar";
            this.bAtualizar.UseVisualStyleBackColor = true;
            this.bAtualizar.Click += new System.EventHandler(this.bAtualizar_Click);
            // 
            // bLimpar
            // 
            this.bLimpar.Location = new System.Drawing.Point(269, 663);
            this.bLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bLimpar.Name = "bLimpar";
            this.bLimpar.Size = new System.Drawing.Size(212, 28);
            this.bLimpar.TabIndex = 2;
            this.bLimpar.Text = "Limpar Seleção";
            this.bLimpar.UseVisualStyleBackColor = true;
            this.bLimpar.Click += new System.EventHandler(this.bLimpar_Click);
            // 
            // getId
            // 
            this.getId.BackColor = System.Drawing.Color.Snow;
            this.getId.Location = new System.Drawing.Point(85, 631);
            this.getId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.getId.Name = "getId";
            this.getId.Size = new System.Drawing.Size(669, 22);
            this.getId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(84, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "RESERVAS PARA O DIA :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(1333, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "RESERVAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(85, 595);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "SELECIONE PELO ID DO RESERVA";
            // 
            // setdia
            // 
            this.setdia.AutoSize = true;
            this.setdia.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setdia.ForeColor = System.Drawing.Color.Tomato;
            this.setdia.Location = new System.Drawing.Point(352, 41);
            this.setdia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.setdia.Name = "setdia";
            this.setdia.Size = new System.Drawing.Size(0, 29);
            this.setdia.TabIndex = 7;
            // 
            // PaginaDiaVigente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1531, 743);
            this.Controls.Add(this.setdia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getId);
            this.Controls.Add(this.bLimpar);
            this.Controls.Add(this.bAtualizar);
            this.Controls.Add(this.listView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PaginaDiaVigente";
            this.Text = "PaginaDiaVigente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button bAtualizar;
        private System.Windows.Forms.Button bLimpar;
        private System.Windows.Forms.TextBox getId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label setdia;
    }
}