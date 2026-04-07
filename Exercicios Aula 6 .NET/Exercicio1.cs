using System;
using System.Collections.Generic;

namespace Exercicio1
{
    abstract class Animal
    {
        public string Nome { get; set; }
        public abstract void EmitirSom();
    }

    class Cachorro : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} diz: Au Au!");
        }
    }

    class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} diz: Miau!");
        }
    }

    class Program
    {
        static void Main()
        {
            List<Animal> animais = new List<Animal>
            {
                new Cachorro { Nome = "Rex" },
                new Gato { Nome = "Mingau" }
            };

            foreach (var animal in animais)
            {
                animal.EmitirSom();
            }
        }
    }
}
