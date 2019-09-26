using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Vouchers
    {
        public int Id { get; set; }
        public string CodigoVoucher { get; set; }
        public bool Estado { get; set; }
        public int IdCliente { get; set; }
        public int IdProducto { get; set; }
        public DateTime FechaRegistro { get; set; }

    }
}
