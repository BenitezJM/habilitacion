using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias
{
    public class Persona
    {
        private string iNombre;
        private string iApellido;
        private int iDNI;

        public Persona(string nombre, string apellido, int DNI){
            this.iNombre = nombre;
            this.iApellido = apellido;
            this.iDNI = DNI;
        }

        public string Nombre {
            set { iNombre = value; }
            get { return iNombre; }
        }

        public string Apellido {
            set { iApellido = value; }
            get { return iApellido; }
        }

        public int DNI {
            set { iDNI = value; }
            get { return iDNI; }
        }
    }
}
