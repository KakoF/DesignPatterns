using _2___AbstractFactory.AbstractFactory.ParteCriacao.Interfaces;
using _2___AbstractFactory.AbstractFactory.ParteProduto.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___AbstractFactory.AbstractFactory.ParteCriacao.Factories
{
    public class QuartaSabadoFactory : IFactory
    {
        public QuartaSabadoFactory()
        {
            this.ObterRotinaDiaria();
        }
        public void ObterRotinaDiaria()
        {
            Console.WriteLine("Factory Quarta e Sabado criada");
            DietaQuartaSabado dieta = new DietaQuartaSabado();
            TreinoQuartaSabado treino = new TreinoQuartaSabado();

            dieta.ObterAlimentacao();
            treino.ObterTreino();
        }
    }
}
