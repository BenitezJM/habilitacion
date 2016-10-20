using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias
{
    class Comercio : Inmueble
    {
        private string iDescripcion;
        private bool iPavimento;
        private int iPlanta;

        public Comercio() { }
        public Comercio(string pDescripcion, bool pPavimento, int pPlanta, int pId, bool pAguaPotable, bool pElectricidad,
                     bool pGas, string pObservaciones, bool pDisponible, string pEstadoI)
        {
            iDescripcion = pDescripcion;
            iPavimento = pPavimento;
            iPlanta = pPlanta;     
            id = pId;
            aguaPotable = pAguaPotable;
            electricidad = pElectricidad;
            gas = pGas;
            observaciones = pObservaciones;
            disponible = pDisponible;
            estadoI = pEstadoI;
        }

        public string descripcion {
            get { return this.iDescripcion; }
            set { iDescripcion = value; }
        }

        public bool pavimento
        {
            get { return this.iPavimento; }
            set { iPavimento = value; }
        }

        public int planta
        {
            get { return this.iPlanta; }
            set { iPlanta = value; }
        }
    }
}
