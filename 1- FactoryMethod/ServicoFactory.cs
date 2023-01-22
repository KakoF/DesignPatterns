using _1__FactoryMethod.Enums;
using _1__FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__FactoryMethod
{
    public abstract class ServicoFactory
    {
        public abstract IServico? FabricarServico(eTiposServicos tiposServicos);
    }
}
