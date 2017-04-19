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
        private string iRazonSocial;
        private int iIdCliente;
        private int iTelefono;
        private int iDNI;
        private string iEmail;
        private int iCodigoPostal;
        private Domicilio iDomicilio;
        //dirección, Cuit, 

        public Cliente() { }

        public Cliente(string pNombre, string pApellido, string pRazonSocial, int pDNI, int pTelefono, string pEmail, int pCodigoPostal, Domicilio pDomicilio)
        {
            ///Falta idCliente generado automaticamente. "holasww"
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iRazonSocial = pRazonSocial;
            this.iDNI = pDNI;
            this.iTelefono = pTelefono;
            this.iEmail = pEmail;
            this.iCodigoPostal = pCodigoPostal;
        }

        public int idCliente
        {
            
            get { return this.iIdCliente; }
        }

        public string nombre
        {
            set { iNombre = value; }
            get { return this.iNombre; }
        }

        public string apellido
        {
            get { return this.iApellido; }
        }

        public string razonSocial
        {
            get { return this.iRazonSocial; }
        }

        public int dni
        {
            get { return this.iDNI; }
        }

        public string email
        {
            get { return this.iEmail; }
        }

        public int codigoPostal
        {
            get { return this.iCodigoPostal; }
        }

        public int telefono
        {
            get { return this.iTelefono; }
        }
        
          
    }
}
