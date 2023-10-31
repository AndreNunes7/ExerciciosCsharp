using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int num = int.Parse(Console.ReadLine());
            
            if (num < 0)
            {
                Console.WriteLine("Numero negativo");
            }
            else
            {
                Console.WriteLine("Numero positivo");
            }




        }
    }
}