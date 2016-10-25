using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias
{
    class Contrato
    {
        private int id;
        private DateTime iFecha;
        private DateTime iFechaFin;
        private Cliente iLocatario;
        private Cliente iLocador;
        private Inmueble iInmueble;

        public Contrato(DateTime pFecha, DateTime pFechaFin, Cliente pLocatario, Cliente pLocador, Inmueble pInmueble) {
            iFecha = pFecha;
            iFechaFin = pFechaFin;
            iLocatario = pLocatario;
            iLocador = pLocador;
            iInmueble = pInmueble;
        }

        public DateTime fecha {
            set { iFecha = value; }
            get { return iFecha; } 
        }

        public DateTime fechaFin {
            set { iFechaFin = value; }
            get { return iFechaFin; }
        }
    }
}
