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

        List<string> nombres = new List<string> {} ;
        List<string> correos = new List<string> {};
        List<string> contras = new List<string> {};

        
        public frmUsuario()
        {
            InitializeComponent();



            //txtNombreUsuario.Text = nombres[0];
            //txtCorreoUsuario.Text = correos[0];
            //txtContraUsuario.Text = contras[0];

            txtNombreUsuario.ReadOnly = true;
            txtCorreoUsuario.ReadOnly = true;
            txtContraUsuario.ReadOnly = true;
           
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            nombres.Add ("Ana");
            correos.Add("anaquiroga@gmail.com");
            contras.Add("ana222");
            txtNombreUsuario.Text = nombres[0];
            txtCorreoUsuario.Text = correos[0];
            txtContraUsuario.Text = contras[0];

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
            //MessageBox.Show("Ya podes modificar tus datos");

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
            
           

            txtNombreUsuario.ReadOnly = true;
            txtCorreoUsuario.ReadOnly = true;
            txtContraUsuario.ReadOnly = true;

            

            MessageBox.Show("Los datos se guardaron correctamente")
;

        }
        
        
        
    }
}
