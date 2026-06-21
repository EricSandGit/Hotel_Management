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
    public partial class fAltaUsuarios : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Usuario UsuarioNuevo { get; set; }
        public fAltaUsuarios()
        {
            InitializeComponent();
        }
    }
}
