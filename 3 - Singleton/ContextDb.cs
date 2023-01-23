using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___Singleton
{
    public class ContextDb
    {
        private static ContextDb _instancia = null;
        private ContextDb()
        {

        }

        public static ContextDb Instancia
        {
            get
            {
                if(_instancia == null)
                {
                    _instancia = new ContextDb();
                    Console.WriteLine("Instancia ContextDb criada");
                }
                return _instancia;
            }
        }

        public void ExecutarQuery(string query)
        {
            Console.WriteLine($"Executou a query: {query}");
        }
    }
}
