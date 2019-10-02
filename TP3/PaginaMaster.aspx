<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaMaster.aspx.cs" Inherits="TP3.PaginaMaster" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous"/>

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title></title>
</head>
<body>
<div class="p-3 mb-3 bg-dark text-white text-center"  >¡Promo Ganá!</div>

    <form id="form1" runat="server">
    <div class="Container">
        <div class="row">
        <div class="col-5 ml-3">
            <%-- TXTBOX --%>

                <asp:Label ID="lblVoucher" CssClass="badge badge-secondary" runat="server" Text="Ingresá tu voucher!"></asp:Label>
            <asp:TextBox ID="txtVoucher" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            </div>

            <div class="col-1 ml-3">
                <%-- ESPACIO EN BLANCO --%>
              </div>
            <div class="row">
                <div class="col-6 ml-3">
                    <%-- BOTON --%>
                     <asp:Button ID="btnVerificar" CssClass="btn btn-outline-secondary" runat="server" Text="Verificar" OnClick="btnVerificar_Click" />
                </div>
                </div>
            
    </div>
        </form>
  



    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>

                <footer>
                <p>&copy; <%: DateTime.Now.Year %> - Programación III, Corrionero Juan I</p>
                </footer>

</body>
</html>
