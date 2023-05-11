using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.Filtrado
{
    public interface IFiltrarSolicitudes
    {
        public bool procesarSolicitud(Dictionary<string, string> data, string ip);
    }
}
