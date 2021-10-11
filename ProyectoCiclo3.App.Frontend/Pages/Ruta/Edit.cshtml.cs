using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class EditRutaModel : PageModel
    {
        private readonly RepositorioRuta repositorioRuta;
        [BindProperty]
        public Ruta Ruta {get;set;}
        private readonly RepositorioAeropuerto repositorioAeropuerto;
        public IEnumerable<Aeropuerto> Aeropuerto {get;set;}

    public EditRutaModel(RepositorioRuta repositorioRuta, RepositorioAeropuerto repositorioAeropuerto)
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
            if(Ruta.id>0)
            {
            Ruta = repositorioRuta.Update(Ruta);
            }
            return RedirectToPage("./List");
        }
    }
}