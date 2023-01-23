using _2___AbstractFactory.AbstractFactory.ParteCriacao.Interfaces;
using _2___AbstractFactory.AbstractFactory.ParteProduto.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___AbstractFactory.AbstractFactory.ParteCriacao.Factories
{
    public class TerceSextaFactory : IFactory
    {
        public TerceSextaFactory()
        {
            this.ObterRotinaDiaria();
        }
        public void ObterRotinaDiaria()
        {
            Console.WriteLine("Factory Terça e Sexta criada");
            DietaTercaSexta dieta = new DietaTercaSexta();
            TreinoTercaSexta treino = new TreinoTercaSexta();

            dieta.ObterAlimentacao();
            treino.ObterTreino();
        }
    }
}
