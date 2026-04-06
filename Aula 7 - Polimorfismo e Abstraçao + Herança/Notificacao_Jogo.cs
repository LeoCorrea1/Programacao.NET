using ProjetoAula06_04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoAula06_04
{
    internal class Notificacao_Jogo
    {

        abstract class AcaoPersonagem
        {
            public int Acao { get; set; }

            public AcaoPersonagem(int acao)
            {
                Acao = acao;
            }
            public abstract void Executar();

            public abstract void CustoEstamina();
            
        }



        class Pular : AcaoPersonagem
        {
            public Pular(int acao) : base(acao) { }

            public override void Executar()
            {
                Console.WriteLine("O personagem pulou " + Acao + " Metros de Altura ");
            }

            public override void CustoEstamina()
            {
                Console.WriteLine("O personagem gastou 10 de estamina " );
                
            }

        }

        class Velocidade : AcaoPersonagem
        {
            public Velocidade(int acao) : base(acao) { }

            public override void Executar()
            {
                Console.WriteLine("O personagem Correu " + Acao + " Metros");
            }
            public override void CustoEstamina()
            {
                Console.WriteLine("O personagem gastou 15 de estamina ");

            }

        }

        class Esquivar : AcaoPersonagem
        {
            public Esquivar(int acao) : base(acao) { }

            public override void Executar()
            {

                if (Acao == 1) Console.WriteLine("Esquiva Perfeita");
                else Console.WriteLine("Esquiva falhou!");
            }
            public override void CustoEstamina()
            {
                Console.WriteLine("O personagem gastou 5 de estamina ");

            }

        }
    
       
    }
}
