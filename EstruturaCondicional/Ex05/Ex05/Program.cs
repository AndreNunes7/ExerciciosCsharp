using System.Globalization;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------- tabela ---------");
            Console.WriteLine("1 - Cachorro quente  - preço: R$4.00\n2 - X-Salada - preço: R$4.50\n3 - X-bacon - preço: R$5.00\n4 - Torrada simples - preço : R$2.00\n5 - Refrigerante - preço: R$1.50");


            Console.Write("Qual sua escolha?: ");
            string[] vetor = Console.ReadLine().Split(' ');

            int codigo = int.Parse(vetor[0]);
            double qtd = double.Parse(vetor[1]);


            double total = 0;

            if (codigo > 5)
            {
                Console.WriteLine("ERRO: Opção invalida");
            }
            else if (codigo == 1)
            {
                total = qtd * 4.0;

            }
            else if (codigo == 2) 
            {
                total = qtd * 4.5;
            }
            else if (codigo == 3)
            {
                total = qtd * 5.0;

            }
            else if (codigo == 4)
            {
                total = qtd * 2.0;
            }
            else
            {
                total = qtd * 1.5;
            }

            Console.WriteLine("Total: R$" + total.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}