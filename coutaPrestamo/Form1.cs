using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coutaPrestamo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double montoPrestamo, tasaInteresAnual, tiempoPrestamo, cuota;


            montoPrestamo = Convert.ToDouble(txt_Prestamo.Text);
            tasaInteresAnual = Convert.ToDouble(txt_Tasa.Text);
            tiempoPrestamo = Convert.ToDouble(txt_Periodo.Text);

            double tasaInteresMensual = tasaInteresAnual / 100 / 12;

            // Calcular la cuota mensual utilizando la fórmula de cuota fija
            cuota = (montoPrestamo * tasaInteresMensual) / (1 - Math.Pow(1 + tasaInteresMensual, -tiempoPrestamo));

            // Mostrar el resultado en el campo de texto correspondiente
            txt_Cuota.Text = cuota.ToString("C2");


            double tperiodo = 0;
            double cuotas = 0;
            double interese = 0;
            double tcapital = 0;

            // Calcular y agregar los datos de cada período a la tabla
            double saldoRestante = montoPrestamo;
            for (int periodo = 1; periodo <= tiempoPrestamo; periodo++)
            {
                double intereses = saldoRestante * tasaInteresMensual;
                double capital = cuota - intereses;
                saldoRestante -= capital;

                dgv_data.Rows.Add(periodo, cuota, intereses, capital, saldoRestante);
            }

       


        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Cuota.Clear();
            txt_Periodo.Clear();
            txt_Tasa.Clear();
            txt_Prestamo.Clear();
        }

        
    }
}
