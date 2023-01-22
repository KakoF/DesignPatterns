using _1__FactoryMethod.Interfaces;

namespace _1__FactoryMethod.Servicos
{
    public class PremiumServico: IServico
    {
        public PremiumServico()
        {
            Console.WriteLine("PremiumServico criado com sucesso");
        }
        public void ExecutaCobrancaServico()
        {
            //Logica de cobrança de serviços para premium
        }
    }
}
