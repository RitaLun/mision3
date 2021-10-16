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
    public class EditAeropuertoModel : PageModel
    {
        private readonly RepositorioAeropuerto repositorioAeropuerto;
        public Aeropuerto Aeropuerto {get;set;}
        public EditAeropuertoModel(RepositorioAeropuerto repositorioAeropuerto)
       {
            this.repositorioAeropuerto=repositorioAeropuerto;
       }
       public IActionResult OnGet(int aeropuertoId)
        {
            Aeropuerto=repositorioAeropuerto.GetAeropuertoWithId(aeropuertoId);
            return Page(); 
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Aeropuerto.id>0)
            {
            Aeropuerto = repositorioAeropuerto.Update(Aeropuerto);
            }
            return RedirectToPage("./List");
        }
    }
}