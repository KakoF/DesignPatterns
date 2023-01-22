using _1__FactoryMethod.Interfaces;

namespace _1__FactoryMethod.Servicos
{
    public class MasterServico: IServico
    {
        public MasterServico()
        {
            Console.WriteLine("MasterServico criado com sucesso");
        }
        public void ExecutaCobrancaServico()
        {
            //Logica de cobrança de serviços para master
        }
    }
}
