﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucrarea2_cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 0, k = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            
                if (k == 1)
                    x += 10;
                else
                    x -= 10;
                label1.Text = x.ToString();

                if (x == 100)
                    k = 0;
                else if (x == 0)
                    k = 1;
        }
        //////////////////////EXPLICATII/////////////////////// 〜(￣▽￣〜)(〜￣▽￣)〜
        ///// valoarea continuta in label este data de variabila x;
        ///// variabila k este un indice care va tine minte tipul de operatie ce se va efectua
        ///// initial, k e egal cu 1, ceea ce inseamna ca x va putea doar sa creasca (0--100)
        ///// a doua structura de decizie “if” si “else if” verifica daca valoarea a atins 
        ////// extremitatile intervalului dorit si, dupa cazul in care se afla, semnul operatiei
        ////////matematice care va urma se va schimba; k=0 => minus; k=1 =>plus
    }
}
