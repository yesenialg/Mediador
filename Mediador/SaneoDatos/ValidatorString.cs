using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.SaneoDatos
{
    public class ValidatorString : IValidador
    {
        public bool validar(string datoValidar)
        {
            if(datoValidar.Length < 10)
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
