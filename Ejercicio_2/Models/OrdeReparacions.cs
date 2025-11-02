

namespace Ejercicio_2.Models
{
    public class OrdeReparacions
    {
        public DateTime Fecha { get; set; }
        public bool Solucionado { get; set; }

        public Reclamo reclamo {  get; set; }
        public OrdeReparacions(Reclamo reclamo)
        {
            if (reclamo != null)
            {
                Fecha = DateTime.Now;
                this.reclamo = reclamo;
            }
        }

        public override string ToString()
        {
            string solText = Solucionado ? "Sí" : "No";
            return $"{reclamo.Numero} - {reclamo.Nombre} ";
        }
    }
}
