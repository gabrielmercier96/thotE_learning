$(document).ready(function () {
    $("#env").click(function (){
        var n = $("#nom").val();
        var p = $("#prenom").val();
        var em = $("#email").val();
        var ed = $("#education").val();
        var patt = new RegExp("[a-z0-9]{4,}[@][a-z]+[.][a-z]{1,3}");
        var patt2 = new RegExp("[a-z0-9]{4,}[@][a-z]+[.][a-z]{1,3}[.][a-z]{1,3}");


        if (p != "" && p.length>=3) {
            if (n != "" && n.length>=3) {
                if (em != "" && em.length >= 4 && patt.test(em) || patt2.test(em))  {
                    alert("inscription reussi");
                    $("#send").submit()
                    
                }
                else {
                    alert("le email doit avoir le format example@domaine.ext.ext2 ou example@domaine.ext");
                }
            }
            else {
                alert("Le nom doit etre superieur  ou egale a 3 caracteres");
            }
        }
        else {
            alert("le prenom doit etre superieur ou egale a 3 caracteres");
        }
    });
});