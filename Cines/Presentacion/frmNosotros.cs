﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinesFront.Presentacion
{
    public partial class frmNosotros : Form
    {
        public frmNosotros()
        {
            InitializeComponent();
        }

        private void btnIniciarSesionAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
