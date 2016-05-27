using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias
{
    abstract class Inmueble
    {
        private bool iAguaPotable;
        private bool iElectricidad;
        private bool iGas;
        private string Observaciones;
        private bool iDisponible;
        private string estadoI;
        private Cliente iDueño;
        private Domicilio iDir;

        public Inmueble() { }
        public Inmueble(Cliente pDueño, Domicilio pDir, bool pAguaPotable, bool pElectricidad, bool pGas, bool pDisponible, string pObs, string pEstado)
        {
            this.iDueño = pDueño;
            this.iDir = pDir;
            this.iAguaPotable = pAguaPotable;
            this.iElectricidad = pElectricidad;
            this.iGas = pGas;
            this.iDisponible = pDisponible;
            this.Observaciones = pObs;
            this.estadoI = pEstado;
        }

        public bool aguaPotable
        {
            /// set { iAguaPotable = value; }
            get { return this.aguaPotable; }
        }

        public bool electricidad
        {
            get { return this.iElectricidad; }
        }

        public bool gas
        {
            get { return this.iGas; }
        }

        public bool disponible
        {
            get { return this.iDisponible; }
        }

        public string observacion
        {
            get { return this.Observaciones; }
        }

        public string estado
        {
            get { return this.estadoI; }
        }

        internal static void AgregarInmueble(Inmueble pInmueble)
        {
            ///
        }

        static void BajaInmueble(Inmueble pInmueble)
        {

        }
    }
}
