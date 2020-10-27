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

namespace CrediMujer
{
    /// <summary>
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : Window
    {
        private List<Item> productos;
        public Inicio()
        {
            InitializeComponent();
            

            productosBox.ItemsSource = ObtenerProductos();
            negociosList.ItemsSource = ObtenerNegocios();
        }

        private List<Item> ObtenerProductos()
        {
            return productos = new List<Item>()
            {
                new Item()
                {
                    UrlImagen = "Imagen/moda.png",
                    Nombre = "Moda y belleza"
                },

                new Item()
                {
                    UrlImagen = "Imagen/basica.png",
                    Nombre = "Abarrotes"
                },

                new Item()
                {
                    UrlImagen = "Imagen/comida.png",
                    Nombre = "Alimentos preparados"
                },

                new Item()
                {
                    UrlImagen = "Imagen/hogar.png",
                    Nombre = "Productos de limpieza para el hogar (incluye blancos)"
                }
            };
        }

        private List<Item> ObtenerNegocios()
        {
            return new List<Item>()
            {
                new Item()
                {
                    UrlImagen = "Imagen/establecido.png",
                    Nombre = "Establecido"
                },

                new Item()
                {
                    UrlImagen = "Imagen/ventaDirecta.png",
                    Nombre = "Venta directa"
                },

                new Item()
                {
                    UrlImagen = "Imagen/semi-fijo.png",
                    Nombre = "Semi-fijo"
                },

                new Item()
                {
                    UrlImagen = "Imagen/movil.png",
                    Nombre = "Móvil"
                }
            };
        }

        private void SimularCredito(object sender, RoutedEventArgs e)
        {
            string nombre = (negociosList.SelectedItem as Item).Nombre;

            MessageBox.Show(nombre);
        }
    }
}
