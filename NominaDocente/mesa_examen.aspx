<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="mesa_examen.aspx.cs" Inherits="NominaDocente.mesa_examen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="popup">
    <div class="contenido_popup">
        <span>El docente fue dado de alta</span>
        <a href="#" id="close" >Ok</a>
    </div>
</div>
    <form id="formMesaExamen" runat="server" autocomplete="off">
    <div class="formCons">
        <h1 class="titulo">Registro de las Mesas de Examen</h1>
        <div class="campo">
            <label>Especialidad</label>
            <asp:DropDownList ID="selEsp" runat="server" OnSelectedIndexChanged="cargaCurso" AutoPostBack="true" required>
                <asp:ListItem Value="">Eliga una opcion</asp:ListItem>
                <asp:ListItem Value="Ciclo Basico">Ciclo Basico</asp:ListItem>
                <asp:ListItem Value="Electromecanica">Electromecanica</asp:ListItem>
                <asp:ListItem Value="Maestro Mayor de Obras">Maestro mayor de obras</asp:ListItem>
                <asp:ListItem Value="Tecnologia de los Alimentos">Tecnologias de los alimentos</asp:ListItem>
                <asp:ListItem Value="Informatica Personal y Profecional">Informatica Personal y Profecional</asp:ListItem>
                <asp:ListItem Value="Programacion">Programacion</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="campo">
            <label>Curso</label>
            <asp:DropDownList ID="selCur" runat="server" OnSelectedIndexChanged="cargaMateria" AutoPostBack="true" required>
                <asp:ListItem Value="">Eliga una especialidad</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="campo">
            <label>Materias</label>
            <asp:DropDownList ID="selMat" runat="server" required>
                <asp:ListItem Value="">Eliga un curso</asp:ListItem>
            </asp:DropDownList>
        </div>
        <asp:Button ID="envConsDoc" runat="server" Text="Buscar Docentes" 
            onclick="envConsDoc_Click" />
        </div>
        <div class="contTable" id="resBus">
            <h1 class="titTable">Docentes</h1>
            <div class="tabla">
            <asp:GridView ID="resConsConCH" runat="server" AutoGenerateColumns="false" >
            <HeaderStyle  CssClass="headergridView" />
                <RowStyle CssClass="rowGridView" />
                <AlternatingRowStyle CssClass="ALtrowGridView" />
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:RadioButton ID="dniDoc"   runat="server" onclick="radioCheck(this);" />
                        </ItemTemplate>
                    </asp:TemplateField>
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
            <div class="doc_agr ">
            <asp:Button ID="agregarDoc" runat="server" Text="Agregar Docente" 
                onclick="agregarDoc_Click" class="agregarDoc"/>
            <div class="campo">
                <label>Año</label>
                <asp:DropDownList ID="selAñoMesa" runat="server" OnSelectedIndexChanged="cargaMateriaAño" AutoPostBack="true">
                </asp:DropDownList>
            </div>
            <div class="campo">
                <label>Materia</label>
                <asp:DropDownList ID="selMatMesa" runat="server"  >
                    <asp:ListItem Value="">Eliga un año</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="campo">
                <label>Fecha</label>
                <asp:TextBox ID="dateFecha" TextMode="Date" runat="server"></asp:TextBox>
            </div>
            <div class="campo">
                <label>Horario</label>
                <asp:TextBox ID="dateHor" TextMode="Time" runat="server"></asp:TextBox>
            </div>
            </div>
            <div class="doc_agr val">
                
            <asp:LinkButton ID="borrar_agr" class="borrar_agr" runat="server"  onclick="borrar_agr_Click">Borrar a todos los docentes elegidos</asp:LinkButton>
                
                <div class="nomDoc">
                    <label>Docente N°1</label>
                    <asp:Label ID="txtDoc1" runat="server"  class="dataDoc nombre" Text="Eliga un Docente"></asp:Label>
                    <asp:Label ID="dniDoc1" runat="server"  class="dataDoc dni"></asp:Label>
                </div>
                <div class="nomDoc">
                    <label>Docente N°2</label>
                    <asp:Label ID="txtDoc2" runat="server" class="dataDoc nombre" Text="Eliga un Docente"></asp:Label>
                    <asp:Label ID="dniDoc2" runat="server"  class="dataDoc dni"></asp:Label>
                </div>
                <div class="nomDoc">
                    <label>Docente N°3</label>
                    <asp:Label ID="txtDoc3" runat="server" class="dataDoc nombre" Text="Eliga un Docente"></asp:Label>
                    <asp:Label ID="dniDoc3" runat="server"  class="dataDoc dni"></asp:Label>
                </div>
            </div>
            <asp:Button ID="enviarMesaExamen" class="envMesaExm" runat="server" Text="Grabar Mesa de Examen" onclick="enviarMesaExamen_Click"/>
        </div>
    </form>
</asp:Content>
