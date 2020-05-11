namespace FunctionNAND
{
    partial class Form1
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
            this.txtW1 = new System.Windows.Forms.TextBox();
            this.txtW2 = new System.Windows.Forms.TextBox();
            this.txtLimiar = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblw1 = new System.Windows.Forms.Label();
            this.lblw2 = new System.Windows.Forms.Label();
            this.lblLimiar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtW1
            // 
            this.txtW1.Location = new System.Drawing.Point(48, 40);
            this.txtW1.Name = "txtW1";
            this.txtW1.Size = new System.Drawing.Size(100, 20);
            this.txtW1.TabIndex = 0;
            // 
            // txtW2
            // 
            this.txtW2.Location = new System.Drawing.Point(48, 64);
            this.txtW2.Name = "txtW2";
            this.txtW2.Size = new System.Drawing.Size(100, 20);
            this.txtW2.TabIndex = 1;
            // 
            // txtLimiar
            // 
            this.txtLimiar.Location = new System.Drawing.Point(48, 112);
            this.txtLimiar.Name = "txtLimiar";
            this.txtLimiar.Size = new System.Drawing.Size(100, 20);
            this.txtLimiar.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(160, 112);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblw1
            // 
            this.lblw1.AutoSize = true;
            this.lblw1.Location = new System.Drawing.Point(8, 40);
            this.lblw1.Name = "lblw1";
            this.lblw1.Size = new System.Drawing.Size(21, 13);
            this.lblw1.TabIndex = 4;
            this.lblw1.Text = "w1";
            // 
            // lblw2
            // 
            this.lblw2.AutoSize = true;
            this.lblw2.Location = new System.Drawing.Point(8, 64);
            this.lblw2.Name = "lblw2";
            this.lblw2.Size = new System.Drawing.Size(21, 13);
            this.lblw2.TabIndex = 5;
            this.lblw2.Text = "w2";
            // 
            // lblLimiar
            // 
            this.lblLimiar.AutoSize = true;
            this.lblLimiar.Location = new System.Drawing.Point(8, 112);
            this.lblLimiar.Name = "lblLimiar";
            this.lblLimiar.Size = new System.Drawing.Size(34, 13);
            this.lblLimiar.TabIndex = 6;
            this.lblLimiar.Text = "Limiar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 261);
            this.Controls.Add(this.lblLimiar);
            this.Controls.Add(this.lblw2);
            this.Controls.Add(this.lblw1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtLimiar);
            this.Controls.Add(this.txtW2);
            this.Controls.Add(this.txtW1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtW1;
        private System.Windows.Forms.TextBox txtW2;
        private System.Windows.Forms.TextBox txtLimiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblw1;
        private System.Windows.Forms.Label lblw2;
        private System.Windows.Forms.Label lblLimiar;
    }
}

