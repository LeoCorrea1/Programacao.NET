using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace MeuApp.Pages
{
    // Classe que define o que é um Funcionário
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
    }

    public class FuncionariosModel : PageModel
    {
        // CAMPOS DO FORMULÁRIO (BindProperty liga o HTML ao C#)
        [BindProperty]
        public string NomeDigitado { get; set; }

        [BindProperty]
        public string CargoDigitado { get; set; }


        // A LISTA DEVE SER STATIC para não apagar os dados quando a página recarregar
        public static List<Funcionario> ListaFuncionarios { get; set; } = new List<Funcionario>();


        // Executa quando a página abre pela primeira vez
        public void OnGet()
        {
            // Se a lista estiver vazia, colocamos apenas um de exemplo
            if (ListaFuncionarios.Count == 0)
            {
                ListaFuncionarios.Add(new Funcionario { Nome = "Carlos Silva", Cargo = "Gerente" });
            }
        }

        // Executa quando o usuário clica no botão do formulário (POST)
        public void OnPost()
        {
            // 1. Valida se o usuário não enviou campos em branco
            if (!string.IsNullOrEmpty(NomeDigitado) && !string.IsNullOrEmpty(CargoDigitado))
            {
                // 2. Cria o novo funcionário com o que foi digitado
                Funcionario novoFuncionario = new Funcionario
                {
                    Nome = NomeDigitado,
                    Cargo = CargoDigitado
                };

                // 3. Adiciona o novo funcionário na lista estática
                ListaFuncionarios.Add(novoFuncionario);
            }

            // 4. Limpa as caixas de texto do formulário após o envio
            NomeDigitado = string.Empty;
            CargoDigitado = string.Empty;
        }
    }
}
