using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ClientesNegocio
    {

        public Clientes Validar(int dni)
        {
            AccesoDatos datos = new AccesoDatos();
            Clientes cliente = new Clientes();

            try
            {
                // seteo la query
                    datos.setearQuery("Select C.DNI, C.Nombre, C.Apellido, C.Email, C.Direccion, C.Ciudad, C.CodigoPostal from Clientes as C where C.DNI = @DNI ");
                // Agrego el parametro @DNI que lo obtengo desde el dni que traigo de la pagina web.
                    datos.agregarParametro("@DNI", dni);
                // Ejecuto la lectura, a partir del Where @DNI (WEB) = C.DNI que me traigo en la base de datos
                    datos.ejecutarLector();
                // Si el DNI del cliente concuerda con el dni que traigo de la página ,hubo una coincidencia
                    if (datos.lector.Read())
                    {
                    // Cargo los datos en una instancia nueva de cliente
                        cliente.Dni = datos.lector.GetInt32(0);
                        cliente.Nombre = datos.lector.GetString(1);
                        cliente.Apellido = datos.lector.GetString(2);
                        cliente.Email = datos.lector.GetString(3);
                        cliente.Direccion = datos.lector.GetString(4);
                        cliente.Ciudad = datos.lector.GetString(5);
                        cliente.CodigoPostal = datos.lector.GetString(6);
                                              
                    }

                    else
                    {
                    // Si no, le asigno null al cliente
                        cliente = null;
                    }
                    // Devuelvo los datos o un cliente nulo.
                    return cliente;
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

        public long BuscarIdCliente(int dni)
        {
                AccesoDatos datos = new AccesoDatos();
                Clientes cliente = new Clientes();
            try
            {
                datos.setearQuery("Select Id from Clientes @dni = DNI");
                datos.comando.Parameters.Clear();
                datos.agregarParametro("@dni", dni);
                datos.ejecutarLector();
                if (datos.lector.Read())
                    return cliente.Id;
            }
            catch (Exception ex)
            {
                return -1;
                throw ex;
            }
            

            finally
            {
                datos.cerrarConexion();
            }

            return -1;
        }

        public void AltaCliente(Clientes clienteWeb)
        {
            // Instancio al cliente.
            AccesoDatos datos = new AccesoDatos();

            try
            {

                // Hago el insert a partir del objeto cliente que traigo de la pagina WEB.
            datos.setearQuery("Insert into Clientes values(@DNI,@Nombre,@Apellido,@Email,@Direccion,@Ciudad,@CodigoPostal,GETDATE())");
                // Agrego los parametros para adentrarlos en el insert.
            datos.comando.Parameters.Clear();
            datos.agregarParametro("@DNI", clienteWeb.Dni);
            datos.agregarParametro("@Nombre", clienteWeb.Nombre);
            datos.agregarParametro("Apellido", clienteWeb.Apellido);
            datos.agregarParametro("@Email", clienteWeb.Email);
            datos.agregarParametro("@Direccion", clienteWeb.Direccion);
            datos.agregarParametro("@Ciudad", clienteWeb.Ciudad);
            datos.agregarParametro("@CodigoPostal", clienteWeb.CodigoPostal);
                // Ejecuta la accion que es una "NO QUERY" - "NO CONSULTA".-
            datos.ejecutarAccion();

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
