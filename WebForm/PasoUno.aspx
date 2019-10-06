<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="PasoUno.aspx.cs" Inherits="WebForm.PasoUno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="col-4" style="margin-left: 30px;">

         <asp:Label ID="lblVoucher" CssClass="alert alert-info" runat="server" Text="Ingresa tu voucher!"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-4" style="margin-left: 30px; margin-top: 10px;">

         <asp:TextBox ID="txtVoucher" CssClass="form-control" runat="server"></asp:TextBox>
            
                <div style="margin-left: 10px; margin-top: 10px;">   
                <asp:Button ID="btnValidar" href="" CssClass="btn btn-outline-primary" runat="server" Text="Validar" OnClick="btnValidar_Click" />

                </div>
            
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
