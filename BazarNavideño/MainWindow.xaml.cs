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

namespace BazarNavideño
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Producto> stock = new List<Producto>
        {
            new Producto
            {
                Nombre = "Paquetes de Tines",
                Cantidad = 200
            },

            new Producto
            {
                Nombre = "Suéteres para hombre",
                Cantidad = 50
            },

            new Producto
            {
                Nombre = "Suéteres para mujer",
                Cantidad = 150
            }
        };

        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class Producto
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
    }
}
