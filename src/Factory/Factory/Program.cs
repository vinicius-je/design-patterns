using Factory.Factories;

namespace Factory
{
    class Program
    {
        public static void Main(string[] args) 
        { 
            var loop = true;
            while (loop) {
                Console.WriteLine("Selecione uma pizzaria:\n[B] - Brasil\n[I] - Itália\n[Resposta]: ");
                string local = Console.ReadLine()!.ToUpper();

                try
                {
                    PizzaFactoryMethod pizzaria = PizzaSimpleFactory.CriarPizzaria(local);

                    Console.WriteLine("Selecione um sabor de pizza:\n[C] - Calabresa\n[M] - Mussarela\n[Resposta]: ");
                    string sabor = Console.ReadLine()!.ToUpper();
                    var pizza = pizzaria.MontarPizza(sabor);

                    pizza.ExibirIgredientes();
                    pizza.Preparar();
                    pizza.Assar();
                    pizza.Embalar();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("Deseja continuar? [S] - Sim, [N] - Não\n[Resposta]: ");
                loop = Console.ReadLine()!.ToUpper().Equals("N") ? false : true;
            }
        }
    }
}