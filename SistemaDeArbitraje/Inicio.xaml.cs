using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using SistemaDeArbitraje.Paginas;

namespace SistemaDeArbitraje
{
    /// <summary>
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : Window
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void VerArticulosPublicados(object sender, RoutedEventArgs e)
        {
            navigationFrame.Navigate(new ArticulosPublicados());
        }

        private void VerArticulosAEvaluar(object sender, RoutedEventArgs e)
        {
            navigationFrame.Navigate(new EvaluacionArticulos());
        }

        private void VerArticulosALiberar(object sender, RoutedEventArgs e)
        {
            navigationFrame.Navigate(new LiberacionArticulos());
        }

        private void VerArticulosRechazados(object sender, RoutedEventArgs e)
        {
            navigationFrame.Navigate(new ArticulosRechazados());
        }

        private void Salir(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AceptarTrabajo(object sender, RoutedEventArgs e)
        {
            if (noAceptadoCheck.IsChecked.Value)
            {
                noAceptadoCheck.IsChecked = false;
            }
        }

        private void RechazarTrabajo(object sender, RoutedEventArgs e)
        {
            if (aceptadoCheck.IsChecked.Value)
            {
                aceptadoCheck.IsChecked = false;
            }
        }

        private void SumarPuntaje(object sender, TextChangedEventArgs e)
        {
            int valorEstructuraGeneral = 0;
            int valorIntrodccion = 0;
            int valorCongruencia = 0;
            int valorResultados = 0;
            int valorLiteratura = 0;
            int valorTotal = 0;

            try
            {
                valorEstructuraGeneral = int.Parse(estructuraGeneral.Text);
                valorIntrodccion = int.Parse(introduccion.Text);
                valorCongruencia = int.Parse(congruencia.Text);
                valorResultados = int.Parse(resultados.Text);
                valorLiteratura = int.Parse(literaturaCitada.Text);
            }
            catch (FormatException)
            {

            }

            valorTotal = valorEstructuraGeneral + valorIntrodccion + valorCongruencia + valorResultados + valorLiteratura;
            total.Text = valorTotal.ToString();
        }
    }
}
