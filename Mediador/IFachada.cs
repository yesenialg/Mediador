using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador
{
    public interface IFachada
    {
        public string enviarSolicitud(string ip, string tipo_usuario, Dictionary<string, string> data);
    }
}
