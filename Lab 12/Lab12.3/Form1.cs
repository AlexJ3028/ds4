using System;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Botón para calcular el semiperímetro
        private void btnSemiperimetro_Click(object sender, EventArgs e)
        {
            try
            {
                // Convertir los valores de los textboxes a números
                double A = double.Parse(txtA.Text);
                double B = double.Parse(txtB.Text);
                double C = double.Parse(txtC.Text);

                // Calcular el semiperímetro
                double semiperimetro = (A + B + C) / 2;

                // Mostrar el semiperímetro en el TextBox correspondiente
                txtSemiperimetro.Text = semiperimetro.ToString("0.00");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para los lados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón para calcular el área del triángulo
        private void btnArea_Click(object sender, EventArgs e)
        {
            try
            {
                // Convertir los valores de los textboxes a números
                double A = double.Parse(txtA.Text);
                double B = double.Parse(txtB.Text);
                double C = double.Parse(txtC.Text);

                // Calcular el semiperímetro
                double semiperimetro = (A + B + C) / 2;

                // Usar la fórmula de Herón para calcular el área
                double area = Math.Sqrt(semiperimetro * (semiperimetro - A) * (semiperimetro - B) * (semiperimetro - C));

                // Mostrar el área en el TextBox correspondiente
                txtArea.Text = area.ToString("0.00");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para los lados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("No es posible formar un triángulo con los lados ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón para resetear los campos
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtSemiperimetro.Clear();
            txtArea.Clear();
        }

        // Botón para salir de la aplicación
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
