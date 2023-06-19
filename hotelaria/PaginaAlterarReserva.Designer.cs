namespace hotelaria
{
    partial class PaginaAlterarReserva
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
            this.label1 = new System.Windows.Forms.Label();
            this.getCpf = new System.Windows.Forms.TextBox();
            this.getEntrada = new System.Windows.Forms.TextBox();
            this.getSaida = new System.Windows.Forms.TextBox();
            this.getNq = new System.Windows.Forms.TextBox();
            this.GetValor = new System.Windows.Forms.TextBox();
            this.getAtivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.setNReserva = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.getConfirmar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(63, 116);
            this.listView.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1025, 266);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(59, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecione Reserva";
            // 
            // getCpf
            // 
            this.getCpf.Location = new System.Drawing.Point(54, 474);
            this.getCpf.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.getCpf.Name = "getCpf";
            this.getCpf.Size = new System.Drawing.Size(164, 27);
            this.getCpf.TabIndex = 2;
            // 
            // getEntrada
            // 
            this.getEntrada.Location = new System.Drawing.Point(228, 474);
            this.getEntrada.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.getEntrada.Name = "getEntrada";
            this.getEntrada.Size = new System.Drawing.Size(164, 27);
            this.getEntrada.TabIndex = 3;
            // 
            // getSaida
            // 
            this.getSaida.Location = new System.Drawing.Point(402, 474);
            this.getSaida.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.getSaida.Name = "getSaida";
            this.getSaida.Size = new System.Drawing.Size(164, 27);
            this.getSaida.TabIndex = 4;
            // 
            // getNq
            // 
            this.getNq.Location = new System.Drawing.Point(750, 474);
            this.getNq.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.getNq.Name = "getNq";
            this.getNq.Size = new System.Drawing.Size(164, 27);
            this.getNq.TabIndex = 5;
            // 
            // GetValor
            // 
            this.GetValor.Location = new System.Drawing.Point(576, 474);
            this.GetValor.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GetValor.Name = "GetValor";
            this.GetValor.Size = new System.Drawing.Size(164, 27);
            this.GetValor.TabIndex = 6;
            // 
            // getAtivo
            // 
            this.getAtivo.Location = new System.Drawing.Point(924, 474);
            this.getAtivo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.getAtivo.Name = "getAtivo";
            this.getAtivo.Size = new System.Drawing.Size(164, 27);
            this.getAtivo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(50, 449);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(224, 449);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(398, 449);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Saida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(572, 449);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "v/Diaria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(750, 449);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "n°/Quarto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(920, 449);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ativo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Tomato;
            this.label8.Location = new System.Drawing.Point(50, 405);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Reserva n°";
            // 
            // setNReserva
            // 
            this.setNReserva.AutoSize = true;
            this.setNReserva.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setNReserva.ForeColor = System.Drawing.Color.Tomato;
            this.setNReserva.Location = new System.Drawing.Point(139, 405);
            this.setNReserva.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.setNReserva.Name = "setNReserva";
            this.setNReserva.Size = new System.Drawing.Size(54, 20);
            this.setNReserva.TabIndex = 15;
            this.setNReserva.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Tomato;
            this.label10.Location = new System.Drawing.Point(57, 43);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(355, 33);
            this.label10.TabIndex = 16;
            this.label10.Text = "Painel de alterar Reservas";
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.ForeColor = System.Drawing.Color.Tomato;
            this.buttonAlterar.Location = new System.Drawing.Point(924, 545);
            this.buttonAlterar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(197, 36);
            this.buttonAlterar.TabIndex = 17;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = true;
            // 
            // getConfirmar
            // 
            this.getConfirmar.AutoSize = true;
            this.getConfirmar.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getConfirmar.ForeColor = System.Drawing.Color.Tomato;
            this.getConfirmar.Location = new System.Drawing.Point(924, 521);
            this.getConfirmar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.getConfirmar.Name = "getConfirmar";
            this.getConfirmar.Size = new System.Drawing.Size(105, 24);
            this.getConfirmar.TabIndex = 18;
            this.getConfirmar.Text = "Confirmar";
            this.getConfirmar.UseVisualStyleBackColor = true;
            this.getConfirmar.CheckedChanged += new System.EventHandler(this.getConfirmar_CheckedChanged);
            // 
            // PaginaAlterarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 604);
            this.Controls.Add(this.getConfirmar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.setNReserva);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.getAtivo);
            this.Controls.Add(this.GetValor);
            this.Controls.Add(this.getNq);
            this.Controls.Add(this.getSaida);
            this.Controls.Add(this.getEntrada);
            this.Controls.Add(this.getCpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Tomato;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "PaginaAlterarReserva";
            this.Text = "PaginaAlterarReserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox getCpf;
        private System.Windows.Forms.TextBox getEntrada;
        private System.Windows.Forms.TextBox getSaida;
        private System.Windows.Forms.TextBox getNq;
        private System.Windows.Forms.TextBox GetValor;
        private System.Windows.Forms.TextBox getAtivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label setNReserva;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.CheckBox getConfirmar;
    }
}