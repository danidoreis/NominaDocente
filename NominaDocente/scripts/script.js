$(document).ready(inicio);

function inicio() {
    $("#close").click(cerrarPopup);
    $("#resBus input[type=radio]").click(quitarRequiredTabla);
}
function mostrarPopup(mess,link,sombra,color) {
    $("#popup").css("display", "block");
    $(".contenido_popup").css("box-shadow", sombra);
    $(".contenido_popup span").css("color",color);
    $(".contenido_popup span").html(mess);
    $(".contenido_popup a").css("background-color",color);
    $(".contenido_popup a").attr("href", link);
    $("form").css("-webkit-filter","blur(5px)");
}
function cerrarPopup() {
    $("form").removeAttr("style");
    $("#popup").fadeOut("slow");
}
function verGridView() {
    $("#resBus").show();

}
function verGridViewVacio() {
    $("#sinResBus").show();
}
function radioCheck(rb) {
    var rbs = $("#resBus table input");

    var row = rb.parentNode.parentNode;

    for (var f = 0; f < rbs.length;f++ ) {
        if (rbs[f].type == "radio") {
            if (rbs[f].checked && rbs[f] != rb) {
                rbs[f].checked = false;
                break;
            }
        }
    }
}
function agregarRequired() {
    $("#resBus select,#resBus input[type=date],#resBus input[type=time]").attr("required", "required");
}
function quitarRequired() {
    $("#resBus select,#resBus input[type=date],#resBus input[type=time]").removeAttr("required");
}
function agregarRequiredTabla() {
    $("#resBus input[type=radio]").attr("required", "required");
}
function quitarRequiredTabla() {
    $("#resBus input[type=radio]").removeAttr("required");
}
function ocultarTabla() {
    $("#resBus table,#resBus .titTable,#resBus .agregarDoc,.formCons").attr("style", "display:none");
    $(".contTable").css("border-top","0");
}
function borrarAgr() {
    $(".dataDoc.nombre").html("Eliga un Docente");
    $(".dataDoc.dni").html("");
}
$(document).ready(function () {
    $('ul li:has(ul)').hover(
      function (e) {
          $(".nav li a").css("border-bottom", "1px solid ");
          $(this).find(".flecha_abajo").css("-webkit-transform", "rotate(90deg)");
          $(this).find('ul').show();
      },
      function (e) {
          $(".nav li a").css("border-bottom", "0");
          $(this).find(".flecha_abajo").css("-webkit-transform", "rotate(0deg)");
          $(this).find('ul').hide();
      }
   );
});