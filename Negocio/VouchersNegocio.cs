using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class VouchersNegocio
    {
        // Funcion para validar voucher
        public Vouchers ValidarVoucher(string voucherWeb)
        {
            //Obtengo el string del voucher que ingrese el usuario, instancio datos
            AccesoDatos datos = new AccesoDatos();
            Vouchers voucher = new Vouchers();
            try
            {
                // Selecciono el codigo del voucher, con filtro del voucher que ingresa el usuario.
                datos.setearQuery("Select Id, CodigoVoucher, Estado from Vouchers where codigoVoucher = @voucher");
                datos.agregarParametro("voucher", voucherWeb);
                datos.ejecutarLector();
                if (datos.lector.Read())
                {

                    voucher.Id = datos.lector.GetInt64(0);
                    voucher.CodigoVoucher = datos.lector.GetString(1);
                    voucher.Estado = datos.lector.GetBoolean(2);

                }    
                else
                {
                    voucher = null;
                }
                return voucher;
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

        public Vouchers LeerVoucher()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("Select Id, CodigoVoucher, Estado from Vouchers");
                datos.ejecutarLector();
                Vouchers aux = new Vouchers();
                while (datos.lector.Read())
                {
                    aux.Id = datos.lector.GetInt32(0);
                    aux.CodigoVoucher = datos.lector.GetString(1);
                    aux.Estado = datos.lector.GetBoolean(2);

                }
            
                 return aux;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void ConsumirVoucher(string productoID, long idCliente, Vouchers voucherWeb)
        {

            AccesoDatos datos = new AccesoDatos();
            try
            {

            datos.setearQuery("update Vouchers set Estado = 1, IdCliente = @idCliente, IdProducto = @idProducto, FechaRegistro = GETDATE() where Id = @idVoucher");
            datos.comando.Parameters.Clear();
            datos.agregarParametro("@idCliente", idCliente);
            datos.agregarParametro("@idProducto", Convert.ToInt64(productoID));
            datos.agregarParametro("@idVoucher", voucherWeb.Id);
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
