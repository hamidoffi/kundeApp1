$(function () {


    const id = window.location.search.substring(1);
    const url = "Kunde/HentEn?" + id;
    $.get(url, function (kunde){
        $("#id").val(kunde.id);
        $("#navn").val(kunde.navn);
        $("#adresse").val(kunde.adresse);
    });
});

function endreKunde() {
    const kunde = {
        id: $("#id").val(),
        navn: $("#navn").val(),
        adresse: $("adresse").val()
    }

    $.post("Kunde/Endre", kunde, function (OK) {
        if (OK) {
            window.location.href = 'index.html';
        }
        else {
            $("#feil").html("Feil i db - prøv igjen senere");
        }
    });
}
