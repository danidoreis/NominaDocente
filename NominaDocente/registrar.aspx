<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master" CodeBehind="registrar.aspx.cs" Inherits="NominaDocente.registrar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div class="campo">
    <center>
     <h1 class="titulo">Registrar</h1>
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
</asp:Content>