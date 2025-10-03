<%@ Page Title="Registro de Sesiones de Juego" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sesiones.aspx.cs" Inherits="ParqueRecreativoDonChucho_ASP.NET.Sesiones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Registro de Sesiones de Juego
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Registro de Sesiones de Juego</h2>
    <hr />

    <!-- ================= SECCIÓN REGISTRAR ================= -->
    <div class="form-container">
        <h3>Registrar Nueva Sesión</h3>

        <div class="form-group">
            <label for="ddl_CodigoAtraccion">Código de Atracción:</label>
            <asp:DropDownList ID="ddl_CodigoAtraccion" runat="server" CssClass="form-control">
                <asp:ListItem Text="-- Seleccione --" Value="" />
            </asp:DropDownList>
        </div>

        <div class="form-group">
            <label for="ddl_CodigoJuego">Código de Juego:</label>
            <asp:DropDownList ID="ddl_CodigoJuego" runat="server" CssClass="form-control">
                <asp:ListItem Text="-- Seleccione --" Value="" />
            </asp:DropDownList>
        </div>

        <div class="form-group">
            <label for="txt_NumeroZona">Número de Zona:</label>
            <asp:TextBox ID="txt_NumeroZona" runat="server" CssClass="form-control" />
        </div>

        <div class="form-group">
            <label for="txt_HoraInicio">Hora de Inicio:</label>
            <asp:TextBox ID="txt_HoraInicio" runat="server" CssClass="form-control" TextMode="Time" />
        </div>

        <div class="form-group">
            <label for="txt_BoletosVendidos">Cantidad de Boletos Vendidos:</label>
            <asp:TextBox ID="txt_BoletosVendidos" runat="server" CssClass="form-control" />
        </div>

        <div class="form-actions">
            <asp:Button ID="btn_RegistrarSesion" runat="server" Text="Registrar" CssClass="btn btn-primary" OnClick="btn_RegistrarSesion_Click" />
            <asp:Button ID="btn_LimpiarSesion" runat="server" Text="Limpiar" CssClass="btn btn-secondary" OnClick="btn_LimpiarSesion_Click" />
        </div>
    </div>

    <br />

    <!-- ================= SECCIÓN BUSCAR Y LISTAR ================= -->
    <div class="search-container">
        <h3>Buscar Sesiones</h3>
        
        <asp:Button ID="btn_ListarSesiones" runat="server" Text="Listar Todas" CssClass="btn btn-success" OnClick="btn_ListarSesiones_Click" />
    </div>

    <br />

    <!-- ================= LISTADO ================= -->
    <div class="list-container">
        <h3>Listado de Sesiones</h3>
        <asp:GridView ID="gv_Sesiones" runat="server" CssClass="table table-striped table-bordered" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="IdSesion" HeaderText="ID Sesión" />
                <asp:BoundField DataField="CodigoAtraccion" HeaderText="Código Atracción" />
                <asp:BoundField DataField="CodigoJuego" HeaderText="Código Juego" />
                <asp:BoundField DataField="NumeroZona" HeaderText="Zona" />
                <asp:BoundField DataField="HoraInicio" HeaderText="Hora de Inicio" />
                <asp:BoundField DataField="BoletosVendidos" HeaderText="Boletos Vendidos" />
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>
