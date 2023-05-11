using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.SaneoDatos
{
    public class ValidatorCodigo : IValidador
    {
        public bool validar(string datoValidar)
        {
            if(datoValidar.Equals("1") || datoValidar.Equals("2") || datoValidar.Equals("3"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
