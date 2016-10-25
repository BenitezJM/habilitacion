using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias
{
    public abstract class Inmueble
    {

        public int iId;
        public bool iAguaPotable;
        public bool iElectricidad;
        public bool iGas;
        public string iObservaciones;
        public bool iDisponible;
        public string iEstadoI;
        private Domicilio iDir;

        public int id {
            set { iId = value; }
            get { return iId; }
        }

        
        public bool aguaPotable {
            set { iAguaPotable = value; }
            get { return iAguaPotable; }
        }

        public bool electricidad
        {
            set { iElectricidad = value; }
            get { return iElectricidad; }
        }

        public bool gas
        {
            set { iGas = value; }
            get { return iGas; }
        }

        public string observaciones
        {
            set { iObservaciones = value; }
            get { return iObservaciones; }
        }

        public bool disponible
        {
            set { iDisponible = value; }
            get { return iDisponible; }
        }

        public string estadoI
        {
            set { iEstadoI = value; }
            get { return iEstadoI; }
        }


    }
}
