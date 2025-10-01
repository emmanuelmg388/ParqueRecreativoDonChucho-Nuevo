<%@ Page Title="Gestión de Atracciones" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Atracciones.aspx.cs" Inherits="ParqueRecreativoDonChucho_ASP.NET.Atracciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Gestión de Atracciones
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Gestión de Atracciones</h2>
    <hr />

    <!-- ================= SECCIÓN REGISTRAR ================= -->
    <div class="form-container">
        <h3>Registrar Nueva Atracción</h3>

        <div class="form-group">
            <label for="txt_CodigoAtraccion">Código de Atracción:</label>
            <asp:TextBox ID="txt_CodigoAtraccion" runat="server" CssClass="form-control" />
        </div>

        <div class="form-group">
            <label for="txt_NombreAtraccion">Nombre de Atracción:</label>
            <asp:TextBox ID="txt_NombreAtraccion" runat="server" CssClass="form-control" />
        </div>

        <div class="form-group">
            <label for="txt_PrecioEntrada">Precio de Entrada:</label>
            <asp:TextBox ID="txt_PrecioEntrada" runat="server" CssClass="form-control" />
        </div>

        <div class="form-group">
            <label for="txt_CapacidadMaxima">Capacidad Máxima:</label>
            <asp:TextBox ID="txt_CapacidadMaxima" runat="server" CssClass="form-control" />
        </div>

        <div class="form-actions">
            <asp:Button ID="btn_RegistrarAtraccion" runat="server" Text="Registrar" CssClass="btn btn-primary" />
            <asp:Button ID="btn_LimpiarRegistro" runat="server" Text="Limpiar" CssClass="btn btn-secondary" />
        </div>
    </div>

    <br />

    <!-- ================= SECCIÓN ACTUALIZAR ================= -->
    <div class="form-container">
        <h3>Actualizar Atracción</h3>

        <!-- Solo el código habilitado de inicio -->
        <div class="form-group">
            <label for="txt_CodigoAtraccionUpd">Código de Atracción:</label>
            <asp:TextBox ID="txt_CodigoAtraccionUpd" runat="server" CssClass="form-control" />
            <asp:Button ID="btn_BuscarAtraccionUpd" runat="server" Text="Buscar" CssClass="btn btn-info" />
        </div>

        <!-- Estos campos estarán bloqueados hasta que se busque la atracción -->
        <div class="form-group">
            <label for="txt_NombreAtraccionUpd">Nombre de Atracción:</label>
            <asp:TextBox ID="txt_NombreAtraccionUpd" runat="server" CssClass="form-control" Enabled="false" />
        </div>

        <div class="form-group">
            <label for="txt_PrecioEntradaUpd">Precio de Entrada:</label>
            <asp:TextBox ID="txt_PrecioEntradaUpd" runat="server" CssClass="form-control" Enabled="false" />
        </div>

        <div class="form-group">
            <label for="txt_CapacidadMaximaUpd">Capacidad Máxima:</label>
            <asp:TextBox ID="txt_CapacidadMaximaUpd" runat="server" CssClass="form-control" Enabled="false" />
        </div>

        <div class="form-actions">
            <asp:Button ID="btn_ActualizarAtraccion" runat="server" Text="Actualizar" CssClass="btn btn-warning" Enabled="false" />
            <asp:Button ID="btn_CancelarUpd" runat="server" Text="Cancelar" CssClass="btn btn-secondary" />
        </div>
    </div>

    <br />

    <!-- ================= SECCIÓN BUSCAR Y LISTAR ================= -->
    <div class="search-container">
        <h3>Buscar Atracciones</h3>
        <div class="form-group">
            <asp:TextBox ID="txt_BuscarAtraccion" runat="server" CssClass="form-control" Placeholder="Ingrese código o nombre de la atracción..." />
        </div>
        <asp:Button ID="btn_BuscarAtraccion" runat="server" Text="Buscar" CssClass="btn btn-info" />
        <asp:Button ID="btn_ListarAtracciones" runat="server" Text="Listar Todas" CssClass="btn btn-success" />
    </div>

    <br />

    <!-- ================= LISTADO ================= -->
    <div class="list-container">
        <h3>Listado de Atracciones</h3>
        <asp:GridView ID="gv_Atracciones" runat="server" CssClass="table table-striped table-bordered" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="CodigoAtraccion" HeaderText="Código" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="PrecioEntrada" HeaderText="Precio Entrada" />
                <asp:BoundField DataField="CapacidadMaxima" HeaderText="Capacidad Máxima" />
            </Columns>
        </asp:GridView>
    </div>

</asp:Content>
