<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="reporte_mesa_examen.aspx.cs" Inherits="NominaDocente.reporte_mesa_examen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<form id="Form1" runat="server" autocomplete="off" >
    <h1 class="titulo">Reporte de las Mesas de Examen</h1>
    <div class="campo">
        <label>Tipo de Busqueda</label>
        <asp:DropDownList ID="selTipoBus" runat="server">
            <asp:ListItem Value="">Eliga una opcion</asp:ListItem>
            <asp:ListItem Value=0>Igual a la fecha</asp:ListItem>
            <asp:ListItem Value=1>Mayor o igual a la fecha</asp:ListItem>
            <asp:ListItem Value=2>Menor o igual a la fecha</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div class="campo">
        <label>Fecha</label>
        <asp:TextBox ID="dateFecha" runat="server" TextMode="Date" required></asp:TextBox>
    </div>
    <asp:Button ID="bus_mesa" runat="server" Text="Buscar Mesa de Examen" onclick="bus_mesa_Click" />
    <div id="sinResBus">
        <span>No se encontraron resultados</span>
    </div>
    <div class="contTable" id="resBus">
        <div class="tabla">
            <asp:GridView ID="tbl_rpt_mes_exm" runat="server" AutoGenerateColumns="false">
            <HeaderStyle  CssClass="headergridView" />
                <RowStyle CssClass="rowGridView" />
                <AlternatingRowStyle CssClass="ALtrowGridView" />
                <Columns>
                    <asp:BoundField DataField="año" HeaderText="Año"  />
                    <asp:BoundField DataField="materia" HeaderText="Materia"  />
                    <asp:BoundField DataField="docente1" HeaderText="Docente N° 1"  />
                    <asp:BoundField DataField="docente2" HeaderText="Docente N° 2"  />
                    <asp:BoundField DataField="docente3" HeaderText="Docente N° 3"  />
                    <asp:BoundField DataField="fecha" HeaderText="Fecha"  />
                    <asp:BoundField DataField="horario" HeaderText="Hora"  />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</form>
</asp:Content>
