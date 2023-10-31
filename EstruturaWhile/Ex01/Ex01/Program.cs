using System;

namespace Program
{
    class program
    {
        static void Main(string[] args)
        {

            int senha = 2002;

            Console.Write("Digite a senha para entrar: ");
            int opc = int.Parse(Console.ReadLine());

            

            while ( opc != senha )
            {
                Console.WriteLine("Senha invalida");
                Console.Write("Digite a senha para entrar: ");
                opc = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido!");



        }
    }
}