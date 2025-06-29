namespace FromBorrador
{
    partial class frmAdmin
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
            this.lblElegir = new System.Windows.Forms.Label();
            this.cmbEleccion = new System.Windows.Forms.ComboBox();
            this.txtConfirmarContra = new System.Windows.Forms.TextBox();
            this.lblConfirmarContra = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtNombreApellido = new System.Windows.Forms.TextBox();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblElegir
            // 
            this.lblElegir.AutoSize = true;
            this.lblElegir.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElegir.Location = new System.Drawing.Point(71, 43);
            this.lblElegir.Name = "lblElegir";
            this.lblElegir.Size = new System.Drawing.Size(58, 18);
            this.lblElegir.TabIndex = 0;
            this.lblElegir.Text = "Usuario";
            // 
            // cmbEleccion
            // 
            this.cmbEleccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbEleccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEleccion.FormattingEnabled = true;
            this.cmbEleccion.Items.AddRange(new object[] {
            "Ana Quiroga",
            "Natalia Jacquet",
            "Ramiro Aguirre"});
            this.cmbEleccion.Location = new System.Drawing.Point(152, 39);
            this.cmbEleccion.Name = "cmbEleccion";
            this.cmbEleccion.Size = new System.Drawing.Size(121, 21);
            this.cmbEleccion.TabIndex = 1;
            this.cmbEleccion.SelectedIndexChanged += new System.EventHandler(this.cmbEleccion_SelectedIndexChanged);
            // 
            // txtConfirmarContra
            // 
            this.txtConfirmarContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtConfirmarContra.Location = new System.Drawing.Point(213, 260);
            this.txtConfirmarContra.Name = "txtConfirmarContra";
            this.txtConfirmarContra.PasswordChar = '*';
            this.txtConfirmarContra.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmarContra.TabIndex = 11;
            // 
            // lblConfirmarContra
            // 
            this.lblConfirmarContra.AutoSize = true;
            this.lblConfirmarContra.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContra.Location = new System.Drawing.Point(53, 260);
            this.lblConfirmarContra.Name = "lblConfirmarContra";
            this.lblConfirmarContra.Size = new System.Drawing.Size(140, 17);
            this.lblConfirmarContra.TabIndex = 10;
            this.lblConfirmarContra.Text = "Confirmar contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtContraseña.Location = new System.Drawing.Point(214, 220);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 9;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.Location = new System.Drawing.Point(53, 220);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(75, 17);
            this.lblContra.TabIndex = 8;
            this.lblContra.Text = "Contraseña";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCorreo.Location = new System.Drawing.Point(213, 179);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(100, 20);
            this.txtCorreo.TabIndex = 7;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(54, 179);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(119, 17);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo electrónico";
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDNI.Location = new System.Drawing.Point(214, 140);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 20);
            this.txtDNI.TabIndex = 5;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(53, 140);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(35, 17);
            this.lblDNI.TabIndex = 4;
            this.lblDNI.Text = "DNI";
            // 
            // txtNombreApellido
            // 
            this.txtNombreApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNombreApellido.Location = new System.Drawing.Point(213, 101);
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.Size = new System.Drawing.Size(100, 20);
            this.txtNombreApellido.TabIndex = 3;
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApellido.Location = new System.Drawing.Point(53, 105);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(122, 17);
            this.lblNombreApellido.TabIndex = 2;
            this.lblNombreApellido.Text = "Nombre y Apellido";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(41, 325);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(134, 44);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar Usuario";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(41, 375);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(134, 44);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "Modificar Usuario";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.Location = new System.Drawing.Point(181, 375);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(134, 44);
            this.btnGuardarCambios.TabIndex = 15;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoUsuario.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUsuario.Location = new System.Drawing.Point(181, 325);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(134, 44);
            this.btnNuevoUsuario.TabIndex = 13;
            this.btnNuevoUsuario.Text = "Guardar nuevos datos";
            this.btnNuevoUsuario.UseVisualStyleBackColor = true;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 427);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.btnNuevoUsuario);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtConfirmarContra);
            this.Controls.Add(this.lblConfirmarContra);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.txtNombreApellido);
            this.Controls.Add(this.lblNombreApellido);
            this.Controls.Add(this.cmbEleccion);
            this.Controls.Add(this.lblElegir);
            this.Name = "frmAdmin";
            this.Text = "Pantalla Principal (Administrador)";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblElegir;
        private System.Windows.Forms.ComboBox cmbEleccion;
        private System.Windows.Forms.TextBox txtConfirmarContra;
        private System.Windows.Forms.Label lblConfirmarContra;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtNombreApellido;
        private System.Windows.Forms.Label lblNombreApellido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Button btnNuevoUsuario;
    }
}