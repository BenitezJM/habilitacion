using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias
{
    class Terreno : Inmueble
    {
        private int iMetrosCuadrados;
        private bool iCloaca;

        public Terreno(int pMetrosCuadrados, bool pCloaca, int pId, 
            bool pAguaPotable, bool pElectricidad, bool pGas, 
            string pObservaciones, bool pDisponible, string pEstadoI) {
            iMetrosCuadrados = pMetrosCuadrados;
            iCloaca = pCloaca;
            id = pId;
            aguaPotable = pAguaPotable;
            electricidad = pElectricidad;
            gas = pGas;
            observaciones = pObservaciones;
            disponible = pDisponible;
            estadoI = pEstadoI;
        }

        public int metrosCuadrados {
            set { iMetrosCuadrados = value; }
            get { return iMetrosCuadrados; }
        }

        public bool Cloaca {
            set { iCloaca = value; }
            get { return iCloaca; }
        }

    }
}
