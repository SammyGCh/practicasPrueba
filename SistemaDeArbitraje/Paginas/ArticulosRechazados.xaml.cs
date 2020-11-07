using System.Linq;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;

namespace SistemaDeArbitraje.Paginas
{
    /// <summary>
    /// Lógica de interacción para ArticulosRechazados.xaml
    /// </summary>
    public partial class ArticulosRechazados : Page
    {
        private Articulo articuloSeleccionado;
        private ObservableCollection<Articulo> articulosConsultados;

        public ArticulosRechazados()
        {
            InitializeComponent();
            using (var context = new ArticulosPruebaEntities())
            {
                var articulos = context.Articulos.Where(articulo => articulo.Estado == "Rechazado").ToList();
                articulosConsultados = new ObservableCollection<Articulo>(articulos);

                tablaArticulos.ItemsSource = articulos;
            }
        }
    }
}