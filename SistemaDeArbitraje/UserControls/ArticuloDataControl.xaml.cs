using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SistemaDeArbitraje.UserControls
{
    /// <summary>
    /// Interaction logic for ArticulosRequest.xaml
    /// </summary>
    public partial class ArticuloDataControl : UserControl
    {

        public ArticuloDataControl()
        {
            InitializeComponent();

        }


/*
         private Articulo GetArticuloSeleccionado()
         {
             Articulo articuloSeleccionado =
                 EntradaArticulo.SelectedItem as Articulo;

             return articuloSeleccionado;
         }*/

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            // Do not load your data at design time.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Load your data here and assign the result to the CollectionViewSource.
            // 	System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for CollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
        }
    }
}
