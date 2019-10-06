<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="PasoUno.aspx.cs" Inherits="WebForm.PasoUno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-4 m-3">

         <asp:Label ID="lblVoucher" CssClass="alert alert-info" runat="server" Text="Ingresa tu voucher!"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-4 m-3">

         <asp:TextBox ID="txtVoucher" CssClass="form-control" runat="server"></asp:TextBox>
            <span> 
                <asp:Button ID="btnValidar" href="" CssClass="btn btn-outline-primary" runat="server" Text="Validar" OnClick="btnValidar_Click" />
            </span>
                <div class="col-6 m-3">
                    <div class="row">
            <span>
                     <asp:Label ID="lblError" Text="" cssClass="" runat="server"></asp:Label>
            </span>
                    </div>
                </div>
        </div>
    </div>
</asp:Content>
