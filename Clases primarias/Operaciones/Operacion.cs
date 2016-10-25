using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias
{
    class Operacion ///Ver si esta bien esta clase.
    {
        private DateTime ifechaOP;
        private string iObservacion;

        public Operacion() {            
        }

        public DateTime fechaOP {
            set { ifechaOP = value; }
            get { return ifechaOP; }
        }

        public string observacion {
            set { iObservacion = value; }
            get { return iObservacion; }
        }
    }
}
