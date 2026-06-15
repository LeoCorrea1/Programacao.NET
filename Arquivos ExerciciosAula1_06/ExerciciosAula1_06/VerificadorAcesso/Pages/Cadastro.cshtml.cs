using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class CadastroModel : PageModel
    {
        [BindProperty]
        public string Nome { get; set; }

        [BindProperty]
        public int Idade { get; set; }

        public string MensagemDeRetorno { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (Idade >= 18)
            {
                MensagemDeRetorno = "Bem vindo " + Nome + "! Entrada Liberada.";
            }
            else
            {
                MensagemDeRetorno = "Barrado! " + Nome + "! Entrada Bloqueada para menores.";
            }
        }
    }
}