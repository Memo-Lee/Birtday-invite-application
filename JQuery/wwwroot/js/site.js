$('#InviteForm').submit(function (event) {
    event.preventDefault();
    $.ajax({
        url: "https://localhost:7225/api/birtday/ekle",
        data: {
            Name: $('#Name').val(),
            Mail: $('#Mail').val(),
            State: $('#State').val()
        },
        type: 'POST',
        // göndermeden önce
        beforeSend: function () {
            // göster
            $('#ajax-loader').show();
            console.log($('#ajax-loader'));
        },
        complete: function () {
            // gizle
            $('#ajax-loader').hide();
        },
        success: function (data) {
            //if ($('#State').val() == "true") {
            //    getKatilanlar();
            //}

            $('#results').show();
        }
    })
});
