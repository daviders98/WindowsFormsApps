namespace CalculadoraSumaMultiplica
{
    partial class CalculadoraSumaMultiplica
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valorA = new System.Windows.Forms.TextBox();
            this.valorB = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "B:";
            // 
            // valorA
            // 
            this.valorA.Location = new System.Drawing.Point(82, 82);
            this.valorA.Name = "valorA";
            this.valorA.Size = new System.Drawing.Size(100, 20);
            this.valorA.TabIndex = 2;
            // 
            // valorB
            // 
            this.valorB.Location = new System.Drawing.Point(82, 125);
            this.valorB.Name = "valorB";
            this.valorB.Size = new System.Drawing.Size(100, 20);
            this.valorB.TabIndex = 3;
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(216, 81);
            this.resultado.Multiline = true;
            this.resultado.Name = "resultado";
            this.resultado.ReadOnly = true;
            this.resultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.resultado.Size = new System.Drawing.Size(124, 151);
            this.resultado.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CalculadoraSumaMultiplica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.valorB);
            this.Controls.Add(this.valorA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CalculadoraSumaMultiplica";
            this.Text = "Calculadora Suma-Multiplica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valorA;
        private System.Windows.Forms.TextBox valorB;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Button button1;
    }
}

