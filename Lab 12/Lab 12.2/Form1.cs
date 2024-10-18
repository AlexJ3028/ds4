using System;
using System.Windows.Forms;

namespace PromedioNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Botón para calcular el promedio
        private void btnPromedio_Click(object sender, EventArgs e)
        {
            try
            {
                // Convertir el texto de los textboxes a valores numéricos
                double nota1 = double.Parse(txtNota1.Text);
                double nota2 = double.Parse(txtNota2.Text);
                double nota3 = double.Parse(txtNota3.Text);

                // Verificar si las notas están entre 1.0 y 5.0
                if (nota1 < 1.0 || nota1 > 5.0 || nota2 < 1.0 || nota2 > 5.0 || nota3 < 1.0 || nota3 > 5.0)
                {
                    MessageBox.Show("Las notas deben estar entre 1.0 y 5.0", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Calcular el promedio
                    double promedio = (nota1 + nota2 + nota3) / 3;

                    // Mostrar el promedio en el textbox de Nota Promedio
                    txtPromedio.Text = promedio.ToString("0.00");
                }
            }
            catch (FormatException)
            {
                // En caso de que el usuario ingrese un valor no numérico
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en las notas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón para resetear los campos
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtPromedio.Clear();
        }

        // Botón para salir de la aplicación
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
