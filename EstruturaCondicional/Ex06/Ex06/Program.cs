using System.Globalization;
namespace Ex06
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (num < 0.0 || num > 100.0)
            {
                Console.WriteLine("Numero fora dos intervalos!!");
            }
            else if (num <= 25.0)
            {
                Console.WriteLine("Intervalo [0, 25]");
            }
            else if (num <= 50)
            {
                Console.WriteLine("Intervalo [25, 50] ");
            }
            else if ( num <= 75)
            {
                Console.WriteLine("Intervalo [50, 75]"); 
            }
            else
            {
                Console.WriteLine("Intervalo [75, 100]");
            }




        }
    }
}