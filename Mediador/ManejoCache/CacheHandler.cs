using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.ManejoCache
{
    public class CacheHandler : ICacheHandler
    {
        private Cache cache;

        public CacheHandler()
        {
            this.cache = Cache.getInstance();
        }

        public string? getResponse(string codigo)
        {
            Console.WriteLine("Get en cache");
            return cache.Get(codigo);
        }

        public void postResponse(string codigo, string value)
        {
            Console.WriteLine("Post en cache");
            cache.Add(codigo, value);
        }
    }
}
