<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="PaginaConfirmacion.aspx.cs" Inherits="WebForm.PaginaConfirmacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="pie" runat="server">
<div class="alert alert-success" role="alert">
  <h4 class="alert-heading">Gracias por participar!</h4>
  <p>Tu datos fueron procesados con éxito!</p>
  <hr>
  <p class="mb-0">Te enviamos un mail con la confirmacion!</p>
</div>
</asp:Content>
