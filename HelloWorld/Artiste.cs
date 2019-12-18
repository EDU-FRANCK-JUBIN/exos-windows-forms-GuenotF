using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Artiste
    {
        string _nomArtiste;
        List<Chanson> _chansonsList;

        public Artiste()
        {

        }

        public Artiste(string nomArtiste, List<Chanson> chansonsList)
        {
            _nomArtiste = nomArtiste;
            _chansonsList = chansonsList;
        }

        public string NomArtiste
        {
            get { return _nomArtiste; }
            set { _nomArtiste = value; }
        }

        public List<Chanson> ChansonList
        {
            get { return _chansonsList; }
            set { _chansonsList = value; }
        }




    }
}
