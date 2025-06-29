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
    public partial class frmLogin : Form
    {
        List<string> correos = new List<string> { "anaquiroga@gmail.com", "nati", "aguirreramiro@gmail.com" };
        List<string> nombres = new List<string> { "Ana", "Natalia", "Ramiro" };
        List<string> contraseñas = new List<string> { "ana222", "nati333", "rami111" };
        List<string> roles = new List<string> { "usuario", "administrador", "administrador" };

        //int indice;
        public frmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = btnInicioSesion;
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtNombreCorreo.Text))
            {
                MessageBox.Show("Verifica que estás ingresando el nombre de usuario correcto. Si usas correo electrónico, asegúrate de que sea el correcto. "); 
                txtNombreCorreo.Focus();
                return;
            }
            
            if (string.IsNullOrEmpty(txtLeeContra.Text))
            {
                MessageBox.Show("Asegúrate de que estás ingresando la contraseña correcta");
                txtLeeContra.Focus();

                return;
            }

            string rol="";
            for (int i = 0; i < nombres.Count; i++)
            {
                
                 if ((txtNombreCorreo.Text == nombres[i] || txtNombreCorreo.Text == correos[i]) && txtLeeContra.Text == contraseñas[i])
                {
                    rol=roles[i];
                    MessageBox.Show($" Bienvenidx {nombres[i]}!!");
                    //si los datos son correctos se corta acá el programa

                }
            }

            if (rol == "usuario")
            {
                txtNombreCorreo.Clear();
                txtLeeContra.Clear();
                frmUsuario usuario = new frmUsuario();
                usuario.ShowDialog();
                return;
            } else if (rol == "administrador")
            {
                txtNombreCorreo.Clear();
                txtLeeContra.Clear();
                frmAdmin admin = new frmAdmin();
                admin.ShowDialog();
            } else
            {
                MessageBox.Show("Verfica los datos ingresados");
                txtNombreCorreo.Clear();
                txtLeeContra.Clear();
            }
        }

        //nombre de usuario o correo electronico
        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnOlvidarContra_Click(object sender, EventArgs e)
        {
            DialogResult recuperar = MessageBox.Show("¿Has olvidado tu contraseña? Te enviaremos un código a tu correo electrónico.", 
                "RECUPERAR CONTRASEÑA",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            
            if (recuperar==DialogResult.OK) 
            {
                frmIngresoCodigo ingreso = new frmIngresoCodigo();
                ingreso.ShowDialog(); //formulario INDEPENDIENTE, showDialog() formulario HIJO
            }

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult cierre = MessageBox.Show("¿Esta seguro que desea salir de la app?",
                "SALIR", 
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Asterisk,
                MessageBoxDefaultButton.Button2);

            if (cierre == DialogResult.Cancel) 
            {
                e.Cancel = true;
            }
            
        }

        private void lblRegistro_Click(object sender, EventArgs e)
        {
            frmRegistro registrar = new frmRegistro();
            registrar.ShowDialog();
        }
    }
}
