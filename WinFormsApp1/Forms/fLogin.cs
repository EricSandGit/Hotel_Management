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

            List<Usuario> usuarios = pUsuario.getAll();
            Usuario usuarioEncontrado = null;

            foreach (Usuario u in usuarios)
            {
                if (u.Username == usernameIngresado && u.PasswordHash == passwordIngresada)
                {
                    usuarioEncontrado = u;
                    break;
                }
            }

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
    }
}
