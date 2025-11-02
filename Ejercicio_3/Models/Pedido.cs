

namespace Ejercicio_3.Models
{
    public class Pedido
    {
        public string Telefono { get; private set; }
        public string Direccion { get; private set; }

        public Pedido(string tel, string dirreccion)
        {
            this.Direccion = dirreccion;
            this.Telefono = tel;
        }
        public override string ToString()
        {
            return $@"{Direccion}({Telefono})";
        }
    }
}
