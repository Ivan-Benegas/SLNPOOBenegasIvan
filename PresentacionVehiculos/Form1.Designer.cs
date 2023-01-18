namespace PresentacionVehiculos
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
            this.lblAutoElectrico = new System.Windows.Forms.Label();
            this.lblCamion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAutoElectrico
            // 
            this.lblAutoElectrico.AutoSize = true;
            this.lblAutoElectrico.Location = new System.Drawing.Point(353, 102);
            this.lblAutoElectrico.Name = "lblAutoElectrico";
            this.lblAutoElectrico.Size = new System.Drawing.Size(73, 13);
            this.lblAutoElectrico.TabIndex = 0;
            this.lblAutoElectrico.Text = "Auto Eléctrico";
            // 
            // lblCamion
            // 
            this.lblCamion.AutoSize = true;
            this.lblCamion.Location = new System.Drawing.Point(353, 254);
            this.lblCamion.Name = "lblCamion";
            this.lblCamion.Size = new System.Drawing.Size(42, 13);
            this.lblCamion.TabIndex = 1;
            this.lblCamion.Text = "Camión";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCamion);
            this.Controls.Add(this.lblAutoElectrico);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAutoElectrico;
        private System.Windows.Forms.Label lblCamion;
    }
}

