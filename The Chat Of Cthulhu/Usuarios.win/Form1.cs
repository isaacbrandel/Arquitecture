﻿using Cthulhu.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usuarios.win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var TagsBL= new TagsBL();
            var ListaTag = TagsBL.Tags();
            foreach (var Categoria in ListaTag)
            {
                MessageBox.Show(Categoria.Nombre);
            }
        }
    }
}
