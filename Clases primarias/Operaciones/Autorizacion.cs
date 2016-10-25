using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias
{
    class Autorizacion
    {
        private int iIdAutorizacion;
        private string iTipo;
        private bool iEstadoA;
        private DateTime iFechaAu;

        public Autorizacion(string pTipo, bool pEstadoA,DateTime pFechaAu) {
            ///id agregado automaticamente.
            iTipo = pTipo;
            iEstadoA = pEstadoA;
            iFechaAu = pFechaAu;
        }

        public string tipo {
            set { iTipo = value; }
            get { return iTipo; }
        }

        public bool estadoA {
            set { iEstadoA = value; }
            get { return iEstadoA; }
        }

        public DateTime fechaAu {
            set { iFechaAu = value; }
            get { return iFechaAu; }
        }
    }
}
