using _1__FactoryMethod.Enums;
using _1__FactoryMethod.Interfaces;
using _1__FactoryMethod.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__FactoryMethod
{
    public class Servico : ServicoFactory
    {
        public override IServico? FabricarServico(eTiposServicos tiposServicos)
        {
            switch (tiposServicos)
            {
                case eTiposServicos.tradicional:
                    return new TradicionalServico();
                case eTiposServicos.premium:
                    return new PremiumServico();
                case eTiposServicos.master:
                    return new MasterServico();
                case eTiposServicos.cobertura:
                    return new CoberturaServico();
                default:
                    return null;
            }
        }
    }
}
