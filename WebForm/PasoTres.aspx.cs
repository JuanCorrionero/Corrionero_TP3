using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace WebForm
{
    public partial class PasoTres : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public Clientes CargarCliente()
        {
                Clientes cliente = new Clientes();
            try
            {
                cliente.Dni = Convert.ToInt32(txtDni.Text);
                cliente.Nombre = Convert.ToString(txtNombre.Text);
                cliente.Apellido = Convert.ToString(txtApellido.Text);
                cliente.Email = Convert.ToString(txtEmail.Text);
                cliente.Direccion = Convert.ToString(txtDireccion.Text);
                cliente.Ciudad = Convert.ToString(txtCiudad.Text);
                cliente.CodigoPostal = Convert.ToString(txtCodigoPostal.Text);
                return cliente;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        protected void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
            ClientesNegocio negocio = new ClientesNegocio();
            Clientes cliente = new Clientes();
            int dni = Convert.ToInt32(txtDni.Text);
            cliente=negocio.Validar(dni);
            if(cliente.Dni == dni)
            {
                txtApellido.Text = cliente.Apellido;
                txtNombre.Text = cliente.Nombre;
                txtDireccion.Text = cliente.Direccion;
                txtEmail.Text = cliente.Email;
                txtCiudad.Text = cliente.Ciudad;
                txtCodigoPostal.Text = cliente.CodigoPostal;
                
            }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

            Clientes cliente = new Clientes();
            ClientesNegocio clienteNegocio = new ClientesNegocio();
            VouchersNegocio voucherNegocio = new VouchersNegocio();
            Vouchers voucherWeb = new Vouchers();
            var idProducto = Request.QueryString["idProd"];
            voucherWeb = (Vouchers)Session["voucherDB"];
            if(chkBox.Checked == true)
            {
                cliente = CargarCliente();
                clienteNegocio.AltaCliente(cliente);
                long idCliente = clienteNegocio.BuscarIdCliente(cliente.Dni);
                if(idCliente == -1)
                {
                    Session.Add("Error", "Hubo un error intentando a acceder al ID del cliente.");
                    Response.Redirect("PaginaError.aspx");
                }
                voucherNegocio.ConsumirVoucher(idProducto, idCliente, voucherWeb);
                Session.Add("MailCliente", cliente.Email);
                Response.Redirect("PaginaConfirmacion");
            }

        }
    }
}