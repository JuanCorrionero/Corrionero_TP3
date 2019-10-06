<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="PasoDos.aspx.cs" Inherits="WebForm.PasoDos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="alert alert-success" role="alert">
  <h4 class="alert-heading">Voucher verificado!</h4>
  <p>Tu voucher ha sido validado con éxito!</p>
  <hr>
  <p class="mb-0">Ahora lo que resta es elegir un premio para participar!</p>
</div>

    <div class="card-columns" style="margin-left: 10px; margin-right: 10px;">

        <%-- Codigo c# --%>
        <% foreach (var item in ListaProductos)
            { %>
  <div class="card">
    <img src="<%= item.UrlImagen %>" class="card-img-top" alt="...">
    <div class="card-body">
      <h5 class="card-title"><%= item.Titulo %></h5>
      <p class="card-text"><%= item.Descripcion %></p>
    </div>
       <a class="btn btn-primary" style="margin-left: 150px; margin-bottom: 15px;" href="PasoTres.aspx?idProd=<% = item.Id.ToString() %>">Seleccionar</a>
      </div>
            
           <% } %>

        </div>  




</asp:Content>
