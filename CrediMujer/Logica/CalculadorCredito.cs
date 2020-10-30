using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CrediMujer.Logica;

namespace CrediMujer.Logica
{
    public static class CalculadorCredito
    {
        public static Credito CalcularCredito(TipoNegocio negocio, TipoProducto producto, NivelVentas nivelVentas)
        {
            double interes = 0;
            double tasa = 0;
            int numeroMeses = 12;
            Credito credito = new Credito();
            switch (negocio)
            {
                
                case TipoNegocio.Establecido:
                    
                    switch (producto)
                    {
                        
                        case TipoProducto.ModaYBelleza:
                            
                            switch (nivelVentas)
                            {
                                case NivelVentas.MenosDe10:
                                    credito.Importe = 100000;
                                    credito.Plazo = 3;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De10a20:
                                    credito.Importe = 100000;
                                    credito.Plazo = 2;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De20a30:
                                    credito.Importe = 100000;
                                    credito.Plazo = 2;
                                    tasa = 0.14;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.MasDe30:
                                    credito.Importe = 100000;
                                    credito.Plazo = 1;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;
                            }
                            break;
                        case TipoProducto.Abarrotes:

                            switch (nivelVentas)
                            {
                                case NivelVentas.MenosDe10:
                                    credito.Importe = 100000;
                                    credito.Plazo = 3;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De10a20:
                                    credito.Importe = 100000;
                                    credito.Plazo = 2;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De20a30:
                                    credito.Importe = 100000;
                                    credito.Plazo = 2;
                                    tasa = 0.14;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.MasDe30:
                                    credito.Importe = 100000;
                                    credito.Plazo = 1;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;
                            }
                            break;
                        case TipoProducto.AlimentosPreparados:

                            switch (nivelVentas)
                            {
                                case NivelVentas.MenosDe10:
                                    credito.Importe = 50000;
                                    credito.Plazo = 3;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De10a20:
                                    credito.Importe = 50000;
                                    credito.Plazo = 2;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De20a30:
                                    credito.Importe = 50000;
                                    credito.Plazo = 2;
                                    tasa = 0.14;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.MasDe30:
                                    credito.Importe = 50000;
                                    credito.Plazo = 1;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;
                            }
                            break;
                        case TipoProducto.ProductosLimpiezaHogar:

                            switch (nivelVentas)
                            {
                                case NivelVentas.MenosDe10:
                                    credito.Importe = 100000;
                                    credito.Plazo = 3;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De10a20:
                                    credito.Importe = 100000;
                                    credito.Plazo = 2;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De20a30:
                                    credito.Importe = 100000;
                                    credito.Plazo = 2;
                                    tasa = 0.14;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.MasDe30:
                                    credito.Importe = 100000;
                                    credito.Plazo = 1;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;
                            }
                            break;
                    }
                    break;

                case TipoNegocio.SemiFijo:

                    switch (producto)
                    {

                        case TipoProducto.ModaYBelleza:

                            switch (nivelVentas)
                            {
                                case NivelVentas.MenosDe10:
                                    credito.Importe = 25000;
                                    credito.Plazo = 3;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De10a20:
                                    credito.Importe = 25000;
                                    credito.Plazo = 2;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De20a30:
                                    credito.Importe = 25000;
                                    credito.Plazo = 2;
                                    tasa = 0.14;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.MasDe30:
                                    credito.Importe = 25000;
                                    credito.Plazo = 1;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;
                            }
                            break;
                        case TipoProducto.Abarrotes:

                            switch (nivelVentas)
                            {
                                case NivelVentas.MenosDe10:
                                    credito.Importe = 75000;
                                    credito.Plazo = 3;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De10a20:
                                    credito.Importe = 75000;
                                    credito.Plazo = 2;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De20a30:
                                    credito.Importe = 75000;
                                    credito.Plazo = 2;
                                    tasa = 0.14;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.MasDe30:
                                    credito.Importe = 75000;
                                    credito.Plazo = 1;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;
                            }
                            break;
                        case TipoProducto.AlimentosPreparados:

                            switch (nivelVentas)
                            {
                                case NivelVentas.MenosDe10:
                                    credito.Importe = 50000;
                                    credito.Plazo = 3;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De10a20:
                                    credito.Importe = 50000;
                                    credito.Plazo = 2;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De20a30:
                                    credito.Importe = 50000;
                                    credito.Plazo = 2;
                                    tasa = 0.14;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.MasDe30:
                                    credito.Importe = 50000;
                                    credito.Plazo = 1;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;
                            }
                            break;
                        case TipoProducto.ProductosLimpiezaHogar:

                            switch (nivelVentas)
                            {
                                case NivelVentas.MenosDe10:
                                    credito.Importe = 75000;
                                    credito.Plazo = 3;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De10a20:
                                    credito.Importe = 75000;
                                    credito.Plazo = 2;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De20a30:
                                    credito.Importe = 75000;
                                    credito.Plazo = 2;
                                    tasa = 0.14;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.MasDe30:
                                    credito.Importe = 75000;
                                    credito.Plazo = 1;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;
                            }
                            break;
                    }
                    break;

                case TipoNegocio.Movil:

                    switch (producto)
                    {

                        case TipoProducto.ModaYBelleza:

                            switch (nivelVentas)
                            {
                                case NivelVentas.MenosDe10:
                                    credito.Importe = 25000;
                                    credito.Plazo = 3;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De10a20:
                                    credito.Importe = 25000;
                                    credito.Plazo = 2;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De20a30:
                                    credito.Importe = 25000;
                                    credito.Plazo = 2;
                                    tasa = 0.14;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.MasDe30:
                                    credito.Importe = 25000;
                                    credito.Plazo = 1;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;
                            }
                            break;
                        case TipoProducto.Abarrotes:

                            switch (nivelVentas)
                            {
                                case NivelVentas.MenosDe10:
                                    credito.Importe = 75000;
                                    credito.Plazo = 3;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De10a20:
                                    credito.Importe = 75000;
                                    credito.Plazo = 2;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De20a30:
                                    credito.Importe = 75000;
                                    credito.Plazo = 2;
                                    tasa = 0.14;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.MasDe30:
                                    credito.Importe = 75000;
                                    credito.Plazo = 1;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;
                            }
                            break;
                        case TipoProducto.AlimentosPreparados:

                            switch (nivelVentas)
                            {
                                case NivelVentas.MenosDe10:
                                    credito.Importe = 50000;
                                    credito.Plazo = 3;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De10a20:
                                    credito.Importe = 50000;
                                    credito.Plazo = 2;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De20a30:
                                    credito.Importe = 50000;
                                    credito.Plazo = 2;
                                    tasa = 0.14;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.MasDe30:
                                    credito.Importe = 50000;
                                    credito.Plazo = 1;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;
                            }
                            break;
                        case TipoProducto.ProductosLimpiezaHogar:

                            switch (nivelVentas)
                            {
                                case NivelVentas.MenosDe10:
                                    credito.Importe = 75000;
                                    credito.Plazo = 3;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De10a20:
                                    credito.Importe = 75000;
                                    credito.Plazo = 2;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De20a30:
                                    credito.Importe = 75000;
                                    credito.Plazo = 2;
                                    tasa = 0.14;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.MasDe30:
                                    credito.Importe = 75000;
                                    credito.Plazo = 1;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;
                            }
                            break;
                    }
                    break;

                case TipoNegocio.VentaDirecta:

                    switch (producto)
                    {

                        case TipoProducto.ModaYBelleza:

                            switch (nivelVentas)
                            {
                                case NivelVentas.MenosDe10:
                                    credito.Importe = 50000;
                                    credito.Plazo = 3;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De10a20:
                                    credito.Importe = 50000;
                                    credito.Plazo = 2;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De20a30:
                                    credito.Importe = 50000;
                                    credito.Plazo = 2;
                                    tasa = 0.14;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.MasDe30:
                                    credito.Importe = 50000;
                                    credito.Plazo = 1;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;
                            }
                            break;
                        case TipoProducto.Abarrotes:

                            switch (nivelVentas)
                            {
                                case NivelVentas.MenosDe10:
                                    credito.Importe = 100000;
                                    credito.Plazo = 3;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De10a20:
                                    credito.Importe = 100000;
                                    credito.Plazo = 2;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De20a30:
                                    credito.Importe = 100000;
                                    credito.Plazo = 2;
                                    tasa = 0.14;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.MasDe30:
                                    credito.Importe = 100000;
                                    credito.Plazo = 1;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;
                            }
                            break;
                        case TipoProducto.AlimentosPreparados:

                            switch (nivelVentas)
                            {
                                case NivelVentas.MenosDe10:
                                    credito.Importe = 50000;
                                    credito.Plazo = 3;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De10a20:
                                    credito.Importe = 50000;
                                    credito.Plazo = 2;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De20a30:
                                    credito.Importe = 50000;
                                    credito.Plazo = 2;
                                    tasa = 0.14;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.MasDe30:
                                    credito.Importe = 50000;
                                    credito.Plazo = 1;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;
                            }
                            break;
                        case TipoProducto.ProductosLimpiezaHogar:

                            switch (nivelVentas)
                            {
                                case NivelVentas.MenosDe10:
                                    credito.Importe = 100000;
                                    credito.Plazo = 3;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De10a20:
                                    credito.Importe = 100000;
                                    credito.Plazo = 2;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.De20a30:
                                    credito.Importe = 100000;
                                    credito.Plazo = 2;
                                    tasa = 0.14;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;

                                case NivelVentas.MasDe30:
                                    credito.Importe = 100000;
                                    credito.Plazo = 1;
                                    tasa = 0.12;
                                    interes = (credito.Importe * tasa * credito.Plazo);
                                    credito.PagoMensual = (credito.Importe + interes) / (credito.Plazo * numeroMeses);
                                    return credito;
                            }
                            break;
                    }
                    break;
            }
            return credito;
        }
    }
}
