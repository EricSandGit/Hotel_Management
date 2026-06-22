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
    public partial class fModificarUsuarios : Form
    {
        private Usuario usuario;

        public fModificarUsuarios(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void fModificarUsuarios_Load(object sender, EventArgs e)
        {
            List<Rol> roles = nRol.ListarRoles();
            cbRoles.DataSource = roles;
            cbRoles.DisplayMember = "Nombre";
            cbRoles.ValueMember = "IdRol";

            tbNombre.Text = usuario.Nombre;
            tbUsername.Text = usuario.Username;
            tbContrasena.Text = usuario.Password;
            cbRoles.SelectedValue = usuario.IdRol;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (cbRoles.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un rol para el usuario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuarioModificado = new Usuario
            {
                IdUsuario = usuario.IdUsuario,
                Nombre = tbNombre.Text.Trim(),
                Username = tbUsername.Text.Trim(),
                Password = tbContrasena.Text,
                IdRol = (int)cbRoles.SelectedValue
            };

            bool exito = nUsuario.ActualizarUsuario(usuarioModificado);

            if (!exito)
            {
                MessageBox.Show("No se pudo actualizar el usuario. Verifique los datos o que el nombre de usuario no esté duplicado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            usuario.Nombre = usuarioModificado.Nombre;
            usuario.Username = usuarioModificado.Username;
            usuario.Password = usuarioModificado.Password;
            usuario.IdRol = usuarioModificado.IdRol;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}