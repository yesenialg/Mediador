using Mediador.Acceso;
using Mediador.Filtrado;
using Mediador.ManejoCache;
using Mediador.SaneoDatos;
using Sistema;

namespace Mediador
{
    public class Fachada : IFachada
    {
        private readonly IFiltrarSolicitudes _filter;
        private readonly ICacheHandler _cache;

        public Fachada(IFiltrarSolicitudes filter, ICacheHandler cache) 
        { 
            _filter = filter;
            _cache = cache;
        }
        public string enviarSolicitud(string ip, string tipo_usuario, Dictionary<string, string> data)
        {
            IAcceso acceso = CrearAcceso(tipo_usuario);
            if(acceso == null)
            {
                Console.WriteLine("Acceso denegado");
                return "Acceso denegado";
            }

            bool datosSaneados = SanearDatos(data);
            if(!datosSaneados) 
            {
                Console.WriteLine("String y/o Codigo invalidos");
                return "String y/o Codigo invalidos";
            }

            bool filtrarSolicitudes = FiltrarSolicitudes(data, ip);
            if (!filtrarSolicitudes)
            {
                Console.WriteLine("La ip está bloqueada");
                return "La ip está bloqueada";
            }

            return BusquedaResponse(data, acceso);
        }

        public IAcceso CrearAcceso(string tipo_usuario)
        {
            CreacionAcceso crearAcceso = new CreacionAcceso(tipo_usuario);

            IAcceso? acceso = crearAcceso.Crear();

            return acceso;
        }

        public bool SanearDatos(Dictionary<string, string> data)
        {
            Context context = new Context();

            context.setValidador("codigo");
            var codigoValido = context.validarData(data["codigo"]);

            context.setValidador("string");
            var stringValido = context.validarData(data["string"]);

            return codigoValido && stringValido;
        }

        public bool FiltrarSolicitudes(Dictionary<string, string> data, string ip)
        {
            return _filter.procesarSolicitud(data, ip);
        }

        public string BusquedaResponse(Dictionary<string, string> data, IAcceso acceso)
        {
            var response = _cache.getResponse(data["codigo"]);
            if (response != null)
            {
                return response;
            }
            else
            {
                response = acceso.ingresoSistema(data);
                _cache.postResponse(data["codigo"], response);
                return response;
            }
        }
    }
}
