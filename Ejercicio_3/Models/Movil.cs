
namespace Ejercicio_3.Models
{
    public class Movil : IComparable<Movil>
    {
        public Pedido Pasajero {  get; set; }
        public int Numero { get; set; }
        public Movil(int numero)
        {
            this.Numero = numero;
        }

        public override string ToString()
        {
            return $@"{Numero}-{Pasajero.Direccion}";
        }

        public int CompareTo(Movil? other)
        {
            if (other !=null)
            {
                return Numero.CompareTo(other.Numero);
            }
            return -1;
        }
    }
}
