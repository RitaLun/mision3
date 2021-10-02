using System;
namespace ProyectoCiclo3.App.Dominio{
    public class Ruta{
        public int id { get; set; }
        public string origen { get; set; }
        public string destino { get; set; }
        public int tiempoEstimado { get; set; } 
    } 
}