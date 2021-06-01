namespace WindowsFormsApp3
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
            this.Label = new System.Windows.Forms.Label();
            this.limin = new System.Windows.Forms.TextBox();
            this.limsup = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Es = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(18, 63);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(68, 13);
            this.Label.TabIndex = 1;
            this.Label.Text = "Limite inferior";
            // 
            // limin
            // 
            this.limin.Location = new System.Drawing.Point(151, 63);
            this.limin.Name = "limin";
            this.limin.Size = new System.Drawing.Size(100, 20);
            this.limin.TabIndex = 2;
            // 
            // limsup
            // 
            this.limsup.Location = new System.Drawing.Point(151, 97);
            this.limsup.Name = "limsup";
            this.limsup.Size = new System.Drawing.Size(100, 20);
            this.limsup.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(18, 100);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(74, 13);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Limite superior";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Criterio de parada (Es)";
            // 
            // Es
            // 
            this.Es.Location = new System.Drawing.Point(151, 139);
            this.Es.Name = "Es";
            this.Es.Size = new System.Drawing.Size(100, 20);
            this.Es.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 226);
            this.Controls.Add(this.Es);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.limsup);
            this.Controls.Add(this.limin);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Método de bisección para calcular raíces";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox limin;
        private System.Windows.Forms.TextBox limsup;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Es;
    }
}

