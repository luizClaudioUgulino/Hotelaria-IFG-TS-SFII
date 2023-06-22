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
            this.listView.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(64, 59);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1001, 382);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // bAtualizar
            // 
            this.bAtualizar.Location = new System.Drawing.Point(367, 539);
            this.bAtualizar.Name = "bAtualizar";
            this.bAtualizar.Size = new System.Drawing.Size(200, 23);
            this.bAtualizar.TabIndex = 1;
            this.bAtualizar.Text = "Atualizar";
            this.bAtualizar.UseVisualStyleBackColor = true;
            this.bAtualizar.Click += new System.EventHandler(this.bAtualizar_Click);
            // 
            // bLimpar
            // 
            this.bLimpar.Location = new System.Drawing.Point(202, 539);
            this.bLimpar.Name = "bLimpar";
            this.bLimpar.Size = new System.Drawing.Size(159, 23);
            this.bLimpar.TabIndex = 2;
            this.bLimpar.Text = "Limpar Seleção";
            this.bLimpar.UseVisualStyleBackColor = true;
            this.bLimpar.Click += new System.EventHandler(this.bLimpar_Click);
            // 
            // getId
            // 
            this.getId.BackColor = System.Drawing.Color.Snow;
            this.getId.Location = new System.Drawing.Point(64, 513);
            this.getId.Name = "getId";
            this.getId.Size = new System.Drawing.Size(503, 20);
            this.getId.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(63, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "RESERVAS PARA O DIA :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(1000, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "RESERVAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(64, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "SELECIONE PELO ID DO RESERVA";
            // 
            // setdia
            // 
            this.setdia.AutoSize = true;
            this.setdia.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setdia.ForeColor = System.Drawing.Color.Tomato;
            this.setdia.Location = new System.Drawing.Point(264, 33);
            this.setdia.Name = "setdia";
            this.setdia.Size = new System.Drawing.Size(0, 23);
            this.setdia.TabIndex = 7;
            // 
            // PaginaDiaVigente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1148, 604);
            this.Controls.Add(this.setdia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getId);
            this.Controls.Add(this.bLimpar);
            this.Controls.Add(this.bAtualizar);
            this.Controls.Add(this.listView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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