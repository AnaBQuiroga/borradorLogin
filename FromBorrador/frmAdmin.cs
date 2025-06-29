using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromBorrador
{
    public partial class frmAdmin : Form
    {
        List<string> correos = new List<string> { "anaquiroga@gmail.com", "natijacqet@gmail.com", "aguirreramiro@gmail.com" };
        List<string> nombresApellidos = new List<string> { "Ana Quiroga", "Natalia Jacquet", "Ramiro Aguirre" };
        List<string> contraseñas = new List<string> { "ana222", "nati333", "rami111" };
        List<string> roles = new List<string> { "usuario", "administrador", "administrador" };
        List<string> dni = new List<string> { "111111111", "22222222", "333333333" };
        public frmAdmin()
        {
            InitializeComponent();
            txtNombreApellido.ReadOnly = true;
            txtCorreo.ReadOnly = true;
            txtDNI.ReadOnly = true;
            txtContraseña.ReadOnly = true;
            txtConfirmarContra.ReadOnly = true;
            btnNuevoUsuario.Enabled = false;
            btnGuardarCambios.Enabled = false;
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void cmbEleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //agregando cmbEleccion.SelectedIndex ya el textBox muestra los datos guardados segun su ubicación en la lista
            //la otra opción con switch limitaba los usuarios que mostraba y no permitia mostrar los datos del nuevo usuario

            txtNombreApellido.Text = nombresApellidos[cmbEleccion.SelectedIndex];
            txtDNI.Text = dni[cmbEleccion.SelectedIndex];
            txtCorreo.Text = correos[cmbEleccion.SelectedIndex];
            txtContraseña.Text = contraseñas[cmbEleccion.SelectedIndex];
            txtConfirmarContra.Text = contraseñas[cmbEleccion.SelectedIndex];

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //limpiamos los textBox al hacer click en el boton
            txtNombreApellido.Clear();
            txtCorreo.Clear();
            txtDNI.Clear();
            txtContraseña.Clear();
            txtConfirmarContra.Clear();
            //habilitamos los textBox para editarlos
            txtNombreApellido.ReadOnly = false;
            txtCorreo.ReadOnly = false;
            txtDNI.ReadOnly = false;
            txtContraseña.ReadOnly = false;
            txtConfirmarContra.ReadOnly = false;
            //Habilitamos el boton para validar los datos nuevos del nuevo usuario y guardarlos 
            btnNuevoUsuario.Enabled = true;
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreApellido.Text;
            string correo = txtCorreo.Text;
            string numDni = txtDNI.Text;
            string contra = txtContraseña.Text;
            string confirmaContra = txtConfirmarContra.Text;

            if (string.IsNullOrEmpty(txtNombreApellido.Text) || string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtDNI.Text) || string.IsNullOrEmpty(txtContraseña.Text) || string.IsNullOrEmpty(txtConfirmarContra.Text))
            {
                DialogResult guardar = MessageBox.Show("Debe ingresar todos los datos solicitados",
                    "ATENCIÓN",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Asterisk);

                if (guardar == DialogResult.Cancel)
                {
                    btnNuevoUsuario.Enabled = false;
                }
                return;
            }

            if (nombresApellidos.Contains(nombre) && correos.Contains(correo) && dni.Contains(numDni) && contraseñas.Contains(contra) && confirmaContra.Contains(confirmaContra) ) 
            {
                MessageBox.Show("El dato ingresado ya existe, ingrese uno nuevo");
                return;
            }

            if (confirmaContra != contra)
            {
                MessageBox.Show("Las contraseñas no coinciden! intente de nuevo", "Atencion", MessageBoxButtons.OK);
                return;
            }

            //datos agregados a las listas
            nombresApellidos.Add(nombre);
            cmbEleccion.Items.Add(nombre);
            correos.Add(correo);
            dni.Add(numDni);
            contraseñas.Add(contra);
            //se desabilita el boton agregar nuevo usuario
            btnNuevoUsuario.Enabled = false;
            //indicar que ya no se pueden editar los datos
            txtNombreApellido.ReadOnly = true;
            txtCorreo.ReadOnly = true;
            txtDNI.ReadOnly = true;
            txtContraseña.ReadOnly = true;
            txtConfirmarContra.ReadOnly = true;



            //prueba de validación
            MessageBox.Show("Se guardaron los datos correctamente");
        
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtCorreo.Clear();
            txtContraseña.Clear();
            txtConfirmarContra.Clear();
            txtCorreo.ReadOnly = false;
            txtContraseña.ReadOnly = false;
            txtConfirmarContra.ReadOnly = false;
            btnGuardarCambios.Enabled = true;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreApellido.Text;
            string correo = txtCorreo.Text;
            string contra = txtContraseña.Text;
            string confirmaContra = txtConfirmarContra.Text;

            if (string.IsNullOrEmpty(txtCorreo.Text) || string.IsNullOrEmpty(txtContraseña.Text) || string.IsNullOrEmpty(txtConfirmarContra.Text))
            {
                DialogResult guardar = MessageBox.Show("Debe ingresar todos los datos solicitados",
                    "ATENCIÓN",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Asterisk);

                if (guardar == DialogResult.Cancel)
                {
                    btnGuardarCambios.Enabled = false;
                }
                return;
            }

            
            for (int i = 0; i < correos.Count; i++) 
            {
                // El for recorre los usuarios y si el índice coincide con el que elegí en el ComboBox,
                // significa que encontré al usuario que quiero cambiar

                if (i == cmbEleccion.SelectedIndex)
                {
                    //Si el correo que ya esta guardado en i (posicion en la lista) es igual al correo que escribi en textbox, 
                    //lo mismo con contraseña, significa que el dato que ingrese como nuevo en realidad ya existe
                    if (correos[i] == correo && contraseñas[i] == contra)
                    {
                        MessageBox.Show("El dato ingresado ya existe, ingrese uno nuevo");
                        return;
                    }

                    //si los datos ingresados son diferentes a los guardados significa que si sirven 
                    if (correos[i] != correo && contraseñas[i] != contra)
                    {
                        correos[i] = correo;
                    }

                    //si la contraseña y su confirmación coinciden, se guardan 
                    if (contra == confirmaContra)
                    {
                        contraseñas[i] = contra;
                        
                        btnGuardarCambios.Enabled = false;
                        txtCorreo.ReadOnly = true;
                        txtContraseña.ReadOnly = true;
                        txtConfirmarContra.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden! intente de nuevo", "Atencion", MessageBoxButtons.OK);
                        return;
                    }
                    
                }
                
            }

            MessageBox.Show("Los datos se modificaron correctamente");
            

        }
    }
}
