$("#btn").click(function () {
    var user = new Object();
    user.UserName = $('#UserName').val();
    user.Password = $('#Password').val();
    $.ajax({
        type: "POST",
        url: "https://localhost:44309/api/register",
        dataType: 'json',
        data: user,
        success: function (result) {
            alert(result);
        },
        error: function (xhr, textStatus, errorThrown) {  
            alert("Error please try again");
        }  
    });

});