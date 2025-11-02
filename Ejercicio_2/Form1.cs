using Ejercicio_2.Models;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CentroDeAtencion centAtencion = new CentroDeAtencion();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarReclamo_Click(object sender, EventArgs e)
        {
            try
            {

                if (tbNombre.Text == "" || tbMotivo.Text == "")
                {
                    MessageBox.Show("Por favor escriba un nombre y motivo.");
                }
                else
                {
                    string nombre = tbNombre.Text;
                    string motivo = tbMotivo.Text;

                    Reclamo rec = centAtencion.RecibirReclamo(nombre, motivo);

                    listBox1.Items.Add(rec);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbMotivo.Clear();
                tbNombre.Clear();
            }

        }

        private void btnCrearOrdenTrab_Click(object sender, EventArgs e)
        {
            try
            {
                OrdeReparacions orRepa = centAtencion.ResolverReclamo();

                listBox1.Items.Remove(orRepa.reclamo);
                lbxVerOrdenTrabajo.Items.Add(orRepa.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEjecutarOrden_Click(object sender, EventArgs e)
        {
            try
            {
                OrdeReparacions orRepa = centAtencion.EjecutarOrdenDeTrabajo();
                lbxVerOrdenTrabajo.Items.Remove(orRepa.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
