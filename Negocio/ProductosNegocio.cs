using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ProductosNegocio
    {

        public List<Productos> listar()
        {
            List<Productos> lista = new List<Productos>();
            AccesoDatos datos = new AccesoDatos();
            Productos productos;
            try
            {
                datos.setearQuery("Select Id, Titulo, Descripcion, URLImagen from Productos");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    productos = new Productos();
                    productos.Id = datos.lector.GetInt64(0);
                    productos.Titulo = datos.lector.GetString(1);
                    productos.Descripcion = datos.lector.GetString(2);
                    productos.UrlImagen = datos.lector.GetString(3);

                    lista.Add(productos);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
