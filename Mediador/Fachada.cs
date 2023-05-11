using Mediador.Acceso;
using Mediador.Acceso.Contracts;
using Mediador.Contracts;
using Mediador.SaneoDatos;
using Sistema;

namespace Mediador
{
    public class Fachada : IFachada
    {
        public string enviarSolicitud(string tipo_usuario, Dictionary<string, string> data)
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

            return acceso.ingresoSistema(data);
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

            context.setValidador(new ValidatorCodigo());
            var codigoValido = context.validarData(data["codigo"]);
            Console.WriteLine(codigoValido);

            context.setValidador(new ValidatorString());
            var stringValido = context.validarData(data["string"]);
            Console.WriteLine(stringValido);

            return codigoValido && stringValido;
        }
    }
}
