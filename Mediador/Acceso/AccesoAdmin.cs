using Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.Acceso
{
    public class AccesoAdmin : IAcceso
    {
        private readonly Ordenes _ordenes;
        private readonly PartesSistema _sistema;

        public AccesoAdmin()
        {
            _ordenes = new Ordenes();
            _sistema = new PartesSistema(_ordenes);
        }

        public void autenticar()
        {
            Console.WriteLine("Autenticación exitosa para usuario ADMIN");
        }

        public string ingresoSistema(Dictionary<string, string> data)
        {
            return _sistema.solicitudSistema(data);
        }
    }
}
