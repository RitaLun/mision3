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
    public class DetailsRutaModel : PageModel
    {
       private readonly RepositorioRuta repositorioRuta;
              public Ruta Ruta {get;set;}
 
        public DetailsRutaModel(RepositorioRuta repositorioRuta)
       {
            this.repositorioRuta=repositorioRuta;
       }
 
        public IActionResult OnGet(int rutaId)
        {
                Ruta=repositorioRuta.GetRutaWithId(rutaId);
                return Page();
 
        }
    }
}
