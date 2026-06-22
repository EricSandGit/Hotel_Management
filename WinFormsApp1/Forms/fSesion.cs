using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Controladores;
using WinFormsApp1.Modelos;
using WinFormsApp1.Persistencia;
using WinFormsApp1.Forms.fClientes;
using WinFormsApp1.Forms.fReservas;
using WinFormsApp1.Forms.fUsuarios;
using WinFormsApp1.Forms.fEstadias;

namespace WinFormsApp1.Forms
{
    public partial class fSesion : Form
    {
        Usuario usuarioSesion;
        Form formLoginOriginal;
        Color colorBarraLateral = Color.FromArgb(30, 30, 30);
        Color colorBotonSeleccionado = Color.FromArgb(60, 60, 65);

        Button botonActivoActual = null;
        public fSesion(Usuario usuario, Form formLogin)
        {
            InitializeComponent();
            usuarioSesion = usuario;
            formLoginOriginal = formLogin;
            this.StartPosition = FormStartPosition.CenterScreen;
            inicializarForm();

        }
        public void inicializarForm()
        {


            lbBienvenida.Text = $"Bienvenido, \n{_usuario.Nombre.Replace(" ", "\n")}!";
            lbRol.Text = $"{nRol.ObtenerRolPorId(_usuario.IdRol).Nombre}";

            if (usuarioSesion.IdRol == 1) //Administrador
            {
                //Todo queda habilitado por default para el usuario administrador
            }
            else if (usuarioSesion.IdRol == 2) //Recepcionista
            {
                //Se desactivan las opciones de agregar usuarios y habitaciones 
                btHabitacion.Enabled = false;
                btUsuario.Enabled = false;
            }
            else //Rol no registrado no puede hacer nada
            {
                btCliente.Enabled = false;
                btCuenta.Enabled = false;
                btEstadia.Enabled = false;
                btGastoExtra.Enabled = false;
                btReserva.Enabled = false;
                btHabitacion.Enabled = false;
                btUsuario.Enabled = false;
            }

        }



        private void SeleccionarBoton(Button botonClickeado)
        {
            // Boton seleccionado anterior
            if (botonActivoActual != null)
            {
                botonActivoActual.BackColor = colorBarraLateral;
            }

            // Nuevo boton seleccionado
            botonActivoActual = botonClickeado;
            botonActivoActual.BackColor = colorBotonSeleccionado;
        }
        private void AbrirFormEnPanel(object formHijo)
        {
            // Vaciar el panel
            if (this.pnContenedor.Controls.Count > 0)
                this.pnContenedor.Controls.RemoveAt(0);

            // Se convierte el objeto a un form
            Form fh = formHijo as Form;
            if (fh != null)
            {
                fh.TopLevel = false;             // No es una ventana independiente
                fh.FormBorderStyle = FormBorderStyle.None; // Sacar la barra de arriba 
                fh.Dock = DockStyle.Fill;        // El form ocupa todo el tamao del panel

                this.pnContenedor.Controls.Add(fh);
                this.pnContenedor.Tag = fh; // Guarda en el panel un tag de lo que se esta viendo
                fh.Show();
            }
        }
        private void btCliente_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Button)sender);

            AbrirFormEnPanel(new fClientesListar());

        }
        private void btCuenta_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Button)sender);

            AbrirFormEnPanel(new fCuentaCliente());

        }
        private void btEstadia_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Button)sender);

            AbrirFormEnPanel(new fListarEstadias());

        }
        private void btGastoExtra_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Button)sender);

            AbrirFormEnPanel(new FGastosExtra());

        }
        private void btHabitacion_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Button)sender);


        }
        private void btReserva_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Button)sender);

            AbrirFormEnPanel(new fListarReservas());
        }
        private void btUsuario_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Button)sender);

            AbrirFormEnPanel(new fListarUsuarios());

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            if (formLoginOriginal != null)
            {
                formLoginOriginal.Show();
                if (formLoginOriginal is fLogin loginForm)
                {
                    loginForm.ReiniciarFormulario();
                }

            }
            this.Close();
        }

        private void pnLateral_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
