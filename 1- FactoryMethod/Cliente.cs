
using _1__FactoryMethod.Enums;

namespace _1__FactoryMethod
{
    public class Cliente
    {
        public void ExecutarCriacaoServico()
        {
            var servico = new Servico();
            var continuar = true;
            while (continuar)
            {

                Console.WriteLine("Selecione o tipo de serviço:\n");
                Console.WriteLine("0 - Tradicional");
                Console.WriteLine("1 - Premium");
                Console.WriteLine("2 - Master");
                Console.WriteLine("3 - Cobertura");
                
                Console.Write("Digite o numero do serviço que deseja cobrar: ");
                int tipoServico = Convert.ToInt16(Console.ReadLine());
                servico.FabricarServico((eTiposServicos)tipoServico);


                Console.Write("Deseja calcular outro serviço? (1 - Sim ou 2 - Não) ");
                int resposta = Convert.ToInt16(Console.ReadLine());


                continuar = resposta == 1;
            }
        }
    }
}
