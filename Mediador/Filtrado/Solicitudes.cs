using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.Filtrado
{
    public class Solicitudes
    {
        private static Solicitudes instance;

        private HashSet<string> _ipFallidas;

        private Solicitudes()
        {
            _ipFallidas = new HashSet<string>();
        }

        public static Solicitudes getInstance()
        {
            if (instance == null)
            {
                instance = new Solicitudes();
            }
            return instance;
        }
        public bool procesarSolicitud(Dictionary<string, string> data, string ip)
        {
            if (_ipFallidas.Contains(ip))
            {
                Console.WriteLine("La ip se encuentra en la lista de fallidas");
                return false;
            }

            bool resultado = VerificarSolicitud(data, ip);

            if (!resultado)
            {
                _ipFallidas.Add(ip);
                Console.WriteLine("La ip está siendo bloqueada...");
            }

            return resultado;
        }

        public bool VerificarSolicitud(Dictionary<string, string> data, string ip)
        {
            if (ip.Contains("222"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
