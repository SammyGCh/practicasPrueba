using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (EstanCamposLlenos())
            {
                if (EsEstaturaCorrecta())
                {
                    if (EsPesoCorecto())
                    {
                        Paciente paciente = ObtenerPaciente();
                        float caloriasPorDia = CalcularCaloriasPorDia(paciente);

                        caloriasPorDiaText.Text = caloriasPorDia.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Peso incorrecto. El peso debe contener solo números entre los valores de 0.25 kg cm y 600 kg." +
                        "\nPor ejemplo: 65 kg\n\n0.25 kg es el " +
                        "peso mínimo que se ha registrado en todo el mundo y 600 el máximo.",
                    "Peso incorrecto", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Estatura incorrecta. La estatura debe contener números entre los 20 cm y 250 cm." +
                        "\nPor ejemplo: 70 cm\n\n20 cm es la " +
                        "estatura mínima que se ha registrado en todo el mundo y 250 la máxima.",
                    "Estatura incorrecta", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("La información está incompleta. Por favor ingrese toda la información solicitada.",
                    "Campos vacíos", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private float CalcularCaloriasPorDia(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        private Paciente ObtenerPaciente()
        {
            return new Paciente
            {
                Genero = generoCombo.Text,
                Edad = int.Parse(edadCombo.Text),
                Estatura = float.Parse(estaturaText.Text),
                Peso = float.Parse(pesoActualText.Text),
                ActividadFisica = (nivelDeActividadList.SelectedItem as NivelActividad).Nombre
            };
        }

        private bool EsPesoCorecto()
        {
            bool esCorrecto = false;
            float valorMinimo = 0.25f;
            int valorMaximo = 600;
            

            Regex regexPerso = new Regex(@"\d");

            if (regexPerso.IsMatch(pesoActualText.Text))
            {
                float peso = float.Parse(pesoActualText.Text);

                if (peso >= valorMinimo && peso <= valorMaximo)
                {
                    esCorrecto = true;
                }
            }

            return esCorrecto;
        }

        private bool EstanCamposLlenos()
        {
            bool estanLlenos = false;

            if ((generoCombo.SelectedItem != null) && (edadCombo.SelectedItem != null) 
                && (!String.IsNullOrEmpty(estaturaText.Text)) && (!String.IsNullOrEmpty(pesoActualText.Text))
                && (nivelDeActividadList.SelectedItem != null))
            {
                estanLlenos = true;
            }

            return estanLlenos;
        }

        private bool EsEstaturaCorrecta()
        {
            bool esCorrecta = false;

            Regex regexEstatura = new Regex(@"\d");

            if (regexEstatura.IsMatch(estaturaText.Text))
            {
                float estatura = float.Parse(estaturaText.Text);
                if (estatura >= 20 && estatura <= 250)
                {
                    esCorrecta = true;
                }
            }

            return esCorrecta;
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

        private void LimparCampos(object sender, RoutedEventArgs e)
        {
            generoCombo.SelectedItem = null;
            edadCombo.SelectedItem = null;
            estaturaText.Text = "";
            pesoActualText.Text = "";
            nivelDeActividadList.SelectedItem = null;
            caloriasPorDiaText.Text = "Por día";
        }
    }

    public class Paciente
    {
        public string Genero { get; set; }
        public int Edad { get; set; }

        public float Estatura { get; set; }

        public float Peso { get; set; }

        public string ActividadFisica { get; set; }
    }

    public class NivelActividad
    {
        public string Nombre { get; set; }
        public string Imagen { get; set; }
    }
}
