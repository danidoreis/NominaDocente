<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="cons_docente.aspx.cs" Inherits="NominaDocente.cons_docente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" autocomplete="off" >
        <h1 class="titulo">Busqueda Docente</h1>
        <div class="campo">
            <label>Nombre</label>
            <input type="text" id="txtNombre" runat="server" pattern="[a-zA-Z _]{0,50}" autofocus required />
        </div>
        <div class="campo">
            <label>Apellido</label>
            <input type="text" id="txtApellido" runat="server" pattern="[a-zA-Z _]{0,50}" />
        </div>
        <div class="campo">
            <label>D.N.I</label>
            <input type="text" id="txtDni" runat="server" pattern="[0-9]{8}" />
        </div>
        <asp:Button ID="enviar" class="enviar_cons" runat="server" Text="Buscar Docente" onclick="enviar_Click" />
    <div id="sinResBus">
        <span>No se encontraron resultados</span>
    </div>
    <div class="contTable" id="resBus">
    <h1 class="titTable">Docentes</h1>
    <div class="tabla">
    <asp:GridView ID="resConsSinCH" runat="server" AutoGenerateColumns="false">
    <HeaderStyle  CssClass="headergridView" />
        <RowStyle CssClass="rowGridView" />
        <AlternatingRowStyle CssClass="ALtrowGridView" />
        <Columns>
            <asp:BoundField DataField="nombre" HeaderText="Nombre" ItemStyle-Width="100px" />
            <asp:BoundField DataField="apellido" HeaderText="Apellido" />
            <asp:BoundField DataField="dni" HeaderText="D.N.I" />
            <asp:BoundField DataField="fechaNacimiento" HeaderText="Fecha de nacimiento" />
            <asp:BoundField DataField="nroLegajo" HeaderText="Numero de legajo" />
            <asp:BoundField DataField="telefono" HeaderText="Telefono" />
            <asp:BoundField DataField="domicilio" HeaderText="Domicilio" />
            <asp:BoundField DataField="Email" HeaderText="E-Mail" />
            <asp:BoundField DataField="fechaIngDocencia" HeaderText="Fecha ingreso a la docencia" />
            <asp:BoundField DataField="fechaIngEst" HeaderText="Fecha ingreso al establecimiento" />
        </Columns>
    </asp:GridView>
    </div>
    </div>
    </form>
</asp:Content>