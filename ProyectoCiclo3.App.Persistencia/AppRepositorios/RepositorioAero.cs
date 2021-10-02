using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAeropuerto
    {
        List<Aeropuerto> aeropuerto;
 
    public RepositorioAeropuerto()  
        {
            aeropuerto= new List<Aeropuerto>()
            {
                new Aeropuerto{id=1,nombre="Kou",ciudad= "París", pais= "Francia", coordenaX= 4, coordenaY=9},
                new Aeropuerto{id=2,nombre="Chat",ciudad= "Venecia", pais= "Italia", coordenaX= 9, coordenaY=1},
                new Aeropuerto{id=3,nombre="Mar",ciudad= "Vancouver", pais = "Canada", coordenaX= 2, coordenaY=4}
            };
        }
 
        public IEnumerable<Aeropuerto> GetAll()
        {
            return aeropuerto;
        }
 
        public Aeropuerto GetAeropuertoWithId(int id){
            return aeropuerto.SingleOrDefault(b => b.id == id);
        }
    }

}
