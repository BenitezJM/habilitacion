using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias
{
    class Visita
    {
        private int iIdVisita;
        private DateTime iFecha;
        private int iHora;
        private int iDuracionAproximada;
        private Cliente iVisitante;

        public Visita() { }

        public Visita(int pIdVisita, DateTime pFecha, int pHora, int pDuracionAproximada, Cliente pVisitante)
        {

            this.iIdVisita = pIdVisita;
            this.iFecha = pFecha;
            this.iHora = pHora;
            this.iDuracionAproximada = pDuracionAproximada;
            this.iVisitante = pVisitante;
        }

        public int idVisita
        {
            get { return this.iIdVisita; }
        }

        public DateTime fecha
        {
            get { return this.iFecha; }
        }

        public int hora
        {
            get { return this.iHora; }
        }
        public int duracionAproxiada
        {
            get { return this.iDuracionAproximada; }
        }

        public Cliente visitante
        {
            get { return this.iVisitante; }
        }

    }
}

