using System.Globalization;

namespace Exercicio
{
    class Ex01
    {
        static void Main(string[] args)
        {

            String produto1 = "Computador";
            String produto2 = "Mesa de escritorio";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0D;
            double preco2 = 650.50D;
            double medida = 53.234567;

            Console.WriteLine($"Produtos: \n{produto1}, cujo preço é $ {preco1:F2}\n{produto2}, cujo preço é $ {preco2:F2}");
            Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e genero: {genero}");
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
            Console.WriteLine("Arredondado (Tres casas decimais): "+ medida.ToString("F3"));
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));

        }
    }

}