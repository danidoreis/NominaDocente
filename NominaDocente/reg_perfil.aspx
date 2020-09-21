<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="reg_perfil.aspx.cs" Inherits="NominaDocente.reg_perfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="popup">
    <div class="contenido_popup">
        <span>El perfil fue dado de alta</span>
        <a href="#" id="close" >Ok</a>
    </div>
</div>
    <form id="form1" runat="server">
    
    <h1 class="titulo">Registro Perfil</h1>
    <div class="campo">
        <label>Nombre: </label>
        <INPUT type="text" id="txtNombre"  runat="server" pattern="[a-zA-Z _]{0,50}" required autofocus>
    </div>
    <div class="campo">
        <label>Descripción: </label>
        <INPUT type="text" id="txtDescripcion"  runat="server" pattern="[a-zA-Z _]{0,50}" required> 
    </div>
    


        <script type="text/javascript" src="scripts/jquery.min.js"></script>
    <script type="text/javascript">
        $(function () {
            $("#left").bind("click", function () {
                var options = $("[id*=lstRight] option:selected");
                for (var i = 0; i < options.length; i++) {
                    var opt = $(options[i]).clone();
                    $(options[i]).remove();
                    $("[id*=lstLeft]").append(opt);
                }
            });
            $("#right").bind("click", function () {
                var options = $("[id*=lstLeft] option:selected");
                for (var i = 0; i < options.length; i++) {
                    var opt = $(options[i]).clone();
                    $(options[i]).remove();
                    $("[id*=lstRight]").append(opt);
                }
            });
        });

        function saveSelected() {
            var hidden = $("[id*=hidAsignados]");
            var options = $("[id*=lstRight] option");
            var seleccionados = "";
            for (var i = 0; i < options.length; i++) {
                if (seleccionados != "")
                    seleccionados += ",";
                seleccionados += options[i].value;
            }

            $("[id*=hidAsignados]").attr("value", seleccionados);
        }
</script>


    <table border="0" cellpadding="5" cellspacing="5" runat="server" id="tblContratistas">
    <tr>
         <td>Funciones Disponibles</td>
         <td></td>
         <td>Funciones Asignadas</td>
    </tr>
    <tr>
        <td>
            <asp:ListBox ID="lstLeft" runat="server" SelectionMode="Multiple" Width="150">
            </asp:ListBox>
        </td>
        <td>
            <input type="button" id="left" value="<<" /><br />
            <input type="button" id="right" value=">>" />
        </td>
        <td>
            <asp:ListBox ID="lstRight" runat="server" SelectionMode="Multiple" Width="150"></asp:ListBox>
        </td>
    </tr>
    <tr><td colspan="3">
        <asp:HiddenField ID="hidAsignados" runat="server" EnableViewState="true"/>
        </td>
    </tr>
    <tr>
        <td colspan="3"><asp:Button ID="btnSubmit" OnClientClick="saveSelected();" Text="Guardar" runat="server" OnClick="Guardar" /></td>
    </tr>
</table>
   
    </form>
    
</asp:Content>
