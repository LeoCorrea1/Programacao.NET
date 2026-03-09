using AULA_3___POO_EM_C_;
using static AULA_3___POO_EM_C_.Professor;

namespace AULA_3___POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lampada lampada = new Lampada();
            lampada.potencia = 200;
            lampada.Ligar();
            lampada.Ligar();
            lampada.Desligar();

            if(lampada.EstaLigada())
            {
                Console.WriteLine("A lampada esta ligada");
            }
            else
            {
                Console.WriteLine("A lampada esta desligada");
            }
 
            Pessoa p1 = new Pessoa();
            Console.WriteLine("Digite o nome da primeira pessoa : ");
            p1.nome = Console.ReadLine();

            Console.WriteLine("Digite a idade da primeira pessoa : ");
            p1.idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o nome e idade da segunda pessoa : ");
            Pessoa p2 = new Pessoa(Console.ReadLine(), int.Parse(Console.ReadLine()));


            Console.WriteLine("Digite o nome e idade da terceira pessoa : ");
            Pessoa p3 = new Pessoa(Console.ReadLine(), int.Parse(Console.ReadLine()));

            p1.Apresentar();
            Console.WriteLine();
            p2.Apresentar();
            Console.WriteLine();
            p3.Apresentar();


            Professor pr1 = new Professor();
            Laboratorio l1 = new Laboratorio();

            Console.WriteLine("Digite o nome do professor : ");
            pr1.nome = Console.ReadLine();
            Console.WriteLine("Digite o local do laboratório : ");
            l1.local = Console.ReadLine();

            Console.WriteLine($"O nome do professor eh {pr1.nome} e o local da sala eh {l1.local}");


            Jogo j1 = new Jogo();
            Console.WriteLine("digite o titulo do jogo :");
            j1.titulo = Console.ReadLine();
            Console.WriteLine("digite o genero do jogo :");
            j1.genero = Console.ReadLine();
            Console.WriteLine("digite a plataforma do jogo :");
            j1.plataforma = Console.ReadLine();
            Console.WriteLine("digite o ano de lancamento do jogo :");
            j1.anoLancamento = int.Parse(Console.ReadLine());

            Console.WriteLine($"O titulo do jogo eh {j1.titulo}, o genero eh {j1.genero}, a plataforma eh {j1.plataforma} e o ano de lancamento eh {j1.anoLancamento}");



        }
    }   
}
