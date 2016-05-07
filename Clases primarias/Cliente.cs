using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias
{
    class Cliente : Persona
    {
        private int iIdCliente;
        private int iTelefono;

        public Cliente(string nombre, string apellido, int pDNI, int telefono) : base (nombre, apellido, pDNI) {
            ///Falta idCliente generado automaticamente. 
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = pDNI;
            this.iTelefono = telefono;
        }

        public int idCliente {
            get { return this.iIdCliente; }
        }

        public int Telefono {
            get { return iTelefono;}
        }
    }
}
