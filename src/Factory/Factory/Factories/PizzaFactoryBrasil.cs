using Factory.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factories
{
    public class PizzaFactoryBrasil : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            if (tipo.Equals("C"))
            {
                return new PizzaBrasileriaCalabresa();
            }

            if (tipo.Equals("M"))
            {
                return new PizzaBrasileriaMussarela();
            }

            return null;
        }
    }
}
