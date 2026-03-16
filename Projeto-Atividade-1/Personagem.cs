using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atividade_1
{
    internal class Personagem
    {
        string nome;
        string posicao;
        int itens;

        public Personagem(string nome, string posicao, int itens)
        {
            this.nome = nome;
            this.posicao = posicao;
            this.itens = itens;
        }

        public void Atacar(double dano)
        {
            Console.WriteLine(nome + " atacou causando dano: " + dano);
        }

        public void Movimentar(int direcao)
        {
            if (direcao == 1)
                Console.WriteLine("Movendo para frente");
            else if (direcao == 2)
                Console.WriteLine("Movendo para trás");
            else if (direcao == 3)
                Console.WriteLine("Movendo para direita");
            else if (direcao == 4)
                Console.WriteLine("Movendo para esquerda");
        }
    }
}
