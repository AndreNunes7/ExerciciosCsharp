namespace Ex03
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero: ");
            string[] vetor = Console.ReadLine().Split(' ');
            int A = int.Parse(vetor[0]);
            int B = int.Parse(vetor[1]);

            if ( A % B == 0 || B % A == 0) 
            {
                Console.WriteLine("São multiplos");
            }
            else
            {
                Console.WriteLine("Não sao multiplos");
            }


        }
    }
}