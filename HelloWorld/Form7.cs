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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            Hexa hexa = new Hexa(30, panel1.Width / 2, panel1.Height / 2);

            Pen p = new Pen(Color.Black);
            SolidBrush sb = new SolidBrush(Color.Black);
            graphics.DrawPolygon(Pens.Red, hexa.points);
            graphics.FillPolygon(Brushes.Blue, hexa.points);

            for (int Achier = 0; Achier < 127; Achier++)
            {
                
                Hexa hexa1 = new Hexa(30, panel1.Width / 1+Achier, panel1.Height / 1+Achier);
                graphics.DrawPolygon(Pens.Red, hexa.points);
                graphics.FillPolygon(Brushes.Blue, hexa.points);

            }


        }
    }
}
