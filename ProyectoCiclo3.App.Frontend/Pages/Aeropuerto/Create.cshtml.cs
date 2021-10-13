using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class FormAeropuertoModel : PageModel
    {
        private readonly RepositorioAeropuerto repositorioAeropuerto;
        [BindProperty]
        public Aeropuerto Aeropuerto {get;set;}
public FormAeropuertoModel(RepositorioAeropuerto repositorioAeropuerto)
       {
            this.repositorioAeropuerto=repositorioAeropuerto;
       }
/*public IActionResult OnGet(int AeropuertoId)
        {
            Aeropuerto=repositorioAeropuerto.GetAeropuertoWithId(AeropuertoId);
            return Page(); 
        }
        */
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Aeropuerto.id>0)
            {
            Aeropuerto = repositorioAeropuerto.Create(Aeropuerto);
            }
            return RedirectToPage("./List");
        }
    }
}
