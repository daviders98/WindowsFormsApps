namespace Metodo_de_la_secante
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.valora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.valorb = new System.Windows.Forms.TextBox();
            this.ES = new System.Windows.Forms.TextBox();
            this.caja = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Limite 1:";
            // 
            // valora
            // 
            this.valora.Location = new System.Drawing.Point(117, 51);
            this.valora.Name = "valora";
            this.valora.Size = new System.Drawing.Size(100, 20);
            this.valora.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Limite 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cifras significativas:";
            // 
            // valorb
            // 
            this.valorb.Location = new System.Drawing.Point(117, 77);
            this.valorb.Name = "valorb";
            this.valorb.Size = new System.Drawing.Size(100, 20);
            this.valorb.TabIndex = 5;
            // 
            // ES
            // 
            this.ES.Location = new System.Drawing.Point(117, 103);
            this.ES.Name = "ES";
            this.ES.Size = new System.Drawing.Size(100, 20);
            this.ES.TabIndex = 6;
            // 
            // caja
            // 
            this.caja.Location = new System.Drawing.Point(31, 167);
            this.caja.Multiline = true;
            this.caja.Name = "caja";
            this.caja.ReadOnly = true;
            this.caja.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.caja.Size = new System.Drawing.Size(229, 82);
            this.caja.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.caja);
            this.Controls.Add(this.ES);
            this.Controls.Add(this.valorb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valorb;
        private System.Windows.Forms.TextBox ES;
        private System.Windows.Forms.TextBox caja;
    }
}

