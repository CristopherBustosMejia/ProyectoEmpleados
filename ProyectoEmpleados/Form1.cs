﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Clases.CConexion ObjectC = new Clases.CConexion(txtBoxUser.Text,txtBoxPsswrd.Text);
            ObjectC.StabConex();
            ObjectC.CloseConex();
            if(ObjectC.flag == true)
            {
                Form2 form2 = new Form2();
                form2.form1 = this;
                form2.Show();
                this.Hide();
            }
        }
    }
}
