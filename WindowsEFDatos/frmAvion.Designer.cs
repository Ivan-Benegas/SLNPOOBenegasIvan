namespace WindowsEFDatos
{
    partial class frmAvion
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
            this.txtDenominacion = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnBuscarPorId = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lblDenominacion = new System.Windows.Forms.Label();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblIdAvion = new System.Windows.Forms.Label();
            this.gridAvion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridAvion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDenominacion
            // 
            this.txtDenominacion.Location = new System.Drawing.Point(199, 129);
            this.txtDenominacion.Name = "txtDenominacion";
            this.txtDenominacion.Size = new System.Drawing.Size(154, 20);
            this.txtDenominacion.TabIndex = 21;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.Location = new System.Drawing.Point(199, 81);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(154, 20);
            this.txtCapacidad.TabIndex = 20;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(199, 34);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(154, 20);
            this.txtId.TabIndex = 19;
            // 
            // btnBuscarPorId
            // 
            this.btnBuscarPorId.Location = new System.Drawing.Point(504, 177);
            this.btnBuscarPorId.Name = "btnBuscarPorId";
            this.btnBuscarPorId.Size = new System.Drawing.Size(171, 23);
            this.btnBuscarPorId.TabIndex = 18;
            this.btnBuscarPorId.Text = "Buscar por id";
            this.btnBuscarPorId.UseVisualStyleBackColor = true;
            this.btnBuscarPorId.Click += new System.EventHandler(this.btnBuscarPorId_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(504, 129);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(171, 23);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(504, 81);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(171, 23);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(504, 34);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(171, 23);
            this.btnInsertar.TabIndex = 15;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lblDenominacion
            // 
            this.lblDenominacion.AutoSize = true;
            this.lblDenominacion.Location = new System.Drawing.Point(99, 131);
            this.lblDenominacion.Name = "lblDenominacion";
            this.lblDenominacion.Size = new System.Drawing.Size(75, 13);
            this.lblDenominacion.TabIndex = 14;
            this.lblDenominacion.Text = "Denominación";
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(99, 83);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(58, 13);
            this.lblCapacidad.TabIndex = 13;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // lblIdAvion
            // 
            this.lblIdAvion.AutoSize = true;
            this.lblIdAvion.Location = new System.Drawing.Point(99, 36);
            this.lblIdAvion.Name = "lblIdAvion";
            this.lblIdAvion.Size = new System.Drawing.Size(16, 13);
            this.lblIdAvion.TabIndex = 12;
            this.lblIdAvion.Text = "Id";
            // 
            // gridAvion
            // 
            this.gridAvion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAvion.Location = new System.Drawing.Point(29, 239);
            this.gridAvion.Name = "gridAvion";
            this.gridAvion.Size = new System.Drawing.Size(743, 183);
            this.gridAvion.TabIndex = 11;
            // 
            // frmAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDenominacion);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnBuscarPorId);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lblDenominacion);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.lblIdAvion);
            this.Controls.Add(this.gridAvion);
            this.Name = "frmAvion";
            this.Text = "frmAvion";
            this.Load += new System.EventHandler(this.frmAvion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAvion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDenominacion;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnBuscarPorId;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lblDenominacion;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblIdAvion;
        private System.Windows.Forms.DataGridView gridAvion;
    }
}