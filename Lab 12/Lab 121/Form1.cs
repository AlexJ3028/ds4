using System;
using System.Windows.Forms;

namespace Lab_121
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores de los TextBoxes
                double tiempo = double.Parse(txtTiempo.Text);
                double velocidad = double.Parse(txtVelocidad.Text);

                // Calcular la distancia
                double distancia = tiempo * velocidad;

                // Mostrar la distancia en el TextBox correspondiente
                txtDistancia.Text = distancia.ToString("F2") + " km";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en los datos ingresados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos de texto
            txtTiempo.Clear();
            txtVelocidad.Clear();
            txtDistancia.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cerrar la aplicación
            Application.Exit();
        }

      
    }
}
