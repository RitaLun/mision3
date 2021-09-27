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
                new Aeropuerto{id=1,nombre="Audi",ciudad= 2020, pais= 4, coordenaX= 4, coordenaY=150},
                new Aeropuerto{id=2,nombre="Toyota",ciudad= 2021, pais= 16, coordenaX= 4, coordenaY=200},
                new Aeropuerto{id=3,nombre="Mazda",ciudad= 2000, pais = 24, coordenaX= 4, coordenaY=80}
            };
 
        public IEnumerable<Aeropuerto> GetAll()
        {
            return aeropuerto;
        }
 
        public Aeropuerto GetBusWithId(int id){
            return aeropuerto.SingleOrDefault(b => b.id == id);
        }
    }
}