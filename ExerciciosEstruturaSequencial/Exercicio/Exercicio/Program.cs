using System.Runtime.Serialization;
using System.Globalization;

namespace Exercicios
{
    class Ex
    {
        static void Main(string[] args)
        {
            //EX 01

            Console.Write("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            long soma = num1 + num2;

            Console.WriteLine("SOMA = " + soma);




            //EX 02

            double Raio, Altura, pi = 3.14159D;
            Console.Write("Digite o Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double conta = pi * Math.Pow(raio, 2);

            Console.WriteLine("A = " + conta.ToString("F4"), CultureInfo.InvariantCulture);



            //Ex 03

            Console.Write("Digite o valor A:");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor B:");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor C:");
            int C = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor D:");
            int D = int.Parse(Console.ReadLine());

            int diferenca = A * B - C * D;

            Console.WriteLine("Diferença = " + diferenca);




            // Ex 04

            double numero, horasTrabalhadas, valorHora, salario;

            Console.Write("Digite o numero do funcionario: ");
            numero = double.Parse(Console.ReadLine());
            Console.Write("Digite as horas trabalhadas: ");
            horasTrabalhadas = double.Parse(Console.ReadLine());
            Console.Write("Digite o salario por hora: ");
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horasTrabalhadas * valorHora;

            Console.WriteLine("Number = " + numero + "\nSalary = U$" + salario.ToString("F2", CultureInfo.InvariantCulture));



            // Ex 05


            int cod1, cod2, qt1, qt2;
            double valor1, valor2, total;

            Console.Write("Digite o codigo, quantidade e valor da peça 1: ");
            string[] vetor1 = Console.ReadLine().Split(' ');
            cod1 = int.Parse(vetor1[0]);
            qt1 = int.Parse(vetor1[1]);
            valor1 = double.Parse(vetor1[2], CultureInfo.InvariantCulture);

            Console.Write("Digite o codigo, quantidade e valor da peça 2: ");

            vetor1 = Console.ReadLine().Split(' ');
            cod2 = int.Parse(vetor1[0]);
            qt2 = int.Parse(vetor1[1]);
            valor2 = double.Parse(vetor1[2], CultureInfo.InvariantCulture);



            total = valor1 * qt1 + valor2 * qt2;

            Console.WriteLine("VALOR A PAGAR: R$" + total.ToString("F2", CultureInfo.InvariantCulture));





            


        }

        class Ex06
        {
            static void Main(string[] args)
            {
                // Ex 06

                double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

                Console.Write("Digite os valores: ");
                string[] vetor = Console.ReadLine().Split(' ');

                A = double.Parse(vetor[0], CultureInfo.InvariantCulture);
                B = double.Parse(vetor[1], CultureInfo.InvariantCulture);
                C = double.Parse(vetor[2], CultureInfo.InvariantCulture);


                triangulo = A * C / 2.0;
                circulo = 3.14159 * C * C;
                trapezio = (A + B) / 2.0 * C;
                quadrado = B * B;
                retangulo = A * B;

                Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));


            }
        }
    }
}