$(document).ready(function () {
    function insert(nom, description, prerequis) {
        nom = document.getElementById("nom").value;
        description = document.getElementById("description").value;
        prerequis = document.getElementById("prerequis").value;

        $.post("~/Controllers/HomeController.cs", { nom = nom, description = description, prerequis = prerequis, cmd=1 } function (data) {

        });
    }
});
