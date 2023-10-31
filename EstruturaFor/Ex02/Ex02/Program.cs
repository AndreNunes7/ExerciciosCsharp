namespace Program
{
    class Ex02
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            int num = int.Parse(Console.ReadLine());

            int numIN = 0;
            int numOUT = 0;

            for (int i = 0; i < num; i++) 
            {
                Console.Write("Digite o numero que voce quer saber: ");
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    numIN++;
                }
                else
                {
                    numOUT++;
                }
                
            }
            Console.WriteLine($"{numIN} in\n{numOUT} out");

        }
    }
}