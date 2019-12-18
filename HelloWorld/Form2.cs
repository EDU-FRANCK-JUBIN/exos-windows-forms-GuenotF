﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            String name = nameTb.Text;
            String address = addressTb.Text;

            MessageBox.Show("Nom: " + name + "Address: " + address);
            
        }

        private void cityLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = cityLb.GetItemText(cityLb.SelectedItem);
            MessageBox.Show(text, "Nom cliqué");
        }
    }
}
