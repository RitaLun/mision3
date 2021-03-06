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
    public class ListRutaModel : PageModel
    {
        private readonly RepositorioRuta repositorioRuta;
        public IEnumerable<Ruta> Rutas {get;set;}
        [BindProperty]
        public Ruta Ruta {get;set;}
 
    public ListRutaModel(RepositorioRuta repositorioRuta)
    {
        this.repositorioRuta=repositorioRuta;
     }
 
    public void OnGet()
    {
        Rutas=repositorioRuta.GetAll();
    }
    public IActionResult OnPost()
    {
        if(Ruta.id>0)
        {
        repositorioRuta.Delete(Ruta.id);
        }
        return RedirectToPage("./List");
    }
    }
}
