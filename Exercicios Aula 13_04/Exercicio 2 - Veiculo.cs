using System;
using System.Collections.Generic;

namespace ProjetoAula13_04
{
    abstract class Veiculo
    {
        public string Marca, Modelo;

        public abstract string Dirigir();

        public Veiculo(string Marca, string Modelo)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
        }
    }

    class Carro : Veiculo
    {
        public int portas;

        public Carro(string Marca, string Modelo, int portas) : base(Marca, Modelo)
        {
            this.portas = portas;
        }

        public override string Dirigir()
        {
            return "DIRIGINDO O CARRO MARCA : " + Marca + " Modelo : " + Modelo + " Portas : " + portas;
        }
    }

    class Moto : Veiculo
    {
        public int cilindrada;

        public Moto(string Marca, string Modelo, int cilindrada) : base(Marca, Modelo)
        {
            this.cilindrada = cilindrada;
        }

        public override string Dirigir()
        {
            return "DIRIGINDO A MOTO MARCA : " + Marca + " Modelo : " + Modelo + " Cilindradas : " + cilindrada;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> v = new List<Veiculo>();

            v.Add(new Carro("fiat", "uno", 2));
            v.Add(new Moto("honda", "f200", 1500));

            foreach (Veiculo a in v)
            {
                Console.WriteLine(a.Dirigir());
            }
        }
    }
}
