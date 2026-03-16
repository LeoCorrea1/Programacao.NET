using System;
using Projeto_Atividade_1;

class Program
{
    static void Main()
    {
        int op;

        do
        {
            Console.WriteLine("\nMENU");
            Console.WriteLine("1 - Exercício Aluno");
            Console.WriteLine("2 - Exercício Livro");
            Console.WriteLine("3 - Exercício Personagem");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    ExecutarAluno();
                    break;

                case 2:
                    ExecutarLivro();
                    break;

                case 3:
                    ExecutarPersonagem();
                    break;
            }

        } while (op != 0);
    }

    static void ExecutarAluno()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Curso: ");
        string curso = Console.ReadLine();

        Aluno a = new Aluno(nome, idade, curso);
        a.MostrarDados();
    }

    static void ExecutarLivro()
    {
        Console.WriteLine("Livro 1");

        Console.Write("Título: ");
        string t1 = Console.ReadLine();

        Console.Write("Autor: ");
        string a1 = Console.ReadLine();

        Console.Write("Ano: ");
        int ano1 = int.Parse(Console.ReadLine());

        Livro l1 = new Livro(t1, a1, ano1);

        Console.WriteLine("\nLivro 2");

        Console.Write("Título: ");
        string t2 = Console.ReadLine();

        Console.Write("Autor: ");
        string a2 = Console.ReadLine();

        Console.Write("Ano: ");
        int ano2 = int.Parse(Console.ReadLine());

        Livro l2 = new Livro(t2, a2, ano2);

        l1.Emprestar();
        l1.Devolver();
    }

    static void ExecutarPersonagem()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Posição: ");
        string pos = Console.ReadLine();

        Console.Write("Itens coletados: ");
        int itens = int.Parse(Console.ReadLine());

        Personagem p = new Personagem(nome, pos, itens);

        Console.Write("Dano do ataque (0-10): ");
        double dano = double.Parse(Console.ReadLine());
        p.Atacar(dano);

        Console.Write("Direção (1 frente, 2 trás, 3 direita, 4 esquerda): ");
        int dir = int.Parse(Console.ReadLine());
        p.Movimentar(dir);
    }
}



