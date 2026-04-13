using System;
using System.Collections.Generic;

namespace ProjetoAula13_04
{
    abstract class Veiculo
    {
        public string Marca, Modelo;
        public int consumo;

        public abstract string Dirigir();

        public abstract string CalcularConsumo();

        public Veiculo(string Marca, string Modelo , int Consumo)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.consumo = Consumo;
        }
    }

    class Carro : Veiculo
    {
        public int portas;

        public Carro(string Marca, string Modelo, int portas , int consumo) : base(Marca, Modelo,consumo)
        {
            this.portas = portas;
        }

        public override string Dirigir()
        {
            return "DIRIGINDO O CARRO MARCA : " + Marca + " Modelo : " + Modelo + " Portas : " + portas;
        }

        public override string CalcularConsumo()
        {
            return "Consumo Carro :" + consumo * 10;

        }


    }

    class Moto : Veiculo
    {
        public int cilindrada;

        public Moto(string Marca, string Modelo, int cilindrada , int consumo) : base(Marca, Modelo , consumo)
        {
            this.cilindrada = cilindrada;
        }

        public override string Dirigir()
        {
            return "DIRIGINDO A MOTO MARCA : " + Marca + " Modelo : " + Modelo + " Cilindradas : " + cilindrada;
        }

        public override string CalcularConsumo()
        {
            return "Consumo Moto :" + consumo * 7;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> v = new List<Veiculo>();

            v.Add(new Carro("fiat", "uno", 2,5));
            v.Add(new Moto("honda", "f200", 1500,2));

            foreach (Veiculo a in v)
            {
                Console.WriteLine(a.Dirigir());
                Console.WriteLine(a.CalcularConsumo());
                Console.Write("\n");
            }
        }
    }
}
