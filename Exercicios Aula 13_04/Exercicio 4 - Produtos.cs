using System;
using System.Collections.Generic;

namespace ProjetoProdutos_13
{
    abstract class Produto
    {
        public string Nome;
        public double Preco;

        public abstract double CalcularDesconto();

        public void ExibirPrecoFinal()
        {
            double desconto = CalcularDesconto();
            double final = Preco - desconto;
            Console.WriteLine("Produto: " + Nome + " Preco Final: " + final);
        }
    }

    class Livro : Produto
    {
        public Livro(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }

        public override double CalcularDesconto()
        {
            return Preco * 0.05;
        }
    }

    class Eletronico : Produto
    {
        public Eletronico(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }

        public override double CalcularDesconto()
        {
            return Preco * 0.125;
        }
    }

    class Roupa : Produto
    {
        public Roupa(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }

        public override double CalcularDesconto()
        {
            if (Preco > 100)
            {
                return Preco * 0.20;
            }
            else
            {
                return Preco * 0.10;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();

            lista.Add(new Livro("teste1", 50.0));
            lista.Add(new Eletronico("teste 2", 2000.0));
            lista.Add(new Roupa("testee 5", 80.0));
            lista.Add(new Roupa("teste 3", 150.0));

            foreach (Produto p in lista)
            {
                p.ExibirPrecoFinal();
            }
        }
    }
}
