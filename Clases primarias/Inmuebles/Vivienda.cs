using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias
{
    class Vivienda: Inmueble{

        private int iHabitaciones;
        private int iBanio;
        private bool iPatio;
        private bool iGarage;
        private bool iSotano;
        private bool iCloaca;
        private bool iPavimento;
        private int iPiso;
        private bool iEnConstruccion;
        
        public Vivienda() { }
        public Vivienda(int pHabitaciones, int pBanio, bool pPatio, bool pGarage, 
                bool pSotano,bool pCloaca, bool pPavimento, int pPiso, bool pEnConstruccion,
                int pId, bool pAguaPotable, bool pElectricidad, bool pGas, string  pObservaciones,
                bool pDisponible, string pEstadoI)
        {
            iHabitaciones = pHabitaciones;
            iBanio = pBanio;
            iPatio = pPatio;
            iGarage = pGarage;
            iSotano = pSotano;
            iCloaca = pCloaca;
            iPavimento = pPavimento;
            iPiso = pPiso;
            iEnConstruccion = pEnConstruccion;
            iId = pId;
            iAguaPotable = pAguaPotable;
            iElectricidad = pElectricidad;
            iGas = pGas;
            iObservaciones = pObservaciones;
            iDisponible = pDisponible;
            iEstadoI = pEstadoI;
        }
        public int habitaciones
        {
            set { value = iHabitaciones; }
            get { return this.iHabitaciones; }
        }

        public int banio
        {
            set { iBanio = value; }
            get { return iBanio; }
        }

        public bool patio
        {
            set { iPatio = value; }
            get { return this.iPatio; }
        }

        public bool garage
        {
            set { iGarage = value; }
            get { return this.iGarage; }
        }

        public bool sotano
        {
            set { iPatio = value; }
            get { return this.iPatio; }
        }

        public bool cloaca
        {
            set { iCloaca = value; }
            get { return this.iCloaca; }
        }

        public bool pavimento
        {
            set { iPavimento = value; }
            get { return this.iPavimento; }
        }

        public int piso
        {
            set { iPiso = value; }
            get { return this.iPiso; }
        }

        public bool enConstruccion
        {
            set { iEnConstruccion = value; }
            get { return this.iEnConstruccion; }
        }
    }
}
