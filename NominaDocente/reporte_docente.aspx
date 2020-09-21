<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="reporte_docente.aspx.cs" Inherits="NominaDocente.reporte_docente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="Form1" runat="server" autocomplete="off" >
        <h1 class="titulo">Reporte Carga Horaria</h1>
        <div class="campo">
            <label>Nombre</label>
            <input type="text" id="txtNombre" runat="server" autofocus required />
        </div>
        <div class="campo">
            <label>Apellido</label>
            <input type="text" id="txtApellido" runat="server" />
        </div>
        <div class="campo">
            <label>Especialidades</label>
            <asp:DropDownList ID="selEsp" runat="server" OnSelectedIndexChanged="cargaCurso" AutoPostBack=true>
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
            <asp:DropDownList ID="selCur" runat="server" OnSelectedIndexChanged="cargaMateria" AutoPostBack=true>
                <asp:ListItem Value="">Eliga una especialidad</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="campo">
            <label>Materias</label>
            <asp:DropDownList ID="selMat" runat="server">
                <asp:ListItem Value="">Eliga un curso</asp:ListItem>
            </asp:DropDownList>
        </div>
        <asp:Button ID="enviar" class="enviar_cons" runat="server" Text="Buscar Reporte Docente" onclick="enviar_Click" />
    <div id="sinResBus">
        <span>No se encontraron resultados</span>
    </div>
    <div class="contTable" id="resBus">
    <h1 class="titTable">Docentes</h1>
    <div class="tabla">
        <asp:GridView ID="resConsConCH" runat="server" AutoGenerateColumns="false">
        <HeaderStyle  CssClass="headergridView" />
            <RowStyle CssClass="rowGridView" />
            <AlternatingRowStyle CssClass="ALtrowGridView" />
            <Columns>
                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="apellido" HeaderText="Apellido" />
                <asp:BoundField DataField="dni" HeaderText="D.N.I" />
                <asp:BoundField DataField="nroLegajo" HeaderText="Numero de legajo" />
                <asp:BoundField DataField="especialidad" HeaderText="Especilidad" />
                <asp:BoundField DataField="curso" HeaderText="Curso" />
                <asp:BoundField DataField="materia" HeaderText="Materia" />
                <asp:BoundField DataField="dia" HeaderText="Dia" />
                <asp:BoundField DataField="horario" HeaderText="Horario" />
                <asp:BoundField DataField="cant_modulos" HeaderText="Cantidad de modulos" />
            </Columns>
        </asp:GridView>
    </div>
    </div>
    </form>
</asp:Content>
