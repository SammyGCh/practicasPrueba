using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaDeArbitraje;
using System.Collections.ObjectModel;

namespace SistemaDeArbitraje.ArticuloAdmin
{
    public static class AdministradorArticulos
    {
        public static void Evaluar(Articulo articulo)
        {
            var bd = new ArticulosPruebaEntities();
            var resultado = bd.Articulos.SingleOrDefault(b => b.IdArticulo == articulo.IdArticulo);
            if (resultado != null)
            {
                resultado.Estado = articulo.Estado;
                resultado.calificacion = articulo.calificacion;
                bd.SaveChanges();
            }
        }

        public static void Liberar(Articulo articulo)
        {
            var bd = new ArticulosPruebaEntities();
            var resultado = bd.Articulos.SingleOrDefault(b => b.IdArticulo == articulo.IdArticulo);
            if (resultado != null)
            {
                resultado.Estado = "Liberado";
                bd.SaveChanges();
            }
        }
    }
}
