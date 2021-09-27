using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAviones
    {
        List<Aviones> aviones;
 
    public RepositorioAviones()
        {
            aviones= new List<Aviones>()
            {
                new Aviones{id=1,marca="Audi",modelo= 2020,numero_asientos= 4, numero_banos= 4, capacidad_maxima=150},
                new Aviones{id=2,marca="Toyota",modelo= 2021,numero_asientos= 16, numero_banos= 4, capacidad_maxima=200},
                new Aviones{id=3,marca="Mazda",modelo= 2000,numero_asientos= 24, numero_banos= 4, capacidad_maxima=80}
            };

        }
 
        public IEnumerable<Aviones> GetAll()
        {
            return aviones;
        }
 
        public Aviones GetBusWithId(int id){
            return aviones.SingleOrDefault(b => b.id == id);
        }
    }
}