using System.Linq;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;
using SistemaDeArbitraje;

namespace SistemaDeArbitraje.Paginas
{
    /// <summary>
    /// Lógica de interacción para EvaluacionArticulos.xaml
    /// </summary>
    public partial class EvaluacionArticulos : Page
    {
        private Articulo articuloSeleccionado;
        private ObservableCollection<Articulo> articulosConsultados;

        public EvaluacionArticulos()
        {
            InitializeComponent();
            using (var context = new ArticulosPruebaEntities())
            {
                var articulos = context.Articulos.Where(articulo => articulo.Estado == "Recibido").ToList();
                articulosConsultados = new ObservableCollection<Articulo>(articulos);

                tablaArticulos.ItemsSource = articulosConsultados;
            }

         
        }

        private void TablaArticulos_PreviewMouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var articulo = tablaArticulos.SelectedItem as Articulo;
            Inicio ventanaInicio = App.Current.Windows.OfType<Inicio>().FirstOrDefault();
            ventanaInicio.ContenedorEvaluacion.DataContext = articulo;
        }
        public void PulirLista(Articulo articulo)
        {
            articulosConsultados.Remove(articulo);
        }
    }
}
