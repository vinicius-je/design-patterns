using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Pizzas
{
    public abstract class Pizza
    {
        public string Nome { get; set; } = string.Empty;
        public ICollection<string> Ingredientes = new List<string>();

        public abstract void ExibirIgredientes();
        public abstract void Preparar();
        public abstract void Assar();
        public abstract void Embalar();
    }
}
