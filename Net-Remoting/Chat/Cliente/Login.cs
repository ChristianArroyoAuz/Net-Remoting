// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 29/06/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System;

namespace Cliente
{
    public partial class Login : Form
    {
        public string nombreUsuario;

        public Login()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text != null)
            {
                this.nombreUsuario = txtNombreUsuario.Text;
            }
        }
    }
}