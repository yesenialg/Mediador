using Mediador.Acceso;
using Mediador.Acceso.Contracts;
using Mediador.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace ClienteApi.Controllers
{
    [ApiController]
    [Route("Cliente")]
    public class ClienteController : ControllerBase
    {
        private readonly IFachada _fachada;
        public ClienteController(IFachada fachada) 
        {
            _fachada = fachada;
        }

        [HttpGet(Name = "GenerarUnaOrden")]
        public string Get(string tipo_usuario, string usuario, string password, string texto, string codigo)
        {

            Dictionary<string, string> data = new Dictionary<string, string>()
            {
                {"string", texto},
                {"codigo", codigo}
            };

            Cliente cliente1 = new Cliente(tipo_usuario, usuario, password, _fachada);

            return cliente1.ordenEnLinea(data);
        }
    }
}