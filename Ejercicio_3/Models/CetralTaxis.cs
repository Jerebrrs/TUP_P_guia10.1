

namespace Ejercicio_3.Models
{
    internal class CetralTaxis
    {
        private Queue<Movil> movilesDisponible = new Queue<Movil>();
        private List<Movil> movilesOcupados = new List<Movil>();
        private Queue<Pedido> pedidos = new Queue<Pedido>();

        public CetralTaxis()
        {
            for (int n = 1; n < 4; n++)
            {
                movilesDisponible.Enqueue(new Movil(n));
            }
        }

        public int CantidadDisponibles { get { return movilesDisponible.Count; } }

        public Movil VerDisponible(int idx)
        {
            Movil mov = movilesDisponible.ToArray()[idx];
            return mov;
        }
        public Pedido RecibirSolicitud(string direccion,string tel)
        {
            Pedido pedido = new Pedido(tel, direccion);
            if (pedido !=null)
            {
                pedidos.Enqueue(pedido);
            }
           
            return pedido;
        }

        public Movil AsignarCoche()
        {
           
            if (pedidos.Count()>0)
            {
                Pedido pasajero = pedidos.Dequeue();
                Movil movilAsignado = movilesDisponible.Dequeue();
                movilAsignado.Pasajero = pasajero;
                movilesOcupados.Add(movilAsignado);
                return movilAsignado;
            }
            return null;
        }

        public Movil LiberarVehiculo(int numero)
        {
            Movil movilLiberado = null;
            foreach (Movil m in movilesOcupados)
            {
                if (m.Numero == numero)
                {
                    movilLiberado = m;
                }
            }

            movilesOcupados.Sort();
            int idx = movilesOcupados.BinarySearch(movilLiberado);

            if (idx !=-1)
            {
                movilesOcupados.Remove(movilesOcupados[idx]);
                movilesDisponible.Enqueue(movilLiberado);
            }
            return movilLiberado;

        }
    }
}
