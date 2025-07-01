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
        List<string> correos = new List<string> { "anaquiroga@gmail.com", "natijacqet@gmail.com", "aguirreramiro@gmail.com" } ;
        List<string> contraseñas = new List<string> { "ana222", "nati333", "rami111" };


        public frmIngresoCodigo()
        {
            InitializeComponent();
            txtCodigo.ReadOnly = true;
            txtNuevaContra.ReadOnly = true;
            this.AcceptButton = btnCorreoIngresado;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            string contra = "abc123";
            if (txtCodigo.Text == contra)
            {
                //MessageBox.Show("Ingrese su nueva contraseña");
                txtCodigo.ReadOnly = true;
                txtNuevaContra.Focus();
                txtNuevaContra.ReadOnly = false;
                return;
            }
            else
            {
                MessageBox.Show("El código ingresado es incorrecto o esta vacío, intente de nuevo.",
                      "CODIGO",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Asterisk);
                if (true)
                {
                    txtCodigo.Clear();
                    txtCodigo.Focus();
                    txtCodigo.ReadOnly = true;
                    return;
                }
            }
        }

        private void btnCorreoIngresado_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < correos.Count; i++)
            {
                if (!(string.IsNullOrEmpty(txtCorreoIngresado.Text)) && txtCorreoIngresado.Text == correos[i])
                {
                    MessageBox.Show("Correo valido! Introduzca el código que le fue enviado.",
                        "CORREO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (true)
                    {
                        MessageBox.Show("abc123", "Código de recuperación", MessageBoxButtons.OK);
                        txtCodigo.Focus();
                        txtCodigo.ReadOnly = false;

                    }
                    return;

            }

            }
            MessageBox.Show("Correo invalido! Intente nuevamente, debe ingresar el correo para que se le puedo enviar el código",
                    "Ocurrio un problema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            txtCorreoIngresado.Clear();
            txtCorreoIngresado.Focus();
        }

        private void btnNuevaContraseña_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtNuevaContra.Text))
            {
                MessageBox.Show("Ocurrio un error, intente de nuevo");
                
            }
            else
            {
                DialogResult contraCorrecta = MessageBox.Show("La contraseña se modificó correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                if (contraCorrecta == DialogResult.OK)
                {
                    txtNuevaContra.ReadOnly = true;

                }
            }
           
        }

        private void frmIngresoCodigo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cierre = MessageBox.Show("¿Esta seguro que quieres volver al inicio de sesión?",
                "SALIR",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Asterisk,
                MessageBoxDefaultButton.Button2);

            if (cierre == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
