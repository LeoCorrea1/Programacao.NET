using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atividade_1
{
    internal class Aluno
    {
        string nome;
        int idade;
        string curso;

        public Aluno(string nome, int idade, string curso)
        {
            this.nome = nome;
            this.idade = idade;
            this.curso = curso;
        }

        public void MostrarDados()
        {
            Console.WriteLine("\nDados do Aluno");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Curso: " + curso);
        }
    }
}
