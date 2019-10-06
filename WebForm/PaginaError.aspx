<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="PaginaError.aspx.cs" Inherits="WebForm.PaginaError" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                <p><% = Session["Error" + Session.SessionID] %></p>
            <a class="btn btn-primary" style="margin-left: 150px; margin-bottom: 15px;" href="PasoUno.aspx">Aceptar</a>
</asp:Content>

