using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.Forms.fUsuarios
{
    public partial class fEliminarUsuarios : Form
    {
        private int idUsuario;

        public fEliminarUsuarios(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }
    }
}
