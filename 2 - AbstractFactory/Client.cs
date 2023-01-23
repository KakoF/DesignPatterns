using _2___AbstractFactory.AbstractFactory.ParteCriacao.Factories;
using _2___AbstractFactory.AbstractFactory.ParteCriacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___AbstractFactory
{
    public class Client
    {
        public void ConsultarRotinaAluno()
        {
            var continuar = true;
            while (continuar)
            {
                IFactory? fatory = null;
                Console.WriteLine("Selecione a rotina desejada:\n");
                Console.WriteLine("1 - Segunda e Quarta");
                Console.WriteLine("2 - Tarça e Quinta");
                Console.WriteLine("3 - Quarta e Sabado");

                Console.Write("Digite o numero da rotina: ");
                int rotina = Convert.ToInt16(Console.ReadLine());
                switch (rotina)
                {
                    case 1:
                        fatory = new SegundaQuintaFactory();
                        break;
                    case 2:
                        fatory = new TerceSextaFactory();
                        break;
                    case 3:
                        fatory = new QuartaSabadoFactory();
                        break;

                    default:
                        break;
                }


                Console.Write("Deseja calcular outro serviço? (1 - Sim ou 2 - Não) ");
                int resposta = Convert.ToInt16(Console.ReadLine());


                continuar = resposta == 1;
            }
        }
    }
}
