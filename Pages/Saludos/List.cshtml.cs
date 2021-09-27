using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolaWeb.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
        private string[] Saludos = {"Hola, cómo estás","Qué te cuentas","Cómo va todo", "Eaemaría, a los tiempos"};
        public List <string> ListaSaludos{get;set;}
        public void OnGet()
        {
            ListaSaludos = new List<string>();
            ListaSaludos.AddRange(Saludos);
        }
    }
}
