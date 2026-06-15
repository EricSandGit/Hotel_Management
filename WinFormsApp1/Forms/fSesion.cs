using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.Modelos;
using WinFormsApp1.Persistencia;

namespace WinFormsApp1.Forms
{
    public partial class fSesion : Form
    {
        Usuario _usuario;
        Color colorFondoForm = Color.FromArgb(45, 45, 45);
        Color colorBarraLateral = Color.FromArgb(39, 56, 99);
        Color colorSecundarioBotones = Color.FromArgb(43, 60, 110);
        Color colorBotonSeleccionado = Color.FromArgb(60, 60, 65);

        Button botonActivoActual = null;
        public fSesion(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            this.StartPosition = FormStartPosition.CenterScreen;
            inicializarForm();
            this.BackColor = colorFondoForm;

        }
        public void inicializarForm()
        {
            colorBarraLateral = Color.FromArgb(30, 30, 30);
            colorSecundarioBotones = Color.FromArgb(45, 45, 48);


            pnLateral.BackColor = colorBarraLateral;

            lbBienvenida.Text = $"Bienvenido, \n{_usuario.Nombre}!";
            lbRol.Text = $"- {new pRol().ObtenerPorId(_usuario.IdRol).Nombre} -";

            foreach (Control control in pnLateral.Controls)
            {
                if (control is Button boton)
                {
                    boton.FlatStyle = FlatStyle.Flat;
                    boton.FlatAppearance.BorderSize = 0;
                    boton.BackColor = colorBarraLateral;
                    boton.ForeColor = Color.FromArgb(220, 220, 220);
                }
            }
        }


        private void button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button botonActivo)
            {
                if (botonActivo != botonActivoActual)
                {
                    botonActivo.BackColor = colorSecundarioBotones;
                }
            }
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button botonActivo)
            {
                if (botonActivo != botonActivoActual)
                {
                    botonActivo.BackColor = colorBarraLateral;
                }
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
                fh.Dock = DockStyle.Fill;        // El form ocupa todo el tamaño del panel

                this.pnContenedor.Controls.Add(fh); 
                this.pnContenedor.Tag = fh; // Guarda en el panel un tag de lo que se está viendo
                fh.Show();                       
            }
        }
        private void btCliente_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Button)sender);


        }
        private void btCuenta_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Button)sender);


        }
        private void btEstadia_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Button)sender);


        }
        private void btGastoExtra_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Button)sender);


        }
        private void btHabitacion_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Button)sender);


        }
        private void btReserva_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Button)sender);


        }
        private void btRol_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Button)sender);


        }
        private void btUsuario_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Button)sender);


        }
    }
}
