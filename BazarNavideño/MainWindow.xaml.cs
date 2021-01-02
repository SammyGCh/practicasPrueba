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
            if (!string.IsNullOrWhiteSpace(nombreClienteText.Text) || !string.IsNullOrWhiteSpace(direccionClienteText.Text))
            {
                if (Convert.ToInt32(cantidadSetTinesText.Text) > 0 || Convert.ToInt32(cantidadSueterHombreText.Text) > 0 || Convert.ToInt32(cantidadSueterMujerText.Text) > 0)
                {

                    double precioTines = 250 * (Convert.ToDouble(cantidadSetTinesText.Text as string));
                    double precioSueteresHombre = 520 * (Convert.ToDouble(cantidadSueterHombreText.Text as string));
                    double precioSueteresMujer = 450 * (Convert.ToDouble(cantidadSueterMujerText.Text as string));

                    if (precioTines > 0)
                    {
                        if (Convert.ToInt32(cantidadSetTinesText.Text) <= tines.Cantidad || Convert.ToInt32(cantidadSueterHombreText.Text) <= sueteresHombre.Cantidad || Convert.ToInt32(cantidadSueterMujerText.Text) <= sueteresMujer.Cantidad)
                        {
                            tines.Cantidad = tines.Cantidad - Convert.ToInt32(cantidadSetTinesText.Text);
                        }
                        else
                        {
                            precioTines = 0;
                            precioSueteresHombre = 0;
                            precioSueteresMujer = 0;
                            if (Convert.ToInt32(cantidadSetTinesText.Text) == 0)
                            {
                                MessageBox.Show("Se nos ha agotado el inventario. Acutalmente se encuentra asi : \nTines: "+ tines.Cantidad + "\n Sueteres Hombre:"+ sueteresHombre.Cantidad + "\n Suteres Mujer : "+ sueteresMujer.Cantidad );
                                return;
                            }
                            else
                            {
                                MessageBox.Show("La cantidad de tines solicitada rebasa el numero de producto que tenemos, favor de igualarlo o reducirlo a " + tines.Cantidad);
                                return;
                            }
                        }
                    }

                    if (precioSueteresHombre > 0)
                    {
                        if (Convert.ToInt32(cantidadSueterHombreText.Text) <= sueteresHombre.Cantidad || Convert.ToInt32(cantidadSueterMujerText.Text) <= sueteresMujer.Cantidad)
                        {
                            sueteresHombre.Cantidad = sueteresHombre.Cantidad - Convert.ToInt32(cantidadSueterHombreText.Text);
                        }
                        else
                        {
                            precioTines = 0;
                            precioSueteresHombre = 0;
                            precioSueteresMujer = 0;
                            if (Convert.ToInt32(cantidadSueterHombreText.Text) == 0)
                            {
                                MessageBox.Show("Se nos ha agotado el inventario. Acutalmente se encuentra asi : \nTines: " + tines.Cantidad + "\n Sueteres Hombre:" + sueteresHombre.Cantidad + "\n Suteres Mujer : " + sueteresMujer.Cantidad);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("La cantidad de sueteres solicitada rebasa el numero de producto que tenemos, favor de igualarlo o reducirlo a " + sueteresHombre.Cantidad);
                                return;
                            }
                        }
                    }

                    if (precioSueteresMujer > 0)
                    {
                        if (Convert.ToInt32(cantidadSueterMujerText.Text) <= sueteresMujer.Cantidad)
                        {
                            sueteresMujer.Cantidad = sueteresMujer.Cantidad - Convert.ToInt32(cantidadSueterMujerText.Text);
                        }
                        else
                        {
                            precioTines = 0;
                            precioSueteresHombre = 0;
                            precioSueteresMujer = 0;
                            if (Convert.ToInt32(cantidadSueterMujerText) == 0)
                            {
                                MessageBox.Show("Los Sueteres se han agotado");
                                return;
                            }
                            else
                            {
                                MessageBox.Show("La cantidad de sueteres solicitada rebasa el numero de producto que tenemos, favor de igualarlo o reducirlo a " + sueteresMujer.Cantidad);
                                return;
                            }
                        }
                    }

                    double subtotal = precioSueteresHombre + precioSueteresMujer + precioTines;
                 
                    if (!string.IsNullOrWhiteSpace(descuentoText.Text))
                    {
                        string descuentoString = Convert.ToString(codigoDescuentoText.Text);
                        double descuentoDouble = 0;
                        switch (descuentoString)
                        {
                            case "dasher":
                                descuentoDouble =  0.05 * subtotal;
                                subtotal = subtotal - descuentoDouble;
                                descuentoText.Text = Convert.ToString(descuentoDouble);
                                subTotalText.Text = Convert.ToString(subtotal);
                                break;
                            case "dancer":
                                descuentoDouble = 0.10 * subtotal;
                                subtotal = subtotal - descuentoDouble;
                                descuentoText.Text = Convert.ToString(descuentoDouble);
                                subTotalText.Text = Convert.ToString(subtotal);
                                break;
                            case "prancer":
                                descuentoDouble = 0.15 * subtotal;
                                subtotal = subtotal - descuentoDouble;
                                descuentoText.Text = Convert.ToString(descuentoDouble);
                                subTotalText.Text = Convert.ToString(subtotal);
                                break;
                            case "rudolph":
                                descuentoDouble = 0.20 * subtotal;
                                subtotal = subtotal - descuentoDouble;
                                descuentoText.Text = Convert.ToString(descuentoDouble);
                                subTotalText.Text = Convert.ToString(subtotal);
                                break;
                            default:
                                MessageBox.Show("Ingreso un descuento no valido");
                                descuentoText.Text = Convert.ToString(descuentoDouble);
                                subTotalText.Text = Convert.ToString(subtotal);
                                break;
                        }
                    }
                    else
                    {
                        descuentoText.Text = Convert.ToString(0);
                        subTotalText.Text = Convert.ToString(subtotal);
                    }


                    double iva = subtotal * 0.16;
                    ivaText.Text = Convert.ToString(iva);
                    totalText.Text = Convert.ToString(subtotal + iva);
                    DayOfWeek fecha = DateTime.Now.DayOfWeek;

                    if (fecha == DayOfWeek.Friday || fecha == DayOfWeek.Saturday || fecha == DayOfWeek.Sunday)
                    {
                        fechaEntregaText.Text = "Martes";
                    }
                    else
                    {
                        fechaEntregaText.Text = "Sabado";
                    }

                }
                else
                {
                    MessageBox.Show("Favor de ingresar minimo 1 producto de los mostrados");
                }
            }
            else
            {
                MessageBox.Show("Favor de ingresar sus datos de nombre y direccion");
            }
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
