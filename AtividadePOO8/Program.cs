namespace AtividadePOO8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos serão alugados? ");
            int QuantidadeQuartos = Convert.ToInt32(Console.ReadLine());

            Pensao[] Pensao = new Pensao[10];

            for (int i = 0; i < QuantidadeQuartos; i++)
            {
                Console.WriteLine($"Aluguel #{i+1}");
                Console.Write("Nome: ");
                String Nome = Console.ReadLine();

                Console.Write("E-mail: ");
                String Email = Console.ReadLine();

                Console.Write("Quarto: ");
                int Quarto = Convert.ToInt32(Console.ReadLine());

                Pensao[Quarto] = new Pensao(Nome, Email, Quarto);

            }
            
            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados:");

            for (int i = 0; i < 10; i++) 
            {
                if (Pensao[i] != null )
                {
                    Console.WriteLine(Pensao[i].ToString());
                }
            }

            Console.ReadKey();
            Console.Beep();
        }
    }
}
