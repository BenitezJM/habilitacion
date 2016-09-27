using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_primarias
{
    class Rural: Inmueble
    {

        public Rural(float pCantidadHs, bool pRio, bool pArroyo, bool pMonto, bool pSembrando,
                     bool pMolino, bool pVivienda, int pId, bool pAguaPotable, bool pElectricidad,
                     bool pGas, string pObservaciones, bool pDisponible, string pEstadoI )
        {
            cantidadHectareas = pCantidadHs;
            rio = pRio;
            arroyo = pArroyo;
            monte = pMonto;
            sembrado = pSembrando;
            molino = pMolino;
            vivienda = pVivienda;
            id = pId;
            aguaPotable = pAguaPotable;
            electricidad = pElectricidad;
            gas = pGas;
            observaciones = pObservaciones;
            disponible = pDisponible;
            estadoI = pEstadoI;
        }

        public float cantidadHectareas { get; set; }

        public bool rio { get; set; }

        public bool arroyo { get; set; }

        public bool monte { get; set; }

        public bool sembrado { get; set; }

        public bool molino { get; set; }

        public bool vivienda { get; set; }

        public override int id { get; set; }

        public override bool aguaPotable { get; set; }

        public override bool electricidad { get; set; }

        public override bool gas { get; set; }

        public override string observaciones { get; set; }

        public override bool disponible { get; set; }

        public override string estadoI { get; set; }
    }
}
