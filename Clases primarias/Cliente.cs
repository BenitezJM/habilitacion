using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias
{
    class Cliente 
    {
        private string iNombre;
        private string iApellido;
        private int iIdCliente;
        private int iTelefono;
        private int iDNI;

        public Cliente(string pNombre, string pApellido, int pDNI, int pTelefono) { 
            ///Falta idCliente generado automaticamente. "holasww"
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iDNI = pDNI;
            this.iTelefono = pTelefono;
        }

        public int idCliente {
            get { return this.iIdCliente; }
        }

        public int Telefono {
            get { return iTelefono;}
        }
    }
}
