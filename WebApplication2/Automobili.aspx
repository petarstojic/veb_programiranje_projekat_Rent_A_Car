<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Automobili.aspx.cs" Inherits="WebApplication2.Automobili" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rent a Car - Automobili</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
    <link rel="stylesheet" href="style.css">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@100&display=swap" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="meni">
                <a class="naslov_meni"><b>Rent a Car</b></a>
                <a class="meni_item" href="prijava.aspx">Prijavi se</a>
                <a class="meni_item" href="Lokacije.aspx">Lokacije</a>
                <a class="meni_item" href="Automobili.aspx">Automobili</a>
                <a class="meni_item" href="Pocetna.aspx">Pocetna</a>
            </div>
            <center>
                <h1 class="naslov">Dostupni automobili:</h1>
                <asp:GridView ID="GridView1" runat="server" CssClass="w3-table" BackColor="Black" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="12" ForeColor="White" GridLines="Horizontal">
                    <FooterStyle BackColor="Black" ForeColor="Black"></FooterStyle>

                    <HeaderStyle BackColor="#1A4D2E" Font-Bold="True" ForeColor="White"></HeaderStyle>

                    <PagerStyle HorizontalAlign="Right" BackColor="Black" ForeColor="White"></PagerStyle>

                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White"></SelectedRowStyle>
                </asp:GridView>
            </center>
        </div>
    </form>
</body>
</html>
