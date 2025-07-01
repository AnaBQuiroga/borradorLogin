using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromBorrador
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
            chkTerminosCond.Enabled = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreApellido.Text))
            {
                MessageBox.Show("Debe completar el nombre y el apellido");
                txtNombreApellido.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDNI.Text))
            {
                MessageBox.Show("Debe completar el DNI");
                txtDNI.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                MessageBox.Show("Debe completar el correo electrónico");
                txtCorreo.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Debe completar la contraseña");
                txtContraseña.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtConfirmarContra.Text))
            {
                MessageBox.Show("Debe repetir su contraseña");
                txtConfirmarContra.Focus();
                return;
            }

            if (!chkTerminosCond.Checked)
            {
                MessageBox.Show("Debe aceptar los términos y condiciones para continuar", 
                    "ERROR", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                return;
            }


            this.Close();
        }

        private void lblVolverInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lklTerminosCond_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("TERMINOS Y CONDICIONES", "Términos y condiciones");
            chkTerminosCond.Enabled = true;
        }
    }
}
