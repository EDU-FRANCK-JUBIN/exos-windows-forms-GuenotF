using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void ceBtn_Click(object sender, EventArgs e)
        {
            resultTb.Text = "";
            oldResultTb.Text = "";
        }

        private void cBtn_Click(object sender, EventArgs e)
        {
            resultTb.Text = "";
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            resultTb.Text += 7;
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            resultTb.Text += 8;
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            resultTb.Text += 9;
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            resultTb.Text += 4;
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            resultTb.Text += 5;
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            resultTb.Text += 6;
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            resultTb.Text += 1;
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            resultTb.Text += 2;
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            resultTb.Text += 3;
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            resultTb.Text += 0;
        }

        private void retourBtn_Click(object sender, EventArgs e)
        {
            if(resultTb.Text.Length == 0)
            {
                MessageBox.Show("Rien a supprimer", "Erreur");
            } else
            {
                resultTb.Text = resultTb.Text.Remove(resultTb.Text.Length -1, 1);
            }
            
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            oldResultTb.Text += resultTb.Text;
            try
            {
                var v = dt.Compute(oldResultTb.Text, "");
                oldResultTb.Text += "=";
                resultTb.Text = v.ToString();

            } catch(InvalidCastException err)
            {
                MessageBox.Show(err.ToString(), "Erreur");
            }


        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            resultTb.Text += "*";
            oldResultTb.Text += resultTb.Text;
            resultTb.Text = "";
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            resultTb.Text += "-";
            oldResultTb.Text += resultTb.Text;
            resultTb.Text = "";
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            resultTb.Text += "+";
            oldResultTb.Text += resultTb.Text;
            resultTb.Text = "";
        }

        private void pointBtn_Click(object sender, EventArgs e)
        {
            if (resultTb.Text.Contains("."))
            {
                MessageBox.Show("Une virgule est déjà entrée", "Erreur");
            } else
            {
                resultTb.Text += ".";
            }
                
        }

        private void slashBtn_Click(object sender, EventArgs e)
        {
            resultTb.Text += "/";
            oldResultTb.Text += resultTb.Text;
            resultTb.Text = "";
        }

        private void plusMinBtn_Click(object sender, EventArgs e)
        {
            float inverse = float.Parse(resultTb.Text) * (-1);
            resultTb.Text = inverse.ToString();
            
           
        }
    }
}
