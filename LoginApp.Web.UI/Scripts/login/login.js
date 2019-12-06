

$("#btn").click(function () {
    var user = new Object();
    user.UserName = $('#UserName').val();
    user.Password = $('#Password').val();
    $.ajax({
        url: "https://localhost:44309/api/login",
        data: user,
        type: "POST",
        success: function (result) {
            alert(result);
        },
        error: function (xhr, textStatus, errorThrown) {
            alert("Error please try again");
        }

    });

});