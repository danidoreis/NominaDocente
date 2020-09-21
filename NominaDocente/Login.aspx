<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="NominaDocente.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Iniciar Sesion</title>
  
    </script>
    <script type="text/javascript" language="javascript">
        javascript: window.history.forward(1);
    </script>

</head>
<body>
       <center> <form id="form1" runat="server">

 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
  
  <h1>Iniciar Sesión
  </h1><h2>
    <table>
   <tr>




       <div class="campo">
      <td class="style2">Usuario:</td>
      <td class="style2"><INPUT type="text" id="txtUserName"  runat="server"/></td>
      <td class="style2"><!--<ASP:RequiredFieldValidator ControlToValidate="txtUserName"
           Display="Static" ErrorMessage="*" runat="server" 
          ID="vUserName" /></td> -->
              </div>
   </tr>
   <tr>
      <td class="style3">Contraseña:</td>
      <td class="style3"><input id="txtUserPass" type="password" runat="server" /></td>
      <td class="style3"><!--<ASP:RequiredFieldValidator ControlToValidate="txtUserPass"
          Display="Static" ErrorMessage="*" runat="server" 
          ID="vUserPass" />-->
      </td>
   </tr>
   <tr>
      <td colspan="2">
      <center>
      <asp:Button ID="Button1" runat="server" Text="Acceder" 
              onclick="Button1_Click" Width="97px" Height="36px"/></center> </td>
   
       <td>  <asp:Button ID="Anonimo" runat="server" Text="Acceso anonimo" 
              onclick="Anonimo_Click"  Height="46px"/></center> </td>
   
   </tr>
   <tr>
         <td colspan="2"><asp:Label id="lblMsg" ForeColor="red" Font-Name="Verdana" Font-Size="10" runat="server" /></td>
   </tr>
     
</table>
</font>
</center>
    </form> </h2>
  
</body>
</html>