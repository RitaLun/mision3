using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAeropuerto
    {
        private readonly AppContext _appContext = new AppContext(); 
        public IEnumerable<Aeropuerto> GetAll()
        {
            return _appContext.Aeropuerto;
        }
 
        public Aeropuerto GetAeropuertoWithId(int id){
            return _appContext.Aeropuerto.Find(id);
        }

        public Aeropuerto Create(Aeropuerto newAeropuerto)
    {
        var addAeropuerto = _appContext.Aeropuerto.Add(newAeropuerto);
        _appContext.SaveChanges();
        return addAeropuerto.Entity;
    }
        public void Delete(int id)
        {
           var aeropuerto = _appContext.Aeropuerto.Find(id);
        if (aeropuerto == null)
        return;
        _appContext.Aeropuerto.Remove(aeropuerto);
        _appContext.SaveChanges();
        }

        public Aeropuerto Update(Aeropuerto newAeropuerto){
           var aeropuerto = _appContext.Aeropuerto.Find(newAeropuerto.id);
        if(aeropuerto != null){
            aeropuerto.nombre = newAeropuerto.nombre;
            aeropuerto.ciudad = newAeropuerto.ciudad;
            aeropuerto.pais = newAeropuerto.pais;
            aeropuerto.coordenaX = newAeropuerto.coordenaX;
            aeropuerto.coordenaY = newAeropuerto.coordenaY;
            //Guardar en base de datos
            _appContext.SaveChanges();
        }
    return aeropuerto;
        }
    }


}
