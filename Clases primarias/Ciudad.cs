﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias
{
    class Ciudad
    {
        private int iId;
        private string iNombre;
        private int iCPostal;

        public Ciudad(string pNombre, int pCPostal) {
            iNombre = pNombre;
            iCPostal = pCPostal;
        }

        public string nombre {
            set { iNombre = value; }
            get { return iNombre; }
        }

        public int cPostal {
            set { iCPostal = value; }
            get { return iCPostal; }
        }
    }
}
