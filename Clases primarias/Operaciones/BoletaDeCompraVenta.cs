using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias.Operaciones
{
    class BoletaDeCompraVenta
    {
        private string iDescripcion;
        private int iReciboNro;

        public BoletaDeCompraVenta(string pDescripcion)
        {
            iDescripcion = pDescripcion;
        }

        public int reciboNro {
            get { return iReciboNro; }
        }

        public string descripcion {
            set { iDescripcion = value; }
            get { return iDescripcion; }
        }
    }
}
