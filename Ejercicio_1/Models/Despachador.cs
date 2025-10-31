

namespace Guia_10._1.Models
{
    public class Despachador
    {

        Queue<Paquete> depositos = new Queue<Paquete>();
        private Repartidor camion = null;

        public Paquete RecibirCorrespondencia(int dni, string nombre, string direccion)
        {
            Paquete paq = new Paquete(dni, nombre, direccion);

            if (paq != null)
            {
                depositos.Enqueue(paq);
                return paq;
            }

            return null;
        }

        public Repartidor PrepararCamion(int capacidad)
        {
            camion = new Repartidor(capacidad);

            return camion;
        }

        public Paquete CargarPaqueteAlCamion()
        {
            Paquete paq = null;
            if (camion.TieneCapacidadDisponible() == true)
            {
                paq = depositos.Dequeue();
                camion.Cargar(paq);
             
            }
            return paq;
        }

    }
}
