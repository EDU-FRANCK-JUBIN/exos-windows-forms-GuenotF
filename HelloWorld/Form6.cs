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
    public partial class Form6 : Form
    {

        public Form6()
        {
            List<Artiste> artistes = new List<Artiste>();

            InitializeComponent();
            for(int i = 0; i < 5; i++)
            {
                List<Chanson> chansonsTmp = new List<Chanson>();

                for(int j = 0; j < 5; j++)
                {
                    Chanson chansonTemp = new Chanson("La coline" + j + "-" + i);
                    chansonsTmp.Add(chansonTemp);
                    
                }

                Artiste artisteTemp = new Artiste("Joe Dassin" + i, chansonsTmp);
                artistes.Add(artisteTemp);
            }

            

            this.gridView.DataSource = artistes;
 
        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            DataGridViewRow dataRow = grid.Rows[e.RowIndex];
            Artiste artiste = new Artiste();
            artiste = (Artiste)dataRow.DataBoundItem;
            this.gridViewSongs.DataSource = artiste.ChansonList;
        }
    }
}
