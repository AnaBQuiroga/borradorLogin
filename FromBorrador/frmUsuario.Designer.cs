namespace FromBorrador
{
    partial class frmUsuario
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
            this.lblDatosPersonales = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtCorreoUsuario = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtContraUsuario = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDatosPersonales
            // 
            this.lblDatosPersonales.AutoSize = true;
            this.lblDatosPersonales.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosPersonales.Location = new System.Drawing.Point(84, 31);
            this.lblDatosPersonales.Name = "lblDatosPersonales";
            this.lblDatosPersonales.Size = new System.Drawing.Size(182, 18);
            this.lblDatosPersonales.TabIndex = 0;
            this.lblDatosPersonales.Text = "DATOS PERSONALES";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(121, 73);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNombreUsuario.TabIndex = 1;
            // 
            // txtCorreoUsuario
            // 
            this.txtCorreoUsuario.Location = new System.Drawing.Point(121, 124);
            this.txtCorreoUsuario.Name = "txtCorreoUsuario";
            this.txtCorreoUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtCorreoUsuario.TabIndex = 2;
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificar.Location = new System.Drawing.Point(121, 232);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtContraUsuario
            // 
            this.txtContraUsuario.Location = new System.Drawing.Point(121, 172);
            this.txtContraUsuario.Name = "txtContraUsuario";
            this.txtContraUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtContraUsuario.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(121, 262);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(363, 297);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtContraUsuario);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtCorreoUsuario);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblDatosPersonales);
            this.Name = "frmUsuario";
            this.Text = "Pantalla Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUsuario_FormClosing);
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatosPersonales;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtCorreoUsuario;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtContraUsuario;
        private System.Windows.Forms.Button btnGuardar;
    }
}