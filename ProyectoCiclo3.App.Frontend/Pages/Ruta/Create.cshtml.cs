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
    public class FormRutaModel : PageModel
    {
        private readonly RepositorioRuta repositorioRuta;
        private readonly RepositorioAeropuerto repositorioAeropuerto;
        public IEnumerable<Aeropuerto> Aeropuerto {get;set;}
        [BindProperty]
       public Ruta Ruta {get;set;}
        
    public FormRutaModel(RepositorioRuta repositorioRuta, RepositorioAeropuerto repositorioAeropuerto)
       {
            this.repositorioRuta=repositorioRuta;
            this.repositorioAeropuerto=repositorioAeropuerto;
       }
        public void OnGet()
    {
        Aeropuerto=repositorioAeropuerto.GetAll();
    }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            Ruta = repositorioRuta.Create(Ruta);
            return RedirectToPage("./List");
        }
    }
}
