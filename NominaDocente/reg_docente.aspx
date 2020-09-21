<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="reg_docente.aspx.cs" Inherits="NominaDocente.reg_docente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="popup">
    <div class="contenido_popup">
        <span>El docente fue dado de alta</span>
        <a href="#" id="close" >Ok</a>
    </div>
</div>

<form runat="server" autocomplete="off">
    <h1 class="titulo">Registro Docente</h1>
    <div class="campo">
        <label>Nombre</label>
        <INPUT type="text" id="txtNombre"  runat="server" pattern="[a-zA-Z _]{0,50}" required autofocus>
    </div>
    <div class="campo">
        <label>Apellido</label>
        <INPUT type="text" id="txtApellido"  runat="server" pattern="[a-zA-Z _]{0,50}" required> 
    </div>
    <div class="campo">
        <label>D.N.I</label>
        <input type="text" id="txtDni" runat="server" pattern="[0-9]{8}" required>
    </div>
    <div class="campo">
        <label>Fecha de  Nacimiento</label>
        <asp:TextBox ID="dateFechaNacimiento" TextMode="Date" runat="server" required></asp:TextBox>
    </div>
    <div class="campo">
        <label>Numero de legajo</label>
        <INPUT type="text" id="txtNroLej"  runat="server" required> 
    </div>
    <div class="campo">
        <label>Telefono</label>
        <asp:TextBox ID="txtTel"  runat="server" pattern="[+0-9]{6,13}" required></asp:TextBox>
    </div>
    <div class="campo">
        <label>Domicilio</label>
        <INPUT type="text" id="txtDomicilio"  runat="server" required> 
    </div>
    <div class="campo">
        <label>Correo Electronico</label>
        <asp:TextBox ID="mail" TextMode="Email" runat="server" required></asp:TextBox>
    </div>
    <div class="campo">
        <label>Fecha de ingreso en la docencia</label>
        <asp:TextBox ID="dateFechaIngDocencia" TextMode="Date" runat="server" required></asp:TextBox>
    </div>
    <div class="campo">
        <label>Fecha de ingreso en el establecimiento</label>
        <asp:TextBox ID="dateFechaIngEst" TextMode="Date" runat="server" required></asp:TextBox>
    </div>
    <asp:Button ID="enviar" class="enviar_docente" runat="server" Text="Registrar Docente" onclick="enviar_Click" />
</form>
</asp:Content>
