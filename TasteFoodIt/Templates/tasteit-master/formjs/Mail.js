
$(document).ready(function () {
    $("#btnmail").click(function (event) {
        event.preventDefault(); // Form submit olayını durdur

        var formData = $("#subscribeForm").serialize(); // Form verisini al

        $.ajax({
            type: "POST",
            url: '/AdminMail/CreateMail',
            data: formData,
            success: function (response) {
                console.log("E-posta aboneliği başarıyla oluşturuldu");
                console.log(response);

                Swal.fire({
                    icon: 'success',
                    title: 'Abonelik Başarılı!',
                    text: 'E-posta aboneliğiniz başarıyla tamamlandı.'
                });
            },
            error: function (xhr, status, error) {
                console.log("E-posta aboneliği oluşturulurken bir hata oluştu");
                console.log(xhr.responseText);
            }
        });
    });
});



