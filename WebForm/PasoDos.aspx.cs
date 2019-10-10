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
    public partial class PasoDos : System.Web.UI.Page
    {
        public List<Productos> ListaProductos { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ProductosNegocio negocio = new ProductosNegocio();
            ListaProductos = negocio.listar();
                        
        }

    }
}