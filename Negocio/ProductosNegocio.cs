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
        public Productos cargarAuricular()
        {
            AccesoDatos datos = new AccesoDatos();
            Productos prodAuricular = new Productos();
            try
            {
            datos.setearQuery("select Titulo, Descripcion, URLImagen from Productos where Titulo = 'Auriculares Razer'");
            datos.ejecutarLector();
            if (datos.lector.Read())
            {
            
            prodAuricular.Titulo = datos.lector.GetString(0);
            prodAuricular.Descripcion = datos.lector.GetString(1);
            prodAuricular.UrlImagen = datos.lector.GetString(2);
            return prodAuricular;
             }

            }
            catch (Exception ex)
            {

                throw ex;
            }

            prodAuricular.Titulo = "ERROR";
            prodAuricular.Descripcion = "ERROR";
            prodAuricular.UrlImagen = "ERROR";
            return prodAuricular;

        }

        public Productos cargarCombo()
        {
            Productos prodCombo = new Productos();
            AccesoDatos datos = new AccesoDatos();
            try
            {
            datos.setearQuery("select Titulo, Descripcion, URLImagen from Productos where Titulo = 'Combo Razer'");
            datos.ejecutarLector();
            if (datos.lector.Read())
            {
            prodCombo.Titulo = datos.lector.GetString(0);
            prodCombo.Descripcion = datos.lector.GetString(1);
            prodCombo.UrlImagen = datos.lector.GetString(2);
            return prodCombo;
            }


            }
            catch (Exception ex)
            {
                throw ex;
            }
                prodCombo.Descripcion = "ERROR";
                prodCombo.Titulo = "ERROR";
                prodCombo.UrlImagen = "ERROR";
                return prodCombo;

               
            

        }

        public Productos cargarMochila()
        {
            AccesoDatos datos = new AccesoDatos();
            Productos prodMochila = new Productos();
            try
            {

            datos.setearQuery("select Titulo, Descripcion, URLImagen from Productos where Titulo = 'Mochila Gaming'");
            datos.ejecutarLector();
                if (datos.lector.Read())
                {

                    prodMochila.Titulo = datos.lector.GetString(0);
                    prodMochila.Descripcion = datos.lector.GetString(1);
                    prodMochila.UrlImagen = datos.lector.GetString(2);
                    return prodMochila;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

            prodMochila.Titulo = "ERROR";
            prodMochila.Descripcion = "ERROR";
            prodMochila.UrlImagen = "ERROR";
            return prodMochila;

        }


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
