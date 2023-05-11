using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.ManejoCache
{
    public interface ICacheHandler
    {
        public string? getResponse(string codigo);

        public void postResponse(string codigo, string value);
    }
}
