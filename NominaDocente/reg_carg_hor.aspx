<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="reg_carg_hor.aspx.cs" Inherits="NominaDocente.reg_materia" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="popup">
    <div class="contenido_popup">
        <span>El docente fue dado de alta</span>
        <a href="#" id="close" >Ok</a>
    </div>
</div>
    <form runat="server" id="formRegHor" autocomplete="off">
        <h1 class="titulo">Registro Carga Horaria</h1>
        <div class="campo">
            <label>Nombre</label>
            <INPUT type="text" id="txtNombre"  runat="server" pattern="[a-zA-Z _]{0,50}" required >
        </div>
        <div class="campo">
            <label>Apellido</label>
            <input type="text" id="txtApellido" runat="server" pattern="[a-zA-Z _]{0,50}" />
        </div>
        <div class="campo">
            <label>D.N.I</label>
            <INPUT type="text" id="txtDni"  runat="server" pattern="[0-9]{8}" > 
        </div>
        <asp:Button ID="enviar" runat="server" Text="Registrar" onclick="enviar_Click" />
        <%--<a href="reg_docente.aspx">Registrar Docente</a>--%>
        <div id="sinResBus">
            <span>No se encontraron resultados</span>
        </div>
        <div class="contTable" id="resBus">
        <h1 class="titTable">Docentes</h1>
        <div class="tabla">
            <asp:GridView ID="resConsSinCH" runat="server" AutoGenerateColumns="false"  >
            <HeaderStyle  CssClass="headergridView" />
                <RowStyle CssClass="rowGridView" />
                <AlternatingRowStyle CssClass="ALtrowGridView" />
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:RadioButton ID="dniDoc"   runat="server" onclick="radioCheck(this);" />
                        </ItemTemplate>
                    </asp:TemplateField>
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
            <div class="campo">
                <label>Especialidad</label>
                <asp:DropDownList ID="selEsp" runat="server" onselectedindexchanged="cargaCurso" AutoPostBack=true  >
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
                <asp:DropDownList ID="selCur" runat="server" onselectedindexchanged="cargaMateria" AutoPostBack=true >
                    <asp:ListItem Value="">Eliga una especialidad</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="campo">
                <label>Materia</label>
                <asp:DropDownList ID="selMat" runat="server" >
                    <asp:ListItem Value="">Eliga un curso</asp:ListItem>
                </asp:DropDownList>
            </div>
            <asp:Button ID="enviar_horarios"  runat="server" Text="Registrar materia"   onclick="enviar_horarios_Click"  />  
        </div>
        <asp:TextBox ID="fondo_pantalla" class="fondo_pantalla" runat="server"></asp:TextBox>
    </form>
</asp:Content>
