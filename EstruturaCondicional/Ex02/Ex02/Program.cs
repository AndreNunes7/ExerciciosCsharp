namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um numero: ");

            int num = int.Parse(Console.ReadLine());

            if (num % 2  == 0)
            {
                Console.WriteLine("Numero par");

            }
            else
            {
                Console.WriteLine("Numero impar");
            }


        }
    }
}