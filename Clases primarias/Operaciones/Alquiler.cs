using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias
{
    class Alquiler : Operacion
    {
        private int id;
        private DateTime iFechaIni;
        private string iDescripcion;

        public Alquiler (DateTime pFechaIni, string pDescripcion) {
            ///Agrega contador automatico para id de alquiler.
            iFechaIni = pFechaIni;
            iDescripcion = pDescripcion;
        }

        

    }
}
