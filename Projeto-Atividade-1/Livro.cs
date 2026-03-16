using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Atividade_1
{
    internal class Livro
    {
        string titulo;
        string autor;
        int ano;
        bool emprestado;

        public Livro(string titulo, string autor, int ano)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.ano = ano;
            emprestado = false;
        }

        public void Emprestar()
        {
            emprestado = true;
            Console.WriteLine("Livro emprestado");
        }

        public void Devolver()
        {
            emprestado = false;
            Console.WriteLine("Livro devolvido");
        }
    }
}
