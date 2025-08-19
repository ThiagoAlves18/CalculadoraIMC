namespace CalculadoraIMC
{
    partial class frmIMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIMC));
            this.lblPeso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblIMC = new System.Windows.Forms.Label();
            this.txbIMC = new System.Windows.Forms.TextBox();
            this.txbAltura = new System.Windows.Forms.TextBox();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.lblSaude = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.Transparent;
            this.lblPeso.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPeso.Location = new System.Drawing.Point(75, 207);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(81, 37);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura =";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Firebrick;
            this.btnCalcular.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(82, 302);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(347, 39);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblIMC
            // 
            this.lblIMC.AutoSize = true;
            this.lblIMC.BackColor = System.Drawing.Color.Transparent;
            this.lblIMC.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIMC.Location = new System.Drawing.Point(77, 358);
            this.lblIMC.Name = "lblIMC";
            this.lblIMC.Size = new System.Drawing.Size(77, 25);
            this.lblIMC.TabIndex = 3;
            this.lblIMC.Text = "IMC =";
            // 
            // txbIMC
            // 
            this.txbIMC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbIMC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbIMC.Enabled = false;
            this.txbIMC.Location = new System.Drawing.Point(157, 356);
            this.txbIMC.Name = "txbIMC";
            this.txbIMC.Size = new System.Drawing.Size(100, 33);
            this.txbIMC.TabIndex = 4;
            // 
            // txbAltura
            // 
            this.txbAltura.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txbAltura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAltura.Location = new System.Drawing.Point(192, 258);
            this.txbAltura.Name = "txbAltura";
            this.txbAltura.Size = new System.Drawing.Size(100, 33);
            this.txbAltura.TabIndex = 5;
            // 
            // txbPeso
            // 
            this.txbPeso.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPeso.Location = new System.Drawing.Point(146, 207);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(100, 33);
            this.txbPeso.TabIndex = 6;
            // 
            // lblSaude
            // 
            this.lblSaude.AutoSize = true;
            this.lblSaude.BackColor = System.Drawing.Color.Transparent;
            this.lblSaude.Location = new System.Drawing.Point(90, 404);
            this.lblSaude.Name = "lblSaude";
            this.lblSaude.Size = new System.Drawing.Size(116, 25);
            this.lblSaude.TabIndex = 8;
            this.lblSaude.Text = "Situação";
            // 
            // frmIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::CalculadoraIMC.Properties.Resources.balance;
            this.ClientSize = new System.Drawing.Size(513, 464);
            this.Controls.Add(this.lblSaude);
            this.Controls.Add(this.txbPeso);
            this.Controls.Add(this.txbAltura);
            this.Controls.Add(this.txbIMC);
            this.Controls.Add(this.lblIMC);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPeso);
            this.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frmIMC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblIMC;
        private System.Windows.Forms.TextBox txbIMC;
        private System.Windows.Forms.TextBox txbAltura;
        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.Label lblSaude;
    }
}

