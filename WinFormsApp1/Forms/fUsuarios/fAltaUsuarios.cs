using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Controladores;
using WinFormsApp1.Modelos;

namespace WinFormsApp1.Forms.fUsuarios
{
    public partial class fAltaUsuarios : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Usuario UsuarioNuevo { get; set; }

        public fAltaUsuarios()
        {
            InitializeComponent();
        }

        private void fAltaUsuarios_Load(object sender, EventArgs e)
        {            
            cbRoles.DataSource = nRol.ListarRoles();
            cbRoles.DisplayMember = "Nombre";
            cbRoles.ValueMember = "IdRol";
            cbRoles.SelectedIndex = -1;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text.Trim();
            string username = tbUsername.Text.Trim();
            string contrasena = tbContrasena.Text;

            if (cbRoles.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un rol para el usuario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idRol = (int)cbRoles.SelectedValue;

            bool exito = nUsuario.CrearUsuario(nombre, username, contrasena, idRol);

            if (exito)
            {
                UsuarioNuevo = new Usuario
                {
                    Nombre = nombre,
                    Username = username,
                    Password = contrasena,
                    IdRol = idRol
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo crear el usuario. Verifique que los campos no estén vacíos o que el nombre de usuario no se encuentre duplicado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
    }
}