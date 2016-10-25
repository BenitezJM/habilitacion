using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias
{
    class Venta : Operacion
    {
        private int id;
        private DateTime iFecha;
        private string iDescripcion;
        private Cliente iCliente;
        private Inmueble iInmueble;

        public Venta(Cliente pCliente, Inmueble pInmueble, DateTime pFecha, string pDescripcion) {
            iCliente = pCliente;
            iInmueble = pInmueble;
            iFecha = pFecha;
            iDescripcion = pDescripcion;
        }
    }
}
