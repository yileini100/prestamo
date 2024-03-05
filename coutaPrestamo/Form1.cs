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

        private void btn_Guardar_Click(object sender, EventArgs e)
{
    DialogResult resultado = dlg_Guardar.ShowDialog();

    // Verificar si el usuario presionó el botón Guardar
    if (resultado == DialogResult.OK)
    {

        string ruta_archivo = dlg_Guardar.FileName;
        string crea_texto = ruta_archivo;


        using (StreamWriter archivo = File.CreateText(ruta_archivo))
        {
            archivo.WriteLine(txt_Prestamo.Text); archivo.WriteLine(txt_Tasa.Text); archivo.WriteLine(txt_Periodo.Text); archivo.WriteLine(txt_Cuota.Text);
            foreach (DataGridViewRow fila in dgv_data.Rows)
            {
                // Obtiene los valores de las celdas (supongamos que son 4 columnas)
                string valorColumna1 = fila.Cells[0].Value?.ToString() ?? "";
                string valorColumna2 = fila.Cells[1].Value?.ToString() ?? "";
                string valorColumna3 = fila.Cells[2].Value?.ToString() ?? "";
                string valorColumna4 = fila.Cells[3].Value?.ToString() ?? "";
                string valorColumna5 = fila.Cells[4].Value?.ToString() ?? "";

                // Escribe los valores en el archivo de texto
                archivo.WriteLine($"{valorColumna1}, {valorColumna2}, {valorColumna3},{valorColumna4},{valorColumna5}");

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
