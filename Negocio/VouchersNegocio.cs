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
        public bool ValidarVoucher(string voucherWeb)
        {
            bool leyo = true;
             while (leyo)
            {
                Vouchers aux = new Vouchers();
                aux = LeerVoucher();
                if(aux.CodigoVoucher = voucherWeb)
                {
                    return true;
                }
                leyo = false;
            }
            return false;
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
    }
}
