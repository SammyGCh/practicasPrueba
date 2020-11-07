using System.Linq;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;

namespace SistemaDeArbitraje.Paginas
{
    /// <summary>
    /// Lógica de interacción para ArticulosPublicados.xaml
    /// </summary>
    public partial class ArticulosPublicados : Page
    {
        private Articulo articuloSeleccionado;
        private ObservableCollection<Articulo> articulosConsultados;

        public ArticulosPublicados()
        {
            InitializeComponent();
            using (var context = new ArticulosPruebaEntities())
            {
                var articulos = context.Articulos.Where(articulo => articulo.Estado == "Liberado").ToList();
                articulosConsultados = new ObservableCollection<Articulo>(articulos);
                
                tablaArticulos.ItemsSource = articulos;
            }
        }
    }
}
