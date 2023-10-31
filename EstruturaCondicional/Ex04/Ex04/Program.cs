namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite a hora inicial e a hora final do jogo: ");

            string[] horas = Console.ReadLine().Split(' ');

            int hrsInicial = int.Parse(horas[0]);
            int hrsFinal = int.Parse(horas[1]);

            int duracao;

            if (hrsInicial < hrsFinal)
            {
                duracao = hrsFinal - hrsInicial;

            }
            else
            {
                duracao = 24 - hrsInicial + hrsFinal;

            }

            Console.WriteLine("O jogo durou: " +  duracao + " Horas");


        }
    }
}