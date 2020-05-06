using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporte
{
    public class Transportista
    {
        private TipoTarifa tipoTarifa;

        public decimal costeEnvio() {
            return tipoTarifa.coste();
        }

        public TipoTarifa get_tipoEnvio() => this.tipoTarifa;
        public void set_tipoEnvio(TipoTarifa tipoEnvio) {
            this.tipoTarifa = tipoEnvio;
        }


    }
}
