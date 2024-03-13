$(document).ready(function () {
    $("#btnReservationNow").click(function (event) {
        // Form submit olayını durdur
        event.preventDefault();

        var formData = $("#reservationForm").serialize();
        var action = $("#reservationForm").attr('action');

        if (!action) {
            action = '/Reservation/CreateReservation';
        }

        // AJAX isteğini oluştur
        $.ajax({
            type: "POST",
            url: action,
            data: formData,
            success: function (response) {
                // Rezervasyon başarılı olduğunda yapılacak işlemler
                console.log("Rezervasyon başarıyla oluşturuldu");
                console.log(response);

                // SweetAlert2 ile başarılı iletişim kutusu göster
                Swal.fire({
                    icon: 'success',
                    title: 'Rezervasyon Başarılı!',
                    text: 'Rezervasyon talebiniz alınmıştır.'
                });
            },
            error: function (xhr, status, error) {
                // Hata olduğunda yapılacak işlemler
                console.log("Rezervasyon oluşturulurken bir hata oluştu");
                console.log(xhr.responseText);
                // Eğer gerekirse, hata mesajını kullanıcıya göstermek için burada bir işlem yapabilirsiniz.
            }
        });
    });
    
    $('form.contactForm').submit(function (e) {
        e.preventDefault(); // Formun normal submit işlemini engeller

        var formData = $(this).serialize(); // Form verilerini alır

        $.ajax({
            type: "POST",
            url: "/Contact/Add", // Formun gönderileceği URL
            data: formData, // Form verileri
            success: function (response) {
                // Rezervasyon başarılı olduğunda yapılacak işlemler
                console.log("Mesaj başarıyla oluşturuldu");
                console.log(response);

                // SweetAlert2 ile başarılı iletişim kutusu göster
                Swal.fire({
                    icon: 'success',
                    title: 'Mesaj Başarılı!',
                    text: 'Mesaj talebiniz alınmıştır.'
                });
            },
            error: function (xhr, status, error) {
                // Hata olduğunda yapılacak işlemler
                console.log("Rezervasyon oluşturulurken bir hata oluştu");
                console.log(xhr.responseText);
                // Eğer gerekirse, hata mesajını kullanıcıya göstermek için burada bir işlem yapabilirsiniz.
            }
            //success: function (response) {
            //    if (response === "OK") {
            //        // Başarılı yanıt geldiğinde yapılacak işlemler
            //        Swal.fire({
            //            icon: 'success',
            //            title: 'Mesaj Başarılı!',
            //            text: 'Mesaj alınmıştır.'
            //        });
            //    }
            //},
            //error: function (xhr, status, error) {
            //    // İsteğin başarısız olduğu durumda yapılacak işlemler
            //    console.log("Rezervasyon oluşturulurken bir hata oluştu");
            //    console.error(xhr.responseText);
            //}
        });
    });


   
});



