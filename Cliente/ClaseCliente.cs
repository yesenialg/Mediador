using Mediador.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    public class ClaseCliente
    {
        private string tipo_usuario {  get; set; }

        private string usuario { get; set; }

        private string password { get; set; }

        private readonly IFachada _fachada;


        public ClaseCliente(string tipo_usuario, string usuario, string password, IFachada fachada)
        {
            this.tipo_usuario = tipo_usuario;
            this.usuario = usuario;
            this.password = password;
            _fachada = fachada;
        }

        public void ordenEnLinea(Dictionary<string, string> data) 
        {
            _fachada.enviarSolicitud(tipo_usuario, data);
        }
    }
}
