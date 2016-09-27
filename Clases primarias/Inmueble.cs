using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias
{
    public abstract class Inmueble
    {

         private bool iAguaPotable;
         private bool iElectricidad;
         private bool iGas;
         private string Observaciones;
         private bool iDisponible;
         private string iestadoI;
         private Cliente iDueño;
         private Domicilio iDir;

        public abstract int id { get; set; }

        public abstract Boolean aguaPotable { get; set; }

        public abstract Boolean electricidad { get; set; }

        public abstract Boolean gas { get; set; }

        public abstract string observaciones { get; set; }

        public abstract Boolean disponible { get; set; }

        public abstract string estadoI { get; set; }
                                         
    }
}
