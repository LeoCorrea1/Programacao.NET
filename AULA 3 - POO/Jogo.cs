using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA_3___POO_EM_C_
{
    internal class Jogo
    {
        public string titulo, genero, plataforma;
        public int anoLancamento;

        public Jogo(string titulo, string genero, string plataforma, int anoLancamento)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.plataforma = plataforma;
            this.anoLancamento = anoLancamento;
        }
        public Jogo()
        {
        }

    }
}
