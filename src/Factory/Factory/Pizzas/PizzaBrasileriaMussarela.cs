using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Pizzas
{
    public class PizzaBrasileriaMussarela : Pizza
    {
        public PizzaBrasileriaMussarela()
        {
            Nome = "Pizza Brasileira de Mussarela";
            Ingredientes.Add("Molho de tomate");
            Ingredientes.Add("Mussarela");
            Ingredientes.Add("Orégano");
            Ingredientes.Add("Tomate");
        }

        public override void ExibirIgredientes()
        {
            Console.WriteLine($"Ingrediantes da {Nome} está assando!");

            foreach(var ingrediente in Ingredientes)
            {
                Console.WriteLine(ingrediente);
            }
        }
        public override void Assar()
        {
            Console.WriteLine($"Sua {Nome} está assando!");
        }

        public override void Embalar()
        {
            Console.WriteLine($"Sua {Nome} está sendo embalada!");
        }


        public override void Preparar()
        {
            Console.WriteLine($"Sua {Nome} está sendo preparada!");
        }
    }
}
