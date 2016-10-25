using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias
{
    class Provincia
    {
        private string iNombre;
        private int id;

        public Provincia(string pNombre) {
            iNombre = pNombre;
        }

        public string nombre {
            set { iNombre = value; }
            get { return iNombre; }
        }
    }
}
