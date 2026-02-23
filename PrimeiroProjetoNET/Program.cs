namespace PrimeiroProjetoNET
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            string nome;
            String sobrenome;

            nome = "Leonardo";
            sobrenome = "Correa";
            string nomeCompleto = nome + " " + sobrenome;
            int i = 0;
            float valor = 10.5f;

            Console.WriteLine("seu nome completo eh " + nomeCompleto + ", inteiro : " + i + ", float : " + valor);

            DateTime data = DateTime.Now;
        
            Console.WriteLine("data atual : " + data);

            Console.WriteLine($"{nome} {sobrenome}");

            string disciplina;
            string curso;

            Console.Write("\ndigite o nome do curso :");
            curso = Console.ReadLine();
            Console.Write("\ndigite a disciplina : ");
            disciplina = Console.ReadLine();

            Console.WriteLine($"O curso é {curso} e a disciplina é {disciplina}");




        }
    }
}
