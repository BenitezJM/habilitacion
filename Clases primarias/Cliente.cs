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

        public string Nombre
        {
            get { return this.iNombre; }
        }

        public string Apellido
        {
            get { return this.iApellido; }
        }

        public string RazonSocial
        {
            get { return this.iRazonSocial; }
        }

        public int DNI
        {
            get { return this.iDNI; }
        }

        public string Email
        {
            get { return this.iEmail; }
        }

        public int CodigoPostal
        {
            get { return this.iCodigoPostal; }
        }

        public int Telefono
        {
            get { return this.iTelefono; }
        }
    }
}
