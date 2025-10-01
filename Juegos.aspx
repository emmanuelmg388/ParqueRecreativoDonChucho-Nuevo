<%@ Page Title="Gestión de Juegos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Juegos.aspx.cs" Inherits="ParqueRecreativoDonChucho_ASP.NET.Juegos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Gestión de Juegos
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Gestión de Juegos</h2>
    <hr />

    <!-- ================= SECCIÓN REGISTRAR JUEGO ================= -->
    <div class="form-container">
        <h3>Registrar Nuevo Juego</h3>

        <div class="form-group">
            <label for="txt_CodigoJuego">Código del Juego:</label>
            <asp:TextBox ID="txt_CodigoJuego" runat="server" CssClass="form-control" />
        </div>

        <div class="form-group">
            <label for="txt_NombreJuego">Nombre del Juego:</label>
            <asp:TextBox ID="txt_NombreJuego" runat="server" CssClass="form-control" />
        </div>

        <div class="form-group">
            <label for="txt_Duracion">Duración (minutos):</label>
            <asp:TextBox ID="txt_Duracion" runat="server" CssClass="form-control" />
        </div>

        <div class="form-group">
            <label for="ddl_Categoria">Categoría:</label>
            <asp:DropDownList ID="ddl_Categoria" runat="server" CssClass="form-control">
                <asp:ListItem Text="-- Seleccione --" Value="" />
                <asp:ListItem Text="Infantil" Value="Infantil" />
                <asp:ListItem Text="Familiar" Value="Familiar" />
                <asp:ListItem Text="Extremo" Value="Extremo" />
                <asp:ListItem Text="Interactivos" Value="Interactivos" />
                <asp:ListItem Text="Virtuales" Value="Virtuales" />
                <asp:ListItem Text="Competitivos" Value="Competitivos" />
            </asp:DropDownList>
        </div>

        <div class="form-actions">
            <asp:Button ID="btn_RegistrarJuego" runat="server" Text="Registrar" CssClass="btn btn-primary" OnClick="btn_RegistrarJuego_Click" />
            <asp:Button ID="btn_LimpiarCampos" runat="server" Text="Limpiar" CssClass="btn btn-secondary" OnClick="btn_LimpiarCampos_Click" />
        </div>
    </div>

    <br />

    <!-- ================= SECCIÓN BUSCAR Y LISTAR ================= -->
    <div class="search-container">
        <h3>Buscar Juegos</h3>
        <div class="form-group">
            <asp:TextBox ID="txt_BuscarJuego" runat="server" CssClass="form-control" Placeholder="Ingrese código o nombre del juego..." />
        </div>
        <asp:Button ID="btn_BuscarJuego" runat="server" Text="Buscar" CssClass="btn btn-info" OnClick="btn_BuscarJuego_Click" />
        <asp:Button ID="btn_ListarTodos" runat="server" Text="Listar Todos" CssClass="btn btn-success" OnClick="btn_ListarTodos_Click" />
    </div>

    <br />

    <!-- ================= LISTADO ================= -->
    <div class="list-container">
        <h3>Listado de Juegos</h3>
        <asp:GridView ID="gv_Juegos" runat="server" CssClass="table table-striped table-bordered" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="CodigoJuego" HeaderText="Código" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Duracion" HeaderText="Duración (min)" />
                <asp:BoundField DataField="Categoria" HeaderText="Categoría" />
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>
