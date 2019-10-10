<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="PasoUno.aspx.cs" Inherits="WebForm.PasoUno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <div class="col-4" style="margin:auto; margin-bottom: 30px; margin-top: auto">

         <asp:Label ID="lblVoucher" CssClass="alert alert-info" runat="server" Text="Ingresa tu voucher!"></asp:Label>
        </div>
    
        <div class="col-4" style="margin:auto">

         <asp:TextBox ID="txtVoucher" CssClass="form-control" runat="server"></asp:TextBox>
            
                <div style="margin:auto; margin-top: 20px;">   
                <asp:Button ID="btnValidar" href="" CssClass="btn btn-outline-primary" runat="server" Text="Validar" OnClick="btnValidar_Click" />

                </div>
            
                <div class="col-6 m-3">
                    <div style="margin:auto; margin-top: 20px;">
            <span>
                     <asp:Label ID="lblError" Text="" cssClass="" runat="server"></asp:Label>
            </span>
                    </div>
                </div>
        </div>
    
</asp:Content>
