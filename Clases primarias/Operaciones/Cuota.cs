using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias
{
    class Cuota
    {
        private int iCantidad;
        private int iMonto;
        private bool iPagada;
        private DateTime iFecha;
        private Contrato iContrato;

        public Cuota(int pCantidad, int pMonto, DateTime pFecha, Contrato pContrato) {
            iCantidad = pCantidad;
            iMonto = pMonto;
            iFecha = pFecha;
            iContrato = pContrato;
        }

        public int cantidad {
            set { iCantidad = value; }
            get { return iCantidad; }
        }

        public int monto {
            set { iMonto = value; }
            get { return iMonto; }
        }

        private DateTime fecha {
            set { iFecha = value; }
            get { return iFecha; }
        }
    }
}
