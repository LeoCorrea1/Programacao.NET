using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace WebApp.Pages
{
    public class SocioTorcedor
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }

        private int _idade;
        public int Idade
        {
            get { return _idade; }
            set 
            {
                if (value < 0)
                {
                    _idade = 0;
                }
                else
                {
                    _idade = value;
                }
            }
        }

        private double _mensalidade;
        public double Mensalidade
        {
            get { return _mensalidade; }
            set
            {
                if (value < 45.00)
                {
                    _mensalidade = 45.00;
                }
                else
                {
                    _mensalidade = value;
                }
            }
        }
    }

    public class SociosModel : PageModel
    {
        public List<SocioTorcedor> ListaSocios { get; set; }

        public void OnGet()
        {
            ListaSocios = new List<SocioTorcedor>();

            ListaSocios.Add(new SocioTorcedor { Nome = "Carlos", Categoria = "Ouro", Idade = 34, Mensalidade = 120.00 });
            ListaSocios.Add(new SocioTorcedor { Nome = "Marcos", Categoria = "Prata", Idade = -5, Mensalidade = 60.00 });
            ListaSocios.Add(new SocioTorcedor { Nome = "Julia", Categoria = "Bronze", Idade = 22, Mensalidade = 30.00 });
            ListaSocios.Add(new SocioTorcedor { Nome = "Roberto", Categoria = "Ouro", Idade = 45, Mensalidade = 150.00 });
        }
    }
}