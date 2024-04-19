function MostrarDescripcion(idArt){
    $.ajax({
        type: 'POST',
        dataType: 'JSON',
        url: '/Home/ModalArtista',
        data: {IdAr : idArt},
        success:
        function (response){
            $('#NombreArtista').html(response.nombre);
            $('#Descripcion').html(response.descripcion);
        }
    })
}
function goBack() {
    window.history.back();
}