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

namespace BazarNavideño
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Producto tines;
        private Producto sueteresHombre;
        private Producto sueteresMujer;

        public MainWindow()
        {
            InitializeComponent();

            tines = new Producto
            {
                Cantidad = 200,
                Precio = 250.00f
            };

            sueteresHombre = new Producto
            {
                Cantidad = 50,
                Precio = 520.00f
            };

            sueteresMujer = new Producto
            {
                Cantidad = 150,
                Precio = 450.00f
            };
        }

        private void EsTextoNumero(object sender, TextCompositionEventArgs e)
        {
            Regex regexNumero = new Regex(@"\d");
            bool aceptaTexto = true;

            if (regexNumero.IsMatch(e.Text))
            {
                aceptaTexto = false;               
            }

            e.Handled = aceptaTexto;
        }

        private void RealizarOtroPedido(object sender, RoutedEventArgs e)
        {
            nombreClienteText.Text = "";
            direccionClienteText.Text = "";
            cantidadSetTinesText.Text = "0";
            cantidadSueterHombreText.Text = "0";
            cantidadSueterMujerText.Text = "0";
            codigoDescuentoText.Text = "";
            subTotalText.Text = "";
            descuentoText.Text = "";
            ivaText.Text = "";
            totalText.Text = "";
            fechaEntregaText.Text = "";
        }

        private void RealizarPedidoBoton(object sender, RoutedEventArgs e)
        {

        }

        private void Salir(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

    public class Producto
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
    }
}
