
namespace Ejercicio4
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
            this.unir_combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edadtxt = new System.Windows.Forms.TextBox();
            this.agregarbtn = new System.Windows.Forms.Button();
            this.A_Z_combobox = new System.Windows.Forms.ComboBox();
            this.Z_A_combobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // unir_combobox
            // 
            this.unir_combobox.FormattingEnabled = true;
            this.unir_combobox.Location = new System.Drawing.Point(390, 156);
            this.unir_combobox.Name = "unir_combobox";
            this.unir_combobox.Size = new System.Drawing.Size(255, 21);
            this.unir_combobox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre estudiante:  ";
            // 
            // nombretxt
            // 
            this.nombretxt.Location = new System.Drawing.Point(174, 62);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(168, 20);
            this.nombretxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edad estudiante:  ";
            // 
            // edadtxt
            // 
            this.edadtxt.Location = new System.Drawing.Point(174, 120);
            this.edadtxt.Name = "edadtxt";
            this.edadtxt.Size = new System.Drawing.Size(40, 20);
            this.edadtxt.TabIndex = 4;
            // 
            // agregarbtn
            // 
            this.agregarbtn.Location = new System.Drawing.Point(77, 184);
            this.agregarbtn.Name = "agregarbtn";
            this.agregarbtn.Size = new System.Drawing.Size(112, 31);
            this.agregarbtn.TabIndex = 6;
            this.agregarbtn.Text = "Agregar";
            this.agregarbtn.UseVisualStyleBackColor = true;
            this.agregarbtn.Click += new System.EventHandler(this.agregarbtn_Click);
            // 
            // A_Z_combobox
            // 
            this.A_Z_combobox.FormattingEnabled = true;
            this.A_Z_combobox.Location = new System.Drawing.Point(390, 223);
            this.A_Z_combobox.Name = "A_Z_combobox";
            this.A_Z_combobox.Size = new System.Drawing.Size(255, 21);
            this.A_Z_combobox.Sorted = true;
            this.A_Z_combobox.TabIndex = 9;
            // 
            // Z_A_combobox
            // 
            this.Z_A_combobox.FormattingEnabled = true;
            this.Z_A_combobox.Location = new System.Drawing.Point(390, 296);
            this.Z_A_combobox.Name = "Z_A_combobox";
            this.Z_A_combobox.Size = new System.Drawing.Size(255, 21);
            this.Z_A_combobox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Z_A_combobox);
            this.Controls.Add(this.A_Z_combobox);
            this.Controls.Add(this.agregarbtn);
            this.Controls.Add(this.edadtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unir_combobox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox unir_combobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edadtxt;
        private System.Windows.Forms.Button agregarbtn;
        private System.Windows.Forms.ComboBox A_Z_combobox;
        private System.Windows.Forms.ComboBox Z_A_combobox;
    }
}

