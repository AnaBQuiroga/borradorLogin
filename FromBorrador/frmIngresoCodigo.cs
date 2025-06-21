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
    public partial class frmIngresoCodigo : Form
    {
        List<string> correos, contraseñas;

        public frmIngresoCodigo(List<string> correos, List<string> contraseñas)
        {
            InitializeComponent();
            txtCodigo.ReadOnly = true;
            txtNuevaContra.ReadOnly = true;
            this.contraseñas = contraseñas;
            this.correos = correos;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            string contra = "abc123";
            if (txtCodigo.Text == contra)
            {
                MessageBox.Show("Ingrese su nueva contraseña");
                txtNuevaContra.Focus();
                txtNuevaContra.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("El código ingresado es incorrecto o esta vacío, intente de nuevo");
                txtCodigo.Clear();
                return;
            }
        }

        private void btnCorreoIngresado_Click(object sender, EventArgs e)
        {
            string correoIngresado = txtCorreoIngresado.Text;
            for (int i = 0; i < correos.Count; i++)
            {
                if (!(string.IsNullOrEmpty(txtCorreoIngresado.Text)) && txtCorreoIngresado.Text == correoIngresado)
                {
                    MessageBox.Show("Correo valido! Introduzca el código que le fue enviado.",
                        "CODIGO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (true)
                    {
                        txtCodigo.Focus();
                        txtCodigo.ReadOnly = false;

                    }
                    return;

                }

            }
            MessageBox.Show("Correo invalido! Intente nuevamente",
                    "Ocurrio un problema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            txtCorreoIngresado.Clear();
            txtCorreoIngresado.Focus();
        }

        private void btnNuevaContraseña_Click(object sender, EventArgs e)
        {
            string correoIngresado = txtCorreoIngresado.Text;
            string nuevaContraseña = txtNuevaContra.Text;

            int indice = correos.IndexOf(correoIngresado);

            if ((!string.IsNullOrEmpty(txtCorreoIngresado.Text)) && txtCorreoIngresado.Text == correoIngresado)
            {
                if (!string.IsNullOrEmpty(txtNuevaContra.Text))
                {
                    contraseñas[indice] = txtNuevaContra.Text;
                    MessageBox.Show("La contraseña se modificó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNuevaContra.ReadOnly = true;

                }
            }

            MessageBox.Show("Ocurrio un error, intente de nuevo");
            txtNuevaContra.Focus();
        }
    
        
    }
}
