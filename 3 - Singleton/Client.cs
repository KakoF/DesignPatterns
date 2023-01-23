using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___Singleton
{
    public class Client
    {

        public void ConsumirDb()
        {
            var instanciaDb = ContextDb.Instancia;
            instanciaDb.ExecutarQuery("select * from Tabela");

            instanciaDb = ContextDb.Instancia;
            instanciaDb.ExecutarQuery("insert into OutraTabela");
            
            instanciaDb = ContextDb.Instancia;
            instanciaDb.ExecutarQuery("update OutraTabela");
        }
    }
}
