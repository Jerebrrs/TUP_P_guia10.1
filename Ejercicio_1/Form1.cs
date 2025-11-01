using Guia_10._1.Models;

namespace Guia_10._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Despachador despachador = new Despachador();
        Repartidor rep = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            btnEntregarPaquete.Enabled = false;
        }

        private void btnCorrespondencia_Click(object sender, EventArgs e)
        {
            Paquete paq = null;
            try
            {
                int dni = Convert.ToInt32(tbDni.Text);
                string nombre = tbNombre.Text;
                string direccion = tbDireccion.Text;

                paq = despachador.RecibirCorrespondencia(dni, nombre, direccion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                tbDni.Clear();
                tbNombre.Clear();
                tbDireccion.Clear();
            }

            if (paq != null)
            {
                lbVerSectorCompras.Items.Add(paq);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CapCamion vtn = new CapCamion();

            if (vtn.ShowDialog() == DialogResult.OK)
            {
                lbListadoAEntregar.Items.Clear();
                int capacidad = Convert.ToInt32(vtn.dupCapacidad.Text);

                rep = despachador.PrepararCamion(capacidad);


                Paquete paq = null;

                do
                {
                    paq = despachador.CargarPaqueteAlCamion();
                    if (paq != null)
                    {
                        lbVerSectorCompras.Items.Remove(paq);
                        lbListadoAEntregar.Items.Add(paq);
                    }
                } while (paq != null);
            }
        }

        private void btnIniciarReparto_Click(object sender, EventArgs e)
        {
            if (rep != null)
            {
                btnEntregarPaquete.Enabled = true;


                Paquete paq = rep.Revisar();

                if (paq != null)
                {
                    lbNombre.Text = paq.NombreRemitente;
                    lbDni.Text = Convert.ToString(paq.DNiRemitente);
                    lbDireccion.Text = paq.Direccion;
                    btnIniciarReparto.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("No hay camión preparado");
            }


        }

        private void btnEntregarPaquete_Click(object sender, EventArgs e)
        {
            Paquete paquete = rep.Descargar();

            lbListadoAEntregar.Items.Remove(paquete);

            paquete = rep.Revisar();
            if (paquete != null)
            {
                lbDni.Text = paquete.DNiRemitente.ToString();
                lbNombre.Text = paquete.NombreRemitente;
                lbDireccion.Text = paquete.Direccion;
            }
            else
            {
                lbDni.Text = "".PadRight(10, ' ');
                lbNombre.Text = "".PadRight(10, ' ');
                lbDireccion.Text = "".PadRight(10, ' ');
                btnEntregarPaquete.Enabled = false;
                btnIniciarReparto.Enabled = true;
            }
        }
    }
}
