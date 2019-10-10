using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Vouchers
    {
        public long Id { get; set; }
        public string CodigoVoucher { get; set; }
        public bool Estado { get; set; }
        public long IdCliente { get; set; }
        public long IdProducto { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}
