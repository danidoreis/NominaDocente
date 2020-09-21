<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="reporte_curso.aspx.cs" Inherits="NominaDocente.reporte_curso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="Form1" runat="server" autocomplete="off" >
        <h1 class="titulo">Reporte de Cursos</h1>
        <div class="campo">
            <label>Especialidades</label>
            <asp:DropDownList ID="selEsp" runat="server" onselectedindexchanged="cargaCurso" AutoPostBack="true" required>
                <asp:ListItem Value="">Eliga una opcion</asp:ListItem>
                <asp:ListItem Value="Ciclo Basico">Ciclo Basico</asp:ListItem>
                <asp:ListItem Value="Electromecanica">Electromecanica</asp:ListItem>
                <asp:ListItem Value="Informatica Personal y Profecional">Informatica Personal y Profecional</asp:ListItem>
                <asp:ListItem Value="Maestro Mayor de Obras">Maestro Mayor de Obras</asp:ListItem>
                <asp:ListItem Value="Tecnologia de los Alimentos">Tecnologia de los Alimentos</asp:ListItem>
                <asp:ListItem Value="Programacion">Programacion</asp:ListItem>
            </asp:DropDownList>
            </div>
        <div class="campo">
            <label>Curso</label>
            <asp:DropDownList ID="selCur" runat="server" required>
                <asp:ListItem Value="">Eliga una especialidad</asp:ListItem>
            </asp:DropDownList>
        </div>
        <asp:Button ID="enviar" class="enviar_cons" runat="server" Text="Buscar Reporte de Curso" onclick="enviar_Click" />
    <div id="sinResBus">
        <span>No se encontraron resultados</span>
    </div>
    <div class="contTable campo_hor" id="resBus">
        <h1 class="titTable">Cursos</h1>
        <div class="tabla">
            <asp:GridView ID="horLunes"  runat="server" AutoGenerateColumns=false>
                <HeaderStyle  CssClass="headergridView" />
                <RowStyle CssClass="rowGridView" />
                <AlternatingRowStyle CssClass="ALtrowGridView" />
                <Columns>
                    <asp:BoundField DataField="materia" HeaderText="Lunes" />
                </Columns>
            </asp:GridView>
            <asp:GridView ID="horMartes"  runat="server" AutoGenerateColumns=false>
                <HeaderStyle  CssClass="headergridView" />
                <RowStyle CssClass="rowGridView" />
                <AlternatingRowStyle CssClass="ALtrowGridView" />
                <Columns>
                    <asp:BoundField DataField="materia" HeaderText="Martes" />
                </Columns>
            </asp:GridView>
            <asp:GridView ID="horMiercoles"  runat="server" AutoGenerateColumns=false>
                <HeaderStyle  CssClass="headergridView" />
                <RowStyle CssClass="rowGridView" />
                <AlternatingRowStyle CssClass="ALtrowGridView" />
                <Columns>
                    <asp:BoundField DataField="materia" HeaderText="Miercoles" />
                </Columns>
            </asp:GridView>
            <asp:GridView ID="horJueves"  runat="server" AutoGenerateColumns=false>
                <HeaderStyle  CssClass="headergridView" />
                <RowStyle CssClass="rowGridView" />
                <AlternatingRowStyle CssClass="ALtrowGridView" />
                <Columns>
                    <asp:BoundField DataField="materia" HeaderText="Jueves" />
                </Columns>
            </asp:GridView>
            <asp:GridView ID="horViernes"  runat="server" AutoGenerateColumns=false>
                <HeaderStyle  CssClass="headergridView" />
                <RowStyle CssClass="rowGridView" />
                <AlternatingRowStyle CssClass="ALtrowGridView" />
                <Columns>
                    <asp:BoundField DataField="materia" HeaderText="Viernes" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
    </form>
</asp:Content>
