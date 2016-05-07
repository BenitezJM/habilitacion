using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias
{
    class Fachada
    {
        public void agregarInmueble(Inmueble pInmueble)
        {
            Inmueble unInmueble = new Inmueble();
            Inmueble.AgregarInmueble(unInmueble);
        }
    }
}
