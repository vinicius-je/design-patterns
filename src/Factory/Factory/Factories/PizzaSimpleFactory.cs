using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factories
{
    public static class PizzaSimpleFactory
    {
        public static PizzaFactoryMethod CriarPizzaria(string local)
        {
            PizzaFactoryMethod pizzaria;

            switch (local)
            {
                case "B":
                    pizzaria = new PizzaFactoryBrasil();
                    break;
                case "I":
                    pizzaria = new PizzaFactoryItalia();
                    break;
                default:
                    throw new ApplicationException("Local de pizzaria desconhecido!");
            }

            return pizzaria;
        }
    }
}
