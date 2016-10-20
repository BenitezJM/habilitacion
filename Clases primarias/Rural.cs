using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias
{
    class Rural : Inmueble
    {
        private float iCantidadHectareas;
        private bool iRio;
        private bool iArroyo;
        private bool iMonte;
        private bool iSembrado;
        private bool iMolino;
        private bool iVivienda; 

        public Rural(float pCantidadHs, bool pRio, bool pArroyo, bool pMonte, bool pSembrado,
                     bool pMolino, bool pVivienda, int pId, bool pAguaPotable, bool pElectricidad,
                     bool pGas, string pObservaciones, bool pDisponible, string pEstadoI)
        {
            iCantidadHectareas = pCantidadHs;
            iRio = pRio;
            iArroyo = pArroyo;
            iMonte = pMonte;
            iSembrado = pSembrado;
            iMolino = pMolino;
            iVivienda = pVivienda;
            id = pId;
            aguaPotable = pAguaPotable;
            electricidad = pElectricidad;
            gas = pGas;
            observaciones = pObservaciones;
            disponible = pDisponible;
            estadoI = pEstadoI;
        }

        public float cantidadHectareas {
            set { iCantidadHectareas = value; }
            get { return iCantidadHectareas; }
        }

        public bool rio
        {
            set { iRio = value; }
            get { return iRio; }
        }

        public bool arroyo
        {
            set { iArroyo = value; }
            get { return iArroyo; }
        }

        public bool monte
        {
            set { iMonte = value; }
            get { return iMonte; }
        }

        public bool sembrado
        {
            set { iSembrado = value; }
            get { return iSembrado; }
        }

        public bool molino
        {
            set { iMolino = value; }
            get { return iMolino; }
        }

        public bool vivienda
        {
            set { iVivienda = value; }
            get { return iVivienda; }
        }
    }
}
