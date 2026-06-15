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
        public fSesion(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
            inicializarForm();


        }
        public void inicializarForm() {
            //
            lbBienvenida.Text = $"Bienvenido, {_usuario.Nombre}!";
            this.Controls.Add(lbBienvenida);
            //
            lbRol.Text = $"- ROL: {new pRol().ObtenerPorId(_usuario.IdRol).Nombre} -";
            this.Controls.Add(lbRol);
            //
        }
        
    }
}
