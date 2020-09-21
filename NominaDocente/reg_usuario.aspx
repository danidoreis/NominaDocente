<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="reg_usuario.aspx.cs" Inherits="NominaDocente.reg_usuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="popup">
    <div class="contenido_popup">
        <span>El usuario fue dado de alta</span>
        <a href="#" id="close" >Ok</a>
    </div>
</div>
  <form id="Form1" runat="server">
   <h1 class="titulo">Registro Usuario</h1> 
        
        <div class="campo">
        <label>Nombre: </label>
        <INPUT type="text" id="txtNombre"  runat="server" required>
        </div>   
        <div class="campo">
        <label>Contraseña: </label>
        <INPUT type="text" id="txtPassword"  runat="server"  required> 
        </div>   
        <div class="campo">
        <label>D.N.I: </label>
        <input type="text" id="txtDni" runat="server" pattern="[0-9]{8}" required>
        </div>
        <div class="campo">
        <label>Perfil:  </label>
        <asp:CheckBoxList ID="Perfiles" runat="server">
           
        </asp:CheckBoxList>
    </div>

                 <asp:Button ID="Registrar" class="enviar_cons" runat="server" 
             Text="Registrar" onclick="Registrar_Click"/>
                 <label runat="server" visible="false" id="Exito">El usuario fue dado de alta</label>
    </form> 
</asp:Content>
