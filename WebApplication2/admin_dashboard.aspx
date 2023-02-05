<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin_dashboard.aspx.cs" Inherits="WebApplication2.admin_dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rent a Car - Admin Dashboard</title>
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
                <a class="meni_item" href="rezervacija.aspx">Rezervisite automobili</a>
                <a class="meni_item" href="Automobili.aspx">Automobili</a>
                <a class="meni_item" href="Pocetna.aspx">Pocetna</a>
            </div>
            <center>
                <h1 class="naslov">Izmeni/Dodaj automobile</h1>
                <asp:GridView ID="GridView1" runat="server" CssClass="w3-table" BackColor="Black" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="12" ForeColor="White" GridLines="Horizontal" AutoGenerateSelectButton="true" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <FooterStyle BackColor="Black" ForeColor="Black"></FooterStyle>

                    <HeaderStyle BackColor="#1A4D2E" Font-Bold="True" ForeColor="White"></HeaderStyle>

                    <PagerStyle HorizontalAlign="Right" BackColor="Black" ForeColor="White"></PagerStyle>

                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White"></SelectedRowStyle>
                </asp:GridView><br>
                <style>
                    #TextBox1{
                        padding: 12px;
                        border: 1px solid white;
                        border-radius: 12px;
                    }
                    #TextBox2{
                        padding: 12px;
                        border: 1px solid white;
                        border-radius: 12px;
                    }
                    #TextBox3{
                        padding: 12px;
                        border: 1px solid white;
                        border-radius: 12px;
                    }
                    #TextBox4{
                        padding: 12px;
                        border: 1px solid white;
                        border-radius: 12px;
                    }
                    #TextBox5{
                        padding: 12px;
                        border: 1px solid white;
                        border-radius: 12px;
                    }
                    #TextBox6{
                        padding: 12px;
                        border: 1px solid white;
                        border-radius: 12px;
                    }
                    #Button2 {
                        background-color: #1A4D2E;
                        padding: 12px;
                        color: white;
                        border: 2px solid #1A4D2E;
                        border-radius: 12px;
                        padding-left: 24px;
                        padding-right: 24px;
                        font-family: 'Roboto', sans-serif;
                    }
                    #Button2:hover {
                        background-color: black;
                        padding: 12px;
                        color: white;
                        border: 2px solid #1A4D2E;
                        border-radius: 12px;
                        padding-left: 24px;
                        padding-right: 24px;
                        cursor: pointer;
                        font-family: 'Roboto', sans-serif;
                    }
                    #Button3 {
                        background-color: #1A4D2E;
                        padding: 12px;
                        color: white;
                        border: 2px solid #1A4D2E;
                        border-radius: 12px;
                        padding-left: 24px;
                        padding-right: 24px;
                        font-family: 'Roboto', sans-serif;
                    }
                    #Button3:hover {
                        background-color: black;
                        padding: 12px;
                        color: white;
                        border: 2px solid #1A4D2E;
                        border-radius: 12px;
                        padding-left: 24px;
                        padding-right: 24px;
                        cursor: pointer;
                        font-family: 'Roboto', sans-serif;
                    }
                </style>
                <asp:TextBox ID="TextBox1" runat="server" BackColor="Black" ForeColor="White" Width="30%" placeholder="ID Vozila"></asp:TextBox><br><br />
                <asp:TextBox ID="TextBox2" runat="server" BackColor="Black" ForeColor="White" Width="30%" placeholder="Marka i model"></asp:TextBox><br><br />
                <asp:TextBox ID="TextBox3" runat="server" BackColor="Black" ForeColor="White" Width="30%" placeholder="Karoserija"></asp:TextBox><br><br />
                <asp:TextBox ID="TextBox4" runat="server" BackColor="Black" ForeColor="White" Width="30%" placeholder="Tip menjaca"></asp:TextBox><br><br />
                <asp:TextBox ID="TextBox5" runat="server" BackColor="Black" ForeColor="White" Width="30%" placeholder="Broj stepeni prenosa"></asp:TextBox><br><br />
                <asp:TextBox ID="TextBox6" runat="server" BackColor="Black" ForeColor="White" Width="30%" placeholder="Broj dostupnih vozila"></asp:TextBox><br><br />
                <asp:Button ID="Button1" runat="server" Text="Dodaj" OnClick="Button1_Click" />&nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Text="Izmeni" OnClick="Button2_Click" />&nbsp;&nbsp;<asp:Button ID="Button3" runat="server" Text="Obrisi" OnClick="Button3_Click"/>
                
                <h1 class="naslov">Pregled rezervacija</h1>
                <asp:GridView ID="GridView2" runat="server" CssClass="w3-table" BackColor="Black" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="12" ForeColor="White" GridLines="Horizontal">
                    <FooterStyle BackColor="Black" ForeColor="Black"></FooterStyle>

                    <HeaderStyle BackColor="#1A4D2E" Font-Bold="True" ForeColor="White"></HeaderStyle>

                    <PagerStyle HorizontalAlign="Right" BackColor="Black" ForeColor="White"></PagerStyle>

                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White"></SelectedRowStyle>
                </asp:GridView><br>

                <h1 class="naslov">Pregled lokacija</h1>
                <asp:GridView ID="GridView3" runat="server" CssClass="w3-table" BackColor="Black" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="12" ForeColor="White" GridLines="Horizontal">
                    <FooterStyle BackColor="Black" ForeColor="Black"></FooterStyle>

                    <HeaderStyle BackColor="#1A4D2E" Font-Bold="True" ForeColor="White"></HeaderStyle>

                    <PagerStyle HorizontalAlign="Right" BackColor="Black" ForeColor="White"></PagerStyle>

                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White"></SelectedRowStyle>
                </asp:GridView><br>
            </center>
        </div>
    </form>
</body>
</html>
