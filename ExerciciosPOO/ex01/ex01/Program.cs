using ex01;

namespace Main
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pessoas p1 = new Pessoas();
            Pessoas p2 = new Pessoas();



            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome:");
            p1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome:");
            p2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade)
            {
                Console.WriteLine("A pessoa mais velha é: " + p1.nome);

            }
            else
            {
                Console.WriteLine("A pessoa mais velha é: " + p2.nome);
            }

        }
    }
}