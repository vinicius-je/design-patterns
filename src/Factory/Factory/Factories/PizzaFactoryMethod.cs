using Factory.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Factories
{
    public abstract class PizzaFactoryMethod
    {
        public Pizza MontarPizza(string tipo)
        {
            Pizza pizza;
            pizza = CriarPizza(tipo);
            return pizza;
        }

        protected abstract Pizza CriarPizza(string tipo);
    }
}
