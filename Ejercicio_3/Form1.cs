using Ejercicio_3.Models;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        CetralTaxis centTaxis = new CetralTaxis();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbTel.Text != "" || tbDirreccion.Text != "")
                {
                    string tel = tbTel.Text;
                    string dirr = tbDirreccion.Text;

                    Pedido pedido = centTaxis.RecibirSolicitud(dirr, tel);
                    lbPedidosEntra.Items.Add(pedido.ToString());
                }
                else
                {
                    MessageBox.Show("Por favor escriba un nombre y motivo.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbDirreccion.Clear();
                tbTel.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < centTaxis.CantidadDisponibles; i++)
            {
                lbVehiculosDisponibles.Items.Add(centTaxis.VerDisponible(i).Numero);

            }

        }

        private void btnAsignarCliente_Click(object sender, EventArgs e)
        {

            try
            {
                Movil movilAsignado = centTaxis.AsignarCoche();
                if (movilAsignado != null)
                {
                    lbPedidosEntra.Items.Remove(movilAsignado.Pasajero.ToString());
                    lbVehiculosDisponibles.Items.Remove(movilAsignado.Numero);
                    lbOcupados.Items.Add(movilAsignado.ToString());
                }
                else
                {
                    MessageBox.Show("No Existen pedido asignados.");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          


        }

        private void btnLive_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(dupNumero.Text);
                if (num != -1)
                {
                    Movil movilLiberado = centTaxis.LiberarVehiculo(num);
                    lbVehiculosDisponibles.Items.Add(movilLiberado.Numero);
                    lbOcupados.Items.Remove(movilLiberado.ToString());
                }
                else
                {
                    MessageBox.Show("Por favor escriba un numero de movil correcto.");
                }
               
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dupNumero.Text = "";
               
            }
           
        }
    }
}
