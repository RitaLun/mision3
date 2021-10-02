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
            new Aviones{id=1,marca="Airbus",modelo= 2020,numero_asientos= 4, numero_banos= 4, capacidad_maxima=150},
            new Aviones{id=2,marca="Boeing 787",modelo= 2021,numero_asientos= 16, numero_banos= 4, capacidad_maxima=200},
            new Aviones{id=3,marca="Airbus A319",modelo= 2000,numero_asientos= 24, numero_banos= 4, capacidad_maxima=80}
        };
    }

        public IEnumerable<Aviones> GetAll()
        {
            return aviones;
        }
 
        public Aviones GetAvionWithId(int id){
            return aviones.SingleOrDefault(b => b.id == id);
        }
        public Aviones Update(Aviones newAvion){
            var avion= aviones.SingleOrDefault(b => b.id == newAvion.id);
            if(avion != null){
                avion.marca = newAvion.marca;
                avion.modelo = newAvion.modelo;
                avion.numero_banos = newAvion.numero_banos;
                avion.numero_asientos = newAvion.numero_asientos;
                avion.capacidad_maxima = newAvion.capacidad_maxima;
            }
        return avion;
        }
    }
}