using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mvc1.Pages
{
    public class carrerasModel : PageModel
    {
        public string[] Carreras { get; set; }
        public string resultado;
       
        public void OnGet()
        {
            Carreras= new string[] { "CATERING SERVICE", "PERSONAL CHEF", "Waiters", "LIMOSINA SERVICE" };


        }
        public  string timertime() {

            resultado = DateTime.Now.ToString("dd/MM/yyyy");

            return resultado;
            }
        }
    }