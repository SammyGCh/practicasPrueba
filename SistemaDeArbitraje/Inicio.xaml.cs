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
using SistemaDeArbitraje.ArticuloAdmin;

namespace SistemaDeArbitraje
{
    /// <summary>
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : Window
    {
        private int valorTotal = 0;

        public Inicio()
        {
            InitializeComponent();
        }

        private void VerArticulosPublicados(object sender, RoutedEventArgs e)
        {
            navigationFrame.Navigate(new ArticulosPublicados());
            ContenedorEvaluacion.Visibility = Visibility.Hidden;
        }

        private void VerArticulosAEvaluar(object sender, RoutedEventArgs e)
        {
            navigationFrame.Navigate(new EvaluacionArticulos());
            ContenedorEvaluacion.Visibility = Visibility.Visible;
        }

        private void VerArticulosALiberar(object sender, RoutedEventArgs e)
        {
            navigationFrame.Navigate(new LiberacionArticulos());
            ContenedorEvaluacion.Visibility = Visibility.Hidden;
        }

        private void VerArticulosRechazados(object sender, RoutedEventArgs e)
        {
            navigationFrame.Navigate(new ArticulosRechazados());
            ContenedorEvaluacion.Visibility = Visibility.Hidden;
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

        private void BotonEvaluar_Click(object sender, RoutedEventArgs e)
        {
            Articulo articuloEvaluado = ContenedorEvaluacion.DataContext as Articulo;
            if (articuloEvaluado != null)
            {
                if (!String.IsNullOrEmpty(congruencia.Text) && !String.IsNullOrEmpty(literaturaCitada.Text) &&
                    !String.IsNullOrEmpty(estructuraGeneral.Text) && !String.IsNullOrEmpty(introduccion.Text) &&
                    !String.IsNullOrEmpty(resultados.Text))
                {
                    if (aceptadoCheck.IsChecked.Value)
                    {
                        articuloEvaluado.Estado = "Evaluado";
                        articuloEvaluado.calificacion = valorTotal;
                        AdministradorArticulos.Evaluar(articuloEvaluado);
                        LimpiarCampos();
                        (navigationFrame.Content as EvaluacionArticulos).PulirLista(articuloEvaluado);
                        MessageBox.Show("Articulo Evaluado");
                    }
                    else if (noAceptadoCheck.IsChecked.Value)
                    {
                        articuloEvaluado.Estado = "Rechazado";
                        articuloEvaluado.calificacion = valorTotal;
                        AdministradorArticulos.Evaluar(articuloEvaluado);
                        LimpiarCampos();
                        (navigationFrame.Content as EvaluacionArticulos).PulirLista(articuloEvaluado);
                        MessageBox.Show("Articulo Rechazado");
                    }
                    else
                    {
                        MessageBox.Show("Por favor seleccione una aceptacion");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese datos a los campos del criterio de evaluacion");
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un articulo");
            }
        }

        private void LimpiarCampos()
        {
            ContenedorEvaluacion.DataContext = null;
            congruencia.Text = "";
            literaturaCitada.Text = "";
            estructuraGeneral.Text = "";
            introduccion.Text = "";
            resultados.Text = "";
            aceptadoCheck.IsChecked = false;
            noAceptadoCheck.IsChecked = false;

        }
    }
}
