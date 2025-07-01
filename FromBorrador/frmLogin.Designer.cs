namespace FromBorrador
{
    partial class frmLogin
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
            this.txtNombreCorreo = new System.Windows.Forms.TextBox();
            this.txtLeeContra = new System.Windows.Forms.TextBox();
            this.btnInicioSesion = new System.Windows.Forms.Button();
            this.btnOlvidarContra = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombreCorreo
            // 
            this.txtNombreCorreo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtNombreCorreo.Location = new System.Drawing.Point(61, 49);
            this.txtNombreCorreo.Name = "txtNombreCorreo";
            this.txtNombreCorreo.Size = new System.Drawing.Size(201, 20);
            this.txtNombreCorreo.TabIndex = 1;
            this.txtNombreCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLeeContra
            // 
            this.txtLeeContra.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtLeeContra.Location = new System.Drawing.Point(61, 96);
            this.txtLeeContra.Name = "txtLeeContra";
            this.txtLeeContra.PasswordChar = '*';
            this.txtLeeContra.Size = new System.Drawing.Size(201, 20);
            this.txtLeeContra.TabIndex = 3;
            this.txtLeeContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInicioSesion.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicioSesion.Location = new System.Drawing.Point(73, 165);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(166, 23);
            this.btnInicioSesion.TabIndex = 4;
            this.btnInicioSesion.Text = "Inicia sesión";
            this.btnInicioSesion.UseVisualStyleBackColor = false;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // btnOlvidarContra
            // 
            this.btnOlvidarContra.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOlvidarContra.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOlvidarContra.Location = new System.Drawing.Point(73, 246);
            this.btnOlvidarContra.Name = "btnOlvidarContra";
            this.btnOlvidarContra.Size = new System.Drawing.Size(166, 23);
            this.btnOlvidarContra.TabIndex = 6;
            this.btnOlvidarContra.Text = "Olvide mi comtraseña";
            this.btnOlvidarContra.UseVisualStyleBackColor = false;
            this.btnOlvidarContra.Click += new System.EventHandler(this.btnOlvidarContra_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(69, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(176, 14);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre de usuario o correo electrónico";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.Location = new System.Drawing.Point(125, 80);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(55, 14);
            this.lblContra.TabIndex = 2;
            this.lblContra.Text = "Contraseña";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Modern No. 20", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(115, 209);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(83, 17);
            this.lblRegistro.TabIndex = 5;
            this.lblRegistro.Text = "ó registrar";
            this.lblRegistro.Click += new System.EventHandler(this.lblRegistro_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(320, 302);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnOlvidarContra);
            this.Controls.Add(this.btnInicioSesion);
            this.Controls.Add(this.txtLeeContra);
            this.Controls.Add(this.txtNombreCorreo);
            this.Name = "frmLogin";
            this.Text = "Inicio de Sesión";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreCorreo;
        private System.Windows.Forms.TextBox txtLeeContra;
        private System.Windows.Forms.Button btnInicioSesion;
        private System.Windows.Forms.Button btnOlvidarContra;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Label lblRegistro;
    }
}

