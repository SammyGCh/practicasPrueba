using CrediMujer.Logica;
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
            if (EstanTodosSeleccionados())
            {
                TipoNegocio negocioSeleccionado = ObtenerNegocioSeleccionado();
                TipoProducto productoSeleccionado = ObtenerProductoSeleccionado();
                NivelVentas nivelVentasSeleccionado = ObtenerNivelVentasSeleccionado();

                Credito creditoCalculado = CalculadorCredito.CalcularCredito(negocioSeleccionado, productoSeleccionado, nivelVentasSeleccionado);

                importe.Text = "$" + creditoCalculado.Importe;
                plazo.Text =  creditoCalculado.Plazo + " años";
                pagoMensual.Text = "$" + creditoCalculado.PagoMensual;
            }
            else
            {
                MessageBox.Show("Por favor selecciona las opciones solicitadas", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private bool EstanTodosSeleccionados()
        {
            bool estanSeleccionados = false;

            if ((ventasMensualList.SelectedItem != null) && (productosBox.SelectedItem != null) && (negociosList.SelectedItem != null))
            {
                estanSeleccionados = true;
            }

            return estanSeleccionados;
        }

        private TipoNegocio ObtenerNegocioSeleccionado()
        {
            TipoNegocio tipoNegocio = new TipoNegocio();
            string negocio = (negociosList.SelectedItem as Item).Nombre;

            switch (negocio)
            {
                case "Establecido":
                    tipoNegocio = TipoNegocio.Establecido;
                    break;
                case "Venta directa":
                    tipoNegocio = TipoNegocio.VentaDirecta;
                    break;
                case "Semi-fijo":
                    tipoNegocio = TipoNegocio.SemiFijo;
                    break;
                case "Móvil":
                    tipoNegocio = TipoNegocio.Movil;
                    break;
            }

            return tipoNegocio;
        }

        private TipoProducto ObtenerProductoSeleccionado()
        {
            TipoProducto tipoProducto = new TipoProducto();
            string productoSeleccionado = (productosBox.SelectedItem as Item).Nombre;

            switch (productoSeleccionado)
            {
                case "Moda y belleza":
                    tipoProducto = TipoProducto.ModaYBelleza;
                    break;
                case "Abarrotes":
                    tipoProducto = TipoProducto.Abarrotes;
                    break;
                case "Alimentos preparados":
                    tipoProducto = TipoProducto.AlimentosPreparados;
                    break;
                case "Productos de limpieza para el hogar (incluye blancos)":
                    tipoProducto = TipoProducto.ProductosLimpiezaHogar;
                    break;
            }

            return tipoProducto;
        }

        private NivelVentas ObtenerNivelVentasSeleccionado()
        {
            NivelVentas nivelVentas = new NivelVentas();
            int largoAQuitar = 37;
            string nivelSeleccionado = ventasMensualList.SelectedItem.ToString().Substring(largoAQuitar);

            switch (nivelSeleccionado)
            {
                case "Menos de $10,000":
                    nivelVentas = NivelVentas.MenosDe10;
                    break;
                case "De $10,000 a menos de $20,000":
                    nivelVentas = NivelVentas.De10a20;
                    break;
                case "De $20,000 a $30,000":
                    nivelVentas = NivelVentas.De20a30;
                    break;
                case "Más de $30,000":
                    nivelVentas = NivelVentas.MasDe30;
                    break;
            }

            return nivelVentas;
        }
    }
}
