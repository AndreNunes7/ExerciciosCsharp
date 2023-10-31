using System;
using System.Globalization;
namespace Ex02
{
    class Exercicio
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com seu nome completo: ");
            string? nome = Console.ReadLine();
            Console.WriteLine("O nome digitado foi: " + nome);

            Console.Write("Quantos quartos tem na sua casa?: ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sua casa possui {quartos} quartos");

            Console.Write("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Entre com seu último nome, idade e altura ( mesma linha ) ");

            string[] vetor = Console.ReadLine().Split(' ');
            string cor = vetor[0];
            string num = vetor[1];
            string num2 = vetor[2];
            Console.WriteLine(cor);
            Console.WriteLine(num);
            Console.WriteLine(num2);

        }
    }
}