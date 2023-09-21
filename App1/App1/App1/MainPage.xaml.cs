using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Convertir_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Peso.Text) || string.IsNullOrWhiteSpace(Volumen.Text) || string.IsNullOrWhiteSpace(Temperatura.Text))
            {
                // Manejar el caso en el que no se han ingresado valores
                return;
            }

            // Conversión de kilos a libras
            double pesoKilos = double.Parse(Peso.Text);
            double pesoLibras = pesoKilos * 2.20462; // 1 kilo = 2.20462 libras

            // Conversión de litros a galones
            double volumenLitros = double.Parse(Volumen.Text);
            double volumenGalones = volumenLitros * 0.264172; // 1 litro = 0.264172 galones

            // Conversión de Celsius a Fahrenheit
            double temperaturaCelsius = double.Parse(Temperatura.Text);
            double temperaturaFahrenheit = (temperaturaCelsius * 9 / 5) + 32;

            // Mostrar los resultados en los Entry correspondientes
            Peso.Text = pesoLibras.ToString();
            Volumen.Text = volumenGalones.ToString();
            Temperatura.Text = temperaturaFahrenheit.ToString();
        }
    }
}
