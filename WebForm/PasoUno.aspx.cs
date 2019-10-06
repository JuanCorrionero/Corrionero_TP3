using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace WebForm
{
    public partial class PasoUno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            // Instancio el negocio del voucher
            VouchersNegocio negocio = new VouchersNegocio();
            // Valido en la base de datos el voucher
            if (negocio.ValidarVoucher(txtVoucher.Text))
            {
                // Si es correcto, se redirige al paso dos de la pagina.
                Response.Redirect("PasoDos.aspx");
            }
            else
            {
                Session["Error" + Session.SessionID] = "Tu voucher es incorrecto o ya está en uso, intentelo de nuevo.";
                Response.Redirect("PaginaError.aspx");
            }
               
            
            
            }
    }
}