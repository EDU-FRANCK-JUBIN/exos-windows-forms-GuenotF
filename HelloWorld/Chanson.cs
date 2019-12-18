using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Chanson
    {
        
        string _titreChanson;
        

        public Chanson()
        {
        }

        public Chanson(string titreChanson)
        {
            TitreChanson = titreChanson;
        }

        public string TitreChanson
        {
            get { return _titreChanson; }
            set { _titreChanson = value; }
        }
    }
}
