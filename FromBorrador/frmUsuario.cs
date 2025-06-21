using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromBorrador
{
    public partial class frmUsuario : Form
    {
        string nombres, correos, contraseñas;
        public frmUsuario(string nombre, string correo, string contraseña)
        {
            InitializeComponent();
            this.nombres = nombre;
            this.correos = correo;
            this.contraseñas = contraseña;

            txtNombreUsuario.Text = nombre;
            txtCorreoUsuario.Text = correo;
            txtContraUsuario.Text = contraseña;
            txtNombreUsuario.ReadOnly = true;
            txtCorreoUsuario.ReadOnly = true;
            txtContraUsuario.ReadOnly = true;

            
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {

            

        }

        private void frmUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cierre = MessageBox.Show("¿Estás seguro que quieres cerrar sesión?",
                "Volver a login",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Asterisk,
                MessageBoxDefaultButton.Button2);

            if (cierre == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtNombreUsuario.ReadOnly = false;
            txtCorreoUsuario.ReadOnly = false;
            txtContraUsuario.ReadOnly = false;

            
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreUsuario.Text) || string.IsNullOrEmpty(txtCorreoUsuario.Text) || string.IsNullOrEmpty(txtContraUsuario.Text))
            {
                MessageBox.Show("Por favor completa los datos obligatorios", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            nombres = txtNombreUsuario.Text;
            correos = txtCorreoUsuario.Text;
            contraseñas = txtContraUsuario.Text;


            txtNombreUsuario.ReadOnly = true;
            txtCorreoUsuario.ReadOnly = true;
            txtContraUsuario.ReadOnly = true;

            

            MessageBox.Show("Los datos se guardaron correctamente")
;

        }
        
        
        
    }
}
