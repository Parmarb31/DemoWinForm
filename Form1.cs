﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            System.Diagnostics.Process.Start("chrome", "https://www.google.com/");

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are Click on Submit Button..");
            MessageBox.Show("");
        }
    }
}
