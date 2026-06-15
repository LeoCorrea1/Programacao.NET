using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace PainelRH.Pages
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
    }

    public class FuncionariosModel : PageModel
    {
        public List<Funcionario> ListaFuncionarios { get; set; }

        public void OnGet()
        {
            ListaFuncionarios = new List<Funcionario>();

            ListaFuncionarios.Add(new Funcionario { Nome = "João", Cargo = "Desenvolvedor", Salario = 5000.00 });
            ListaFuncionarios.Add(new Funcionario { Nome = "Maria", Cargo = "Gerente", Salario = 8500.00 });
            ListaFuncionarios.Add(new Funcionario { Nome = "Ana", Cargo = "Designer", Salario = 4200.00 });
            ListaFuncionarios.Add(new Funcionario { Nome = "Pedro", Cargo = "Analista", Salario = 4800.00 });
        }
    }
}