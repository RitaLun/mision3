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
                new Ruta{id=1,origen="Audi",destino= 2020,tiempoEstimado= 4},
                new Ruta{id=2,origen="Toyota",destino= 2021,tiempoEstimado= 16},
                new Ruta{id=3,origen="Mazda",destino= 2000,tiempoEstimado= 24}
            };
 
        public IEnumerable<Ruta> GetAll()
        {
            return ruta;
        }
 
        public Ruta GetBusWithId(int id){
            return ruta.SingleOrDefault(b => b.id == id);
        }
    }
}