using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.SaneoDatos
{
    public interface IValidador
    {
        public bool validar(string datoValidar);
    }
}
