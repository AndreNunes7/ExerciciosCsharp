using System.ComponentModel.Design;

namespace ProgramPosto
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;


            Console.WriteLine("[1] - alcool | [2] - gasolina | [3] - diesel | [4] - sair");
            Console.WriteLine("Digite quantos produtos sairam: ");


            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if (tipo > 4)
                {
                    Console.WriteLine("Numero fora da faixa:");
                    Console.WriteLine("Digite novamente: ");
                    
                }
                if (tipo == 1)
                {

                    alcool++;
                }
                else if (tipo == 2)
                {
                    gasolina++;
                }
                else if (tipo == 3)
                {
                    diesel++;
                }
               
                tipo = int.Parse(Console.ReadLine());

            }
            Console.WriteLine($"MUITO OBRIGADO\nAlcool: {alcool}\nGasolina: {gasolina}\nDiesel: {diesel}");





        }
    }
}