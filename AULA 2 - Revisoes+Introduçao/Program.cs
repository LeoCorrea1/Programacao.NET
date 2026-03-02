namespace AULA_2___Revisoes_Introduçao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0;

            while (op < 1 || op > 4)
            {
                Console.Write("\ndigite um numero : ");
                op = int.Parse(Console.ReadLine());
                if (op! < 1 || op! > 4)
                {
                    Console.WriteLine("\nRodando...");

                }
                else
                {
                    Console.WriteLine("Numero digitado entre 1 e 4! Saindo.");
                }
            }

            double n1;
            Console.WriteLine("Digite um double :");
            n1 = double.Parse(Console.ReadLine());
            if (n1 > 0)
            {
                Console.WriteLine("N1 POSITIVO ");

            }
            else if (n1 < 0)
            {
                Console.WriteLine("N1 NEGATIVO ");
            }
            else
            {
                Console.WriteLine("N1 IGUAL A ZERO ");
            }

            int n2;
            Console.WriteLine("Digite um numero inteiro : " );
            n2 = int.Parse(Console.ReadLine());

            if (n2 == 0)
            {
                Console.WriteLine("0 nao é divisivel");
            }
            if (n2 % 2 == 0)
            {
                Console.WriteLine("Divisivel por 2");
            }
            if (n2 % 4 == 0)
            {
                Console.WriteLine("Divisivel por 4");
            }
            if (n2 % 8 == 0)
            {
                Console.WriteLine("Divisivel por 8");
            }
            else
            {
                Console.WriteLine("nao é divisivel por 2 , 4 ou 8 ");
            }


        }
    }
}
