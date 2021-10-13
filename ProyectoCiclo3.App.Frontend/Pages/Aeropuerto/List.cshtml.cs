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
    public class ListAeropuertoModel : PageModel
    {
       
        private readonly RepositorioAeropuerto repositorioAeropuerto;
        public IEnumerable<Aeropuerto> Aeropuerto {get;set;}
        [BindProperty]
        public Aeropuerto Aeropuertos{get;set;}

    public ListAeropuertoModel(RepositorioAeropuerto repositorioAeropuerto)
    {
        this.repositorioAeropuerto=repositorioAeropuerto;
     }
 
    public void OnGet()
    {
        Aeropuerto=repositorioAeropuerto.GetAll();
    }
       public IActionResult OnPost()
    {
        if(Aeropuertos.id>0)
        {
        repositorioAeropuerto.Delete(Aeropuertos.id);
        }
        return RedirectToPage("./List");
        }
    }
}

