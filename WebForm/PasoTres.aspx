<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="PasoTres.aspx.cs" Inherits="WebForm.PasoTres" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1 style="margin-left: 30%;"> Ingresá tus datos. <span class="badge badge-secondary" ></span></h1>
    <div class="container">
        
        <table>
            <tr> 
                <td><p style="margin-right: 50px; margin-top: 30px;"> Ingresa tu DNI </p></td>
            </tr>
            <tr>
                
                <td> <asp:TextBox ID="txtDni" CssClass="form-control mb-2" placeholder="DNI" runat="server"></asp:TextBox>  </td>
                <td> <asp:Button ID="btnVerificar" CssClass="btn btn-outline-primary" style="margin-bottom: 6px;" runat="server" Text="Verificar" /> </td>
                
                
            </tr>
                 <tr> 
                <td><p style="margin-right: 50px; margin-top: 30px;"> Ingresa tu nombre </p></td>
                <td><p style="margin-right: 50px; margin-top: 30px; margin-left: 10px;"> Ingresa tu apellido </p></td>
                <td><p style="margin-right: 50px; margin-top: 30px; margin-left: 20px;"> Ingresa tu e-mail </p></td>

            </tr>
            <tr>
                
                <td> <asp:TextBox ID="txtNombre" CssClass="form-control mb-2" placeholder="Nombre" runat="server"></asp:TextBox>  </td>
                <td> <asp:TextBox ID="txtApellido" CssClass="form-control mb-2" style="margin-left: 10px;" placeholder="Apellido" runat="server"></asp:TextBox></td>
                <td> <asp:TextBox ID="txtEmail" CssClass="form-control mb-2" style="margin-left: 20px;" placeholder="E-mail" runat="server"></asp:TextBox>  </td>

                
                
                
            </tr>

            <tr> 
                <td><p style="margin-right: 50px; margin-top: 30px;"> Ingresa tu direccion </p></td>
                <td><p style="margin-right: 50px; margin-top: 30px; margin-left: 10px;"> Ingresa tu ciudad </p></td>
                <td><p style="margin-right: 50px; margin-top: 30px; margin-left: 20px;"> Ingresa tu codigo postal </p></td>

            </tr>
            <tr>
                
                <td> <asp:TextBox ID="txtDireccion" CssClass="form-control mb-2" placeholder="Direccion" runat="server"></asp:TextBox>  </td>
                <td> <asp:TextBox ID="txtCiudad" CssClass="form-control mb-2" style="margin-left: 10px;" placeholder="Ciudad" runat="server"></asp:TextBox></td>
                <td> <asp:TextBox ID="txtCodigoPostal" CssClass="form-control mb-2" style="margin-left: 20px;" placeholder="Codigo Postal" runat="server"></asp:TextBox>  </td>

                
                
                
            </tr>
        </table>

    </div>

    <div style="margin-left: 128px; margin-top: 30px;">
        <asp:CheckBox ID="chkBox" Text="Acepto los términos y condiciones" runat="server" />
    </div>

    <div style="margin-left: 128px; margin-top: 15px;">
        <asp:Button ID="btnAceptar" CssClass="btn btn-outline-primary" runat="server" Text="Aceptar" />
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="pie" runat="server">
</asp:Content>
