using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    public abstract class TipoTarifa
    {
        private decimal kilos;
        private decimal distancia;

        public abstract decimal coste();
    }
}
