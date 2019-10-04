﻿using System;
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
                // Si no existe o está usado, muestro labels de error y pongo la textbox vacía.
                txtVoucher.Text = "";
                lblError.Text = "Error al validar tu voucher, Reintente";
                lblError.CssClass = "alert alert-danger";
            }
        }
    }
}