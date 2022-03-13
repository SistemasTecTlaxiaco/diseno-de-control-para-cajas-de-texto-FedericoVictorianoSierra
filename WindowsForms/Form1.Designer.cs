
namespace WindowsForms
{
    partial class BackGroung
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
            this.class11 = new WindowsForms.Controles.Class1();
            this.SuspendLayout();
            // 
            // class11
            // 
            this.class11.AutoSize = true;
            this.class11.Location = new System.Drawing.Point(670, 21);
            this.class11.MinimumSize = new System.Drawing.Size(100, 50);
            this.class11.Name = "class11";
            this.class11.OffBackColor = System.Drawing.Color.Gray;
            this.class11.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.class11.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.class11.OnToggleColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.class11.Size = new System.Drawing.Size(100, 50);
            this.class11.TabIndex = 0;
            this.class11.UseVisualStyleBackColor = true;
            this.class11.CheckedChanged += new System.EventHandler(this.class11_CheckedChanged);
            // 
            // BackGroung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.class11);
            this.Name = "BackGroung";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.Class1 class11;
    }
}

