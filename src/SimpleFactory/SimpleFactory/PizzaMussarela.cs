using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class PizzaMussarela : Pizza
    {
        public PizzaMussarela()
        {
            Nome = "Pizza de Mussarela";
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
