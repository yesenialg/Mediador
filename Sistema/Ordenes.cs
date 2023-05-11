using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    public class Ordenes
    {
        public string procesarOrdenes(Dictionary<string, string> data)
        {
            var response = "orden procesada con el codigo: " + data["codigo"];
            Console.WriteLine(response);
            return response;
        }
    }
}
