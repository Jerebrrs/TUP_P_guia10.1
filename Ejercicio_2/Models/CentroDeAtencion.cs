

namespace Ejercicio_2.Models
{
    public class CentroDeAtencion
    {

        public int NumeroDeReclamoGenereado
        {
            get {return reclamospendientes.Count(); }
            set { }
        }
        Queue<Reclamo> reclamospendientes = new Queue<Reclamo>();
        Queue<OrdeReparacions> trabajosPendientes = new Queue<OrdeReparacions>();
       
        public Reclamo RecibirReclamo(string nombrePersona, string motivo)
        {
            Reclamo rec = new Reclamo(NumeroDeReclamoGenereado, nombrePersona, motivo);
            reclamospendientes.Enqueue(rec);
            NumeroDeReclamoGenereado++;
            return rec;
        }

        public OrdeReparacions ResolverReclamo()
        {
            OrdeReparacions orRepa = new OrdeReparacions(reclamospendientes.Dequeue()); ;
            trabajosPendientes.Enqueue(orRepa);
            return orRepa;
        }

        public OrdeReparacions EjecutarOrdenDeTrabajo()
        {

            if (trabajosPendientes.Count >-1)
            {
                return trabajosPendientes.Dequeue();
            }
            return null;

        }
    }
}
