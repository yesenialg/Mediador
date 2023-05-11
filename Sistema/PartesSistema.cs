using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    public class PartesSistema
    {
        private readonly Ordenes _ordenes;

        public PartesSistema(Ordenes ordenes)
        {
            _ordenes = ordenes;
        }

        public string solicitudSistema(Dictionary<string, string> data)
        {
            Console.WriteLine("Ingresó al sistema");
            return _ordenes.procesarOrdenes(data);
        }
    }
}
