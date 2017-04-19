using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias
{
    class Domicilio  
    {
        private String iCalleNombre;
        private int iNumero;
        private int iIdDomicilio;
        private int iPiso;
        private string iDepto;
        private Ciudad iCiudad;

        public Domicilio() { }

        public Domicilio(String pCalleNombre, int pNumero, Ciudad pCiudad) {
            iCalleNombre = pCalleNombre;
            iNumero = pNumero;
            iCiudad = pCiudad;
        }

        public Domicilio(String pCalleNombre, int pNumero, int pPiso, string pDepto, Ciudad pCiudad)
        {

            iCalleNombre = pCalleNombre;
            iNumero = pNumero;
            iPiso = pPiso;
            iDepto = pDepto;
            iCiudad = pCiudad;
        }

        public String calleNombre
        {
            set { iCalleNombre = value; }
            get { return this.iCalleNombre; }
        }

        public int numero
        {
            set { iNumero = value; }
            get { return this.iNumero; }
        }

        public int piso
        {
            set { iPiso = value; }
            get { return this.iPiso; }
        }

        public string depto {
            set { iDepto = value; }
            get { return iDepto; }
        }
    }
}
