﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempOmvandlareInlamning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double userInput;

            userInput = double.Parse(Input.Text);

            if (CtillF.Checked)
            {
                double celsius = userInput * 9 / 5 + 32;
                Resultat.Text = string.Format("{0:0.00}", celsius);
            }

            if (FtillC.Checked)
            {
                double fahrenheit = (userInput - 32) * 5 / 9;
                Resultat.Text = string.Format("{0:0.00}", fahrenheit);
            }
            

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
