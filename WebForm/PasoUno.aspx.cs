using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace WebForm
{
    public partial class PasoUno : System.Web.UI.Page
    {
        public Vouchers voucher;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
                       
            // Instancio el negocio del voucher
            VouchersNegocio negocio = new VouchersNegocio();
            // Valido en la base de datos el voucher
            voucher = negocio.ValidarVoucher(txtVoucher.Text);
            if(voucher == null)
            {
                Session.Add("Error", "El voucher ingresado no existe o es incorrecto, intentelo nuevamente");
                Response.Redirect("PaginaError.aspx");
            }
            else if (voucher.Estado == false)
            {
                // Si es correcto, se redirige al paso dos de la pagina.
                Session.Add("voucherDB", voucher);
                Response.Redirect("PasoDos.aspx");
            }
            else if(voucher.Estado == true)
            {
                Session["Error" + Session.SessionID] = "Tu voucher ya se usó, ingrese un voucher diferente.";
                Response.Redirect("PaginaError.aspx");
            }
               
            
            
            }
    }
}