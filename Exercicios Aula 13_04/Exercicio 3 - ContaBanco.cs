using System;
using System.Collections.Generic;

namespace ProjetoContas
{
    abstract class ContaBancaria
    {
        public double Saldo;

        public abstract void Depositar(double valor);
        public abstract void Sacar(double valor);

        public void ExibirSaldo()
        {
            Console.WriteLine("Saldo atual: " + Saldo);
        }
    }

    class ContaCorrente : ContaBancaria
    {
        public override void Depositar(double valor)
        {
            Saldo += valor;
        }

        public override void Sacar(double valor)
        {
            Saldo -= (valor + 2.00);
        }
    }

    class ContaPoupanca : ContaBancaria
    {
        public override void Depositar(double valor)
        {
            Saldo += valor;
        }

        public override void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente na poupanca!");
            }
        }
    }

    class ContaSalario : ContaBancaria
    {
        public override void Depositar(double valor)
        {
            Console.WriteLine("Nao permite deposito em conta salario");
        }

        public override void Sacar(double valor)
        {
            Saldo -= valor;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<ContaBancaria> contas = new List<ContaBancaria>();

            ContaCorrente cc = new ContaCorrente();
            cc.Saldo = 100;
            cc.Depositar(50);
            cc.Sacar(20);

            ContaPoupanca cp = new ContaPoupanca();
            cp.Saldo = 500;
            cp.Sacar(600); 
            cp.Sacar(100);

            ContaSalario cs = new ContaSalario();
            cs.Saldo = 1000;
            cs.Depositar(200); 
            cs.Sacar(50);

            contas.Add(cc);
            contas.Add(cp);
            contas.Add(cs);

            foreach (ContaBancaria c in contas)
            {
                c.ExibirSaldo();
            }
        }
    }
}
