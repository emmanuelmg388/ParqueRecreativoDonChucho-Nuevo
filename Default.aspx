<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ParqueRecreativoDonChucho_ASP.NET.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">Inicio </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Bienvenido al Parque Recreativo Don Chucho</h1>
    <p>Este sistema le permitirá administrar: </p>
    <ul>
        <li><strong>Atracciones</strong>: registrar, modificar y consultar atracciones del parque.</li>
        <li><strong>Juegos</strong>: gestionar la información de cada juego.</li>
        <li><strong>Sesiones</strong>: registrar las sesiones programadas de los juegos en cada atracción.</li>
    </ul>
    <p>Use el menú lateral para navegar entre las secciones. </p>
</asp:Content>
