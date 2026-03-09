using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AULA_3___POO
{
    internal class Lampada
    {
        public bool ligada;
        public double potencia;
        public void Ligar()
        {
            if (!ligada)
            {
                ligada = true;
                Console.WriteLine("Lampada Ligada ");
            }
            else
            {
                Console.WriteLine("A lampada ja esta ligada");
            }
        }
    public void Desligar()
        {
            if(ligada)
            {
                ligada = false;
                Console.WriteLine("Lampada Desligada ");
            }
            else
            {
               Console.WriteLine("A lampada ja esta desligada");
            }
        }

    public bool EstaLigada()
        {
            return ligada;
        }

    }

}
