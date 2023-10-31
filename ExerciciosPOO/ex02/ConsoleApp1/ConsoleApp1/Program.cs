using ClasseFuncionarios;
using System.Globalization;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios F1 = new Funcionarios();
            Funcionarios F2 = new Funcionarios();
            Funcionarios salario = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionario:");
            Console.Write("Nome: ");
            F1.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            F1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do segundo funcionario:");
            Console.Write("Nome: ");
            F2.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            F2.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double mediaSalario = (F1.Salario + F2.Salario) / 2.0;

            Console.Write("Salario medio: " + mediaSalario.ToString("F2", CultureInfo.InvariantCulture)); 


        }
      
    }
}