using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public static class PizzaSimpleFactory
    {
        public static Pizza CriarPizza(string tipo)
        {
            Pizza pizza;

            switch (tipo)
            {
                case "C":
                    pizza = new PizzaCalabresa();
                    break;
                case "M":
                    pizza = new PizzaMussarela();
                    break;
                default:
                    throw new ApplicationException("Tipo de pizza desconhecido!");
            }
            return pizza;
        }
    }
}
