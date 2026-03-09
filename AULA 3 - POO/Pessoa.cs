using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace AULA_3___POO_EM_C_
{
    internal class Pessoa
    {
        public string nome;
        public int idade;
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos.");
        }

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }
        public Pessoa()
        {

        }

        internal class Professor
        {
            public string nome;

            public Professor(string nome)
            {
                this.nome = nome;
            }
            public Professor()
            {

            }
        }


    }
}