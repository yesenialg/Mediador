using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.ManejoCache
{
    public class Cache
    {
        private static Cache instance;

        private Dictionary<string, string> cache = new Dictionary<string, string>();

        private Cache() 
        {
            cache = new Dictionary<string, string>();
        }

        public static Cache getInstance()
        {
            if(instance == null)
            {
                instance = new Cache();
            }
            return instance;
        }

        public void Add(string key, string value)
        {
            cache.Add(key, value);
        }

        public string Get(string key)
        {
            string value;
            cache.TryGetValue(key, out value);
            return value;
        }
    }
}
