using Factory.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factories
{
    public class PizzaFactoryItalia : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            if (tipo.Equals("C"))
            {
                return new PizzaItalianaCalabresa();
            }

            if (tipo.Equals("M"))
            {
                return new PizzaItalianaMussarela();
            }

            return null;
        }
    }
}
