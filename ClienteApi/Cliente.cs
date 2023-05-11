using Mediador.Contracts;

namespace ClienteApi
{
    public class Cliente
    {
        public string tipo_usuario { get; set; }

        private string usuario { get; set; }

        private string password { get; set; }

        private readonly IFachada _fachada;


        public Cliente(string tipo_usuario, string usuario, string password, IFachada fachada)
        {
            this.tipo_usuario = tipo_usuario;
            this.usuario = usuario;
            this.password = password;
            _fachada = fachada;
        }
        public string ordenEnLinea(Dictionary<string, string> data)
        {
            return _fachada.enviarSolicitud(tipo_usuario, data);
        }
    }
}
