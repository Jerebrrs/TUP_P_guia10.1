namespace Guia_10._1.Models
{
    internal class Repartidor
    {
        public int Capacidad { get; }
        public int Ocupacion { get; }

        Stack<Paquete> entregas = new Stack<Paquete>();

        public Repartidor(int capacidad)
        {
            this.Capacidad = capacidad;
        }

        public Paquete Revisar()
        {
            if (entregas.Count() >= 0)
            {
                return entregas.Peek();
            }
            return null;
        }

        public void Cargar(Paquete paq)
        {
            if (paq != null)
            {
                entregas.Push(paq);
            }
        }

        public Paquete Descargar()
        {
            Paquete eliminado = null;
            if (entregas.Count()>=0)
            {
               eliminado= entregas.Pop();
                return eliminado;
            }
            return null;
        }

        public bool TieneCapacidadDisponible()
        {
            if (entregas.Count()< Capacidad)
            {
                return true;
            }
            return false;
        }
    }
}
