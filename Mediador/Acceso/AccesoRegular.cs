using Mediador.Acceso.Contracts;
using Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.Acceso
{
    public class AccesoRegular : IAcceso
    {
        private readonly Ordenes _ordenes;

        public AccesoRegular()
        {
            _ordenes = new Ordenes();
        }

        public void autenticar()
        {
            Console.WriteLine("Autenticación exitosa para usuario REGULAR");
        }

        public string ingresoSistema(Dictionary<string, string> data)
        {
            return _ordenes.procesarOrdenes(data);
        }
    }
}
