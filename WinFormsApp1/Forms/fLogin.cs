using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Modelos;
using WinFormsApp1.Persistencia;
using WinFormsApp1.Controladores;

namespace WinFormsApp1.Forms
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            string usernameIngresado = tbUsuario.Text;
            string passwordIngresada = tbContrasena.Text;

            Usuario usuarioEncontrado = nUsuario.Login(usernameIngresado, passwordIngresada);

            if (usuarioEncontrado != null)
            {
                fSesion fs = new fSesion(usuarioEncontrado);
                fs.Show();
                this.Hide();
            }
            else
            {
                lbUsuario.ForeColor = Color.IndianRed;
                lbUsuario.Font = new Font(lbUsuario.Font, FontStyle.Underline | FontStyle.Bold);
                lbContrasena.ForeColor = Color.IndianRed;
                lbContrasena.Font = new Font(lbContrasena.Font, FontStyle.Underline | FontStyle.Bold);

                MessageBox.Show(this, "Usuario o contraseña incorrectos.\nIngrese nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tbUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el ruido "beep" de Windows

                tbContrasena.Focus(); // Le pasa el foco al cuadro de contraseña
            }
        }

        private void tbContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el ruido "beep" de Windows

                // Ejecuta la misma acción que el clic del botón de ingresar
                btIngresar_Click(this, new EventArgs());
            }
        }
        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void tbContrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
