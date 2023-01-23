using _2___AbstractFactory.AbstractFactory.ParteCriacao.Interfaces;
using _2___AbstractFactory.AbstractFactory.ParteProduto.Produtos;

namespace _2___AbstractFactory.AbstractFactory.ParteCriacao.Factories
{
    public class SegundaQuintaFactory : IFactory
    {
        public SegundaQuintaFactory()
        {
            this.ObterRotinaDiaria();
        }
        public void ObterRotinaDiaria()
        {
            Console.WriteLine("Factory Segunda e Quinta criada");
            DietaSegundaQuinta dieta = new DietaSegundaQuinta();
            TreinoSegundaQuinta treino = new TreinoSegundaQuinta();

            dieta.ObterAlimentacao();
            treino.ObterTreino();
        }
    }
}
