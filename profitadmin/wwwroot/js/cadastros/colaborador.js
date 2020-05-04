$(document).ready(function() {

    $("#data_nascimento").datepicker({

        format: "dd/mm/yyyy",
        clearBtn: true,
        language: "pt-BR",
        autoclose: true,
        orientation: "left",
        todayHighlight: true
    

    });
    
    $("#data_admissao").datepicker({
   
        format: "dd/mm/yyyy",
        clearBtn: true,
        todayBtn: true,
        language: "pt-BR",
        autoclose: true,
        orientation: "left",
        todayHighlight: true
    
    });

    $("#data_desligamento").datepicker({
   
        format: "dd/mm/yyyy",
        clearBtn: true,
        todayBtn: true,
        language: "pt-BR",
        autoclose: true,
        orientation: "left",
        todayHighlight: true
    
    });

});



  