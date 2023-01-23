using _2___AbstractFactory.AbstractFactory.ParteProduto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___AbstractFactory.AbstractFactory.ParteProduto.Produtos
{
    public class DietaQuartaSabado : IDieta
    {
        public DietaQuartaSabado()
        {
            this.ObterAlimentacao();
        }
        public void ObterAlimentacao()
        {
            Console.WriteLine("Dieta de Quarta e Sabado");
        }
    }
}
