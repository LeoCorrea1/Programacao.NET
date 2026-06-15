using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace WebApp.Pages
{
    public class CalculadoraModel : PageModel
    {
        [BindProperty]
        public int Numero1 { get; set; }

        [BindProperty]
        public int Numero2 { get; set; }

        public double? Resultado { get; set; }
        public string MensagemDeErro { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Resultado = null;
            MensagemDeErro = string.Empty;

            try
            {
                if (Numero2 == 0)
                {
                    throw new DivideByZeroException();
                }

                Resultado = (double)Numero1 / Numero2;
            }
            catch (DivideByZeroException)
            {
                MensagemDeErro = "Erro: Não é possível dividir por zero!";
            }
        }
    }
}