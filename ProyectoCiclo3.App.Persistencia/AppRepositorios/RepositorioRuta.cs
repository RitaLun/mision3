using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRuta
    {
        private readonly AppContext _appContext = new AppContext(); 
        public IEnumerable<Ruta> GetAll()
        {
            return _appContext.Ruta;
        }
 
        public Ruta GetRutaWithId(int id){
            return _appContext.Ruta.Find(id);
        }
        public Ruta Create(Ruta newRuta )
    {
        var addRuta  = _appContext.Ruta.Add(newRuta );
        _appContext.SaveChanges();
        return addRuta.Entity;
    }
        public void Delete(int id)
        {
           var ruta = _appContext.Ruta.Find(id);
        if (ruta== null)
        return;
        _appContext.Ruta.Remove(ruta);
        _appContext.SaveChanges();
        }
        public Ruta Update(Ruta newRuta){
           var ruta = _appContext.Ruta.Find(newRuta.id);
        if(ruta != null){
            ruta.origen = newRuta.origen;
            ruta.destino = newRuta.destino;
            ruta.tiempoEstimado = newRuta.tiempoEstimado;
            //Guardar en base de datos
            _appContext.SaveChanges();
        }
    return ruta;
        }
    }
}