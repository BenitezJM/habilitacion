using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias
{
    class Domicilio  ///MODIFICAR A COMO ESTA EN EL DIAGRAMA DE CLASES, ESTA VERSION ES VIEJA.
    {
        private String iCalleNombre;
        private int iNumero;
        private int iIdDomicilio;

        public Domicilio() {}

        public Domicilio(String pCalleNombre, int pNumero, int pIdDomicilio)
        {

            this.iCalleNombre = pCalleNombre;
            this.iNumero = pNumero;
            this.iIdDomicilio = pIdDomicilio;
        }

        public String calleNombre
        {            
            get { return this.iCalleNombre; }
        }

        public int numero
        {
            get { return this.iNumero; }
        }

        public int domicilio
        {
            get { return this.iIdDomicilio; }
        }
    }

}
