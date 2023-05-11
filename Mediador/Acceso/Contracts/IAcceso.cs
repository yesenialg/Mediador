using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.Acceso.Contracts
{
    public interface IAcceso
    {
        public void autenticar();

        public string ingresoSistema(Dictionary<string, string> data);
    }
}
