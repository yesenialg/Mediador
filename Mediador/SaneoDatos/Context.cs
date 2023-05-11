using Mediador.SaneoDatos.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.SaneoDatos
{
    public class Context
    {
        public IValidador validador;

        public void setValidador(IValidador validador) 
        {
            this.validador = validador;
        }

        public bool validarData(string datoValidar) 
        {
            return validador.validar(datoValidar);
        }
    }
}
