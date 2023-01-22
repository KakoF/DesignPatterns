using _1__FactoryMethod.Interfaces;
namespace _1__FactoryMethod.Servicos
{
    public class CoberturaServico : IServico
    {
        public CoberturaServico()
        {
            Console.WriteLine("CoberturaServico criado com sucesso");
        }
        public void ExecutaCobrancaServico()
        {
            //Logica de cobrança de serviços para cobertura
        }
    }
}
