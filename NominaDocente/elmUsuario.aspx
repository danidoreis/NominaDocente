<%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="elmUsuario.aspx.cs" Inherits="NominaDocente.elmUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="popup">
    <div class="contenido_popup">
        <span> Usuario Eliminado</span>
        <a href="#" id="close" >Ok</a>
    </div>
</div>
    <title></title>
    <html>
    <head>
</head>
<body>
    <form id="form1" runat="server">
    <h1 class="titulo">Eliminar Usuario </h1>
    <div class="campo">
        <label>Elegir Usuario:  </label>
        <asp:DropDownList ID="ddlELM" runat="server">
        </asp:DropDownList>
        <br />
        <br />

    

    <asp:Button ID="enviar_eliminar" class="enviar_usuario" runat="server" Text="Eliminar" onclick="enviar_Click" />

    </div>
    </form>
</body>

</html>
</asp:Content>
