<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="prijava.aspx.cs" Inherits="WebApplication2.prijava" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rent a Car - Prijava</title>
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
                <h1 class="naslov">Unesite korisnicko ime i lozinku:</h1>
                <asp:Label ID="ErrorLabel" runat="server" Text="" ForeColor="Red"></asp:Label><br>
                <asp:TextBox ID="username" runat="server" BackColor="Black" ForeColor="White" Width="30%" placeholder="username"></asp:TextBox><br><br>
                <asp:TextBox ID="password" runat="server" BackColor="Black" ForeColor="White" Width="30%" TextMode="Password" placeholder="password"></asp:TextBox><br><br>
                <asp:Button ID="Button1" runat="server" Text="Prijava" OnClick="Button1_Click"/>
            </center>
        </div>
    </form>
</body>
</html>
