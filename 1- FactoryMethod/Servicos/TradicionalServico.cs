
using _1__FactoryMethod.Interfaces;

namespace _1__FactoryMethod.Servicos
{
    public class TradicionalServico: IServico
    {
        public TradicionalServico()
        {
            Console.WriteLine("TradicionalServico criado com sucesso");
        }
        public void ExecutaCobrancaServico()
        {
            //Logica de cobrança de serviços para tradicional
        }
    }
}
