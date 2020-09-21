<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="modificar.aspx.cs" Inherits="NominaDocente.modificar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="campo">
    <center>
     <h1 class="titulo">Modificar</h1>
        <asp:Button ID="Usuario" class="enviar_cons" 
            runat="server" Text="Usuario" 
            Height="187px" Width="263px "  PostBackUrl="~/reg_usuario.aspx"  onclick="Usuario_Click" /> 
           
            <asp:Button ID="Perfil" class="enviar_cons"  PostBackUrl="~/reg_perfil.aspx" runat="server" Text="Perfil" 
            Height="187px" Width="263px" />
            
                <asp:Button ID="Funcion" class="enviar_cons" runat="server"  PostBackUrl="~/funcion.aspx" Text="Funcion" 
            Height="187px" Width="263px"  />
            
            
            
    </center>
    </div>
</form>
</body>
</html>
