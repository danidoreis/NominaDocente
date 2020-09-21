<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="reg_funcion.aspx.cs" Inherits="NominaDocente.reg_funcion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="popup">
    <div class="contenido_popup">
        <span> La funcion fue dada de alta</span>
        <a href="#" id="close" >Ok</a>
    </div>
</div>
    <title></title>
</head>
<body>
    <form runat="server">
    
    <h1 class="titulo">Registro Función</h1>
    <div class="campo">
        <label>Nombre: </label>
        <INPUT type="text" id="txtNombre"  runat="server" pattern="[a-zA-Z _]{0,50}" required autofocus>
    </div>
    <div class="campo">
        <label>URL: </label>
        <INPUT type="text" id="txtUrl"  runat="server"> 
    </div>

    <div class="campo">
        <label>Función Padre:  </label>
        <asp:DropDownList ID="ddlFuncionesPadre" runat="server">
        </asp:DropDownList>
    </div>

    <asp:Button ID="enviar" class="enviar_funcion" runat="server" Text="Registrar Función" onclick="enviar_Click" />

    </form>

</body>
</html>
</asp:Content>
