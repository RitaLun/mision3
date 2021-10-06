using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRuta
    {
        List<Ruta> ruta;
 
 
    public RepositorioRuta()
        {
            ruta= new List<Ruta>()
            {
                new Ruta{id=1,origen=3,destino= 1,tiempoEstimado= 4 },
                new Ruta{id=2,origen=2,destino= 3,tiempoEstimado= 5},
                new Ruta{id=3,origen=1,destino= 2,tiempoEstimado= 6}
            };
        }

        public IEnumerable<Ruta> GetAll()
        {
            return ruta;
        }
 
        public Ruta GetRutaWithId(int id){
            return ruta.SingleOrDefault(b => b.id == id);
        }
    }
}