using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1Denis.Pages
{
    public class Index1Model : PageModel
    {

        public string Cognome { get; set; }
        public string Nome { get; set; }
        public void OnGet(string cognome, string nome)
        
        {

            Cognome = cognome;
            Nome = nome;

        }
    }
}
