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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculaTusCalorias
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<NivelActividad> nivelesDeActividad = new List<NivelActividad>
            {
                new NivelActividad
                {
                    Nombre = "Poca actividad",
                    Imagen = "/Imagenes/pocaActividad.png"
                },

                new NivelActividad
                {
                    Nombre = "Ejercicio ligero",
                    Imagen = "/Imagenes/ejercicioLigero.png"
                },

                new NivelActividad
                {
                    Nombre = "Ejercicio moderado",
                    Imagen = "/Imagenes/ejercicioModerado.png"
                },

                new NivelActividad
                {
                    Nombre = "Deporte regular",
                    Imagen = "/Imagenes/deporteRegular.png"
                },

                new NivelActividad
                {
                    Nombre = "Deportista de élite",
                    Imagen = "/Imagenes/deportistaDeElite.png"
                }
            };

            nivelDeActividadList.ItemsSource = nivelesDeActividad;
            edadCombo.ItemsSource = GenerarEdades();
        }

        private void CalcularCaloriasButon(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(generoCombo.Text);
        }

        private List<int> GenerarEdades()
        {
            List<int> edades = new List<int>();

            for (int i = 0; i <= 120; i++)
            {
                edades.Add(i);
            }

            return edades;
        }
    }

    public class NivelActividad
    {
        public string Nombre { get; set; }
        public string Imagen { get; set; }
    }
}
