<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pocetna.aspx.cs" Inherits="WebApplication2.Pocetna" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rent a Car - Pocetna</title>
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
            <h1 class="naslov" align="center">Dobrodosli na sajt Rent a Car agencije!</h1>
            <h3 align="center">Na ovom sajtu mozete iznajmiti auto prema vasim potrebama. Nudimo sirok izbor automobila.</h3>
            <img class="velika_slika" src="https://www.rentacaraerodrom.rs/wp-content/uploads/2015/04/car-rental-5-cars.png"/>
        </div>
    </form>
</body>
</html>
