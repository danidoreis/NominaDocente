<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="NominaDocente.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <header>
		    <h1>Nomina Docente</h1>
		    <h2> Escuela Tecnica N°3 </h2>
		    <figure>
			    <img src="img/Escudo.png"/>
		    </figure>
	    </header>	
	    <section>
       
            <a href="reg_docente.aspx" class="icon-reg"><span>Registro Docente</span></a>
            <a href="cons_docente.aspx" class="icon-bus"><span>Busqueda Docente</span></a>
            <a href="reg_carg_hor.aspx" class="icon-reg"><span>Registro Carga Horaria</span></a>
            <a href="reporte_docente.aspx" class="icon-rep"><span>Reporte Carga Horaria</span></a>
            <a href="reporte_curso.aspx" class="icon-rep"><span>Reporte de Cursos</span></a>
            <a href="mesa_examen.aspx" class="icon-reg"><span>Registro de las Mesas de Examen</span></a>
            <a href="reporte_mesa_examen.aspx" class="icon-rep"><span> Reporte de las Mesas de Examen</span></a>
              <a href="reg_usuario.aspx" class="icon-rep"><span> Registrar Usuario</span></a>
                <a href="reg_perfil.aspx" class="icon-rep"><span> Registrar Perfil</span></a>
                  <a href="reg_funcion.aspx" class="icon-rep"><span>Registrar Funcion</span></a>
                   <a href="administrar.aspx" class="icon-rep"><span>Administrar</span></a>
            
        </section>
</asp:Content>