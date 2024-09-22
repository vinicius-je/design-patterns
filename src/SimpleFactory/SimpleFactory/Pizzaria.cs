using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public static class Pizzaria
    {
        public static void SolicitarPizza()
        {
            Console.WriteLine("Informe a Pizza: \n(C) - Calabreza\n(M) - Mussarela\n");
            var tipo = Console.ReadLine()!.ToUpper();

            try
            {
                Pizza pizza = PizzaSimpleFactory.CriarPizza(tipo);
                pizza.Preparar();
                pizza.Assar();
                pizza.Embalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}