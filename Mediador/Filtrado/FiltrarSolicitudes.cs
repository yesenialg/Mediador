using Mediador.ManejoCache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.Filtrado
{
    public class FiltrarSolicitudes : IFiltrarSolicitudes
    {
        private Solicitudes solicitudes;

        public FiltrarSolicitudes()
        {
            this.solicitudes = Solicitudes.getInstance();
        }
        public bool procesarSolicitud(Dictionary<string, string> data, string ip)
        {
            return solicitudes.procesarSolicitud(data, ip);
        }
    }
}
