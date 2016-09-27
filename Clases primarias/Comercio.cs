using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias
{
    class Comercio: Inmueble
    {
        public Comercio() { }

        public override int id { get; set; }

        public override bool aguaPotable { get; set; }

        public override bool electricidad { get; set; }

        public override bool gas { get; set; }

        public override string observaciones { get; set; }

        public override bool disponible { get; set; }

        public override string estadoI { get; set; }
    }
}
