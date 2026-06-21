using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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
    }
}
