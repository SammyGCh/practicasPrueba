using System.Linq;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;
using System.Windows;
using SistemaDeArbitraje.ArticuloAdmin;

namespace SistemaDeArbitraje.Paginas
{
    /// <summary>
    /// Lógica de interacción para LiberacionArticulos.xaml
    /// </summary>
    public partial class LiberacionArticulos : Page
    {
        private Articulo articuloSeleccionado;
        private ObservableCollection<Articulo> articulosConsultados;

        public LiberacionArticulos()
        {
            InitializeComponent();
            using (var context = new ArticulosPruebaEntities())
            {
                var articulos = context.Articulos.Where(articulo => articulo.Estado == "Evaluado").ToList();
                articulosConsultados = new ObservableCollection<Articulo>(articulos);

                tablaArticulos.ItemsSource = articulosConsultados;
            }
        }

        private void TablaArticulos_PreviewMouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            MessageBoxResult resultado = MessageBox.Show("¿Esta seguro de la liberacion del articulo?", "Liberacion de Articulos", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (resultado == MessageBoxResult.Yes)
            {
                articuloSeleccionado = tablaArticulos.SelectedItem as Articulo;
                AdministradorArticulos.Liberar(articuloSeleccionado);
                articulosConsultados.Remove(articuloSeleccionado);
                MessageBox.Show("Se ha realizado la liberacion del articulo");
            }
        }
    }
}
