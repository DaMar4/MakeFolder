﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String Documentos = Environment.GetEnvironmentVariable("USERPROFILE");
            Documentos = Documentos + "/Documents/SADER".Replace("\\","/");
            if (!Directory.Exists(Documentos))
            {
                Directory.CreateDirectory(Documentos);
            }
            
        }
    }
}
