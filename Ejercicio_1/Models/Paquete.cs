namespace Guia_10._1.Models
{
    internal class Paquete
    {
        public int DNiRemitente { get; set; }
        public string NombreRemitente { get; set; }
        public string Direccion { get; set; }

        public Paquete(int dni, string nombre, string direccion)
        {
            this.DNiRemitente = dni;
            this.NombreRemitente = nombre;
            this.Direccion = direccion;
        }
        public override string ToString()
        {
            return $@"{NombreRemitente}({DNiRemitente} - {Direccion})";
        }
    }
}
