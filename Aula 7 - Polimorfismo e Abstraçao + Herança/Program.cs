using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace ProjetoAula06_04
{
    abstract class AcaoPersonagem
    {
        public int Acao { get; set; }

        public AcaoPersonagem(int acao)
        {
            Acao = acao;
        }

        public abstract void Executar();
        public abstract int CustoEstamina();
    }

    class Pular : AcaoPersonagem
    {
        public Pular(int acao) : base(acao) { }

        public override void Executar()
        {
            Console.WriteLine("O personagem pulou " + Acao + " metros de altura");
        }

        public override int CustoEstamina()
        {
            Console.WriteLine("O personagem gastou 10 de estamina");
            return 10;
        }
    }

    class Velocidade : AcaoPersonagem
    {
        public Velocidade(int acao) : base(acao) { }

        public override void Executar()
        {
            Console.WriteLine("O personagem correu " + Acao + " metros");
        }

        public override int CustoEstamina()
        {
            Console.WriteLine("O personagem gastou 15 de estamina");
            return 15;
        }
    }

    class Esquivar : AcaoPersonagem
    {
        public Esquivar(int acao) : base(acao) { }

        public override void Executar()
        {
            if (Acao == 1)
                Console.WriteLine("Esquiva perfeita");
            else
                Console.WriteLine("Esquiva falhou!");
        }

        public override int CustoEstamina()
        {
            Console.WriteLine("O personagem gastou 5 de estamina");
            return 5;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<AcaoPersonagem> acoes = new List<AcaoPersonagem>();

            acoes.Add(new Pular(2));
            acoes.Add(new Velocidade(10));
            acoes.Add(new Esquivar(1));
            acoes.Add(new Esquivar(2));

            int estamina = 35;

            foreach (AcaoPersonagem a in acoes)
            {
                if (estamina > 0)
                {
                    a.Executar();
                    estamina -= a.CustoEstamina();
                    Console.WriteLine("Estamina atual: " + estamina);
                    Console.WriteLine("-------------------");
                }
                else
                {
                    Console.WriteLine("Estamina Insuficiente Para realizar a Açao");
                }

               
            }

            Console.WriteLine("Estamina final: " + estamina);
            Console.ReadKey();
        }
    }
}