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
                new Ruta{id=1,origen="Roma",destino= "Londres",tiempoEstimado= 4 },
                new Ruta{id=2,origen="Sydney",destino= "Alemania",tiempoEstimado= 5},
                new Ruta{id=3,origen="Rusia",destino= "Brasil",tiempoEstimado= 6}
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