function GetUsersCount() {
    let count;
    $.ajax({
        url: 'http://localhost:45678/Service1.svc/DbClient/UsersCount',
        type: "GET",
        contentType: "application/json",
        dataType: "json",
        cache: false,
        xhrFields: {
            withCredentials: true
        },
        crossDomain: true,
        success: function (data) {
            $(`<p>${data} </p><br/>`).appendTo("#container");
            console.log(data);
        },
        error: function (data) {
            alert("alarm!!!");
        }
        });
}
function AddUser() {
    let dataObj = {};
    dataObj.user = {};
    dataObj.user.Id = $("#id").val();
    dataObj.user.Name = $("#name").val();
    dataObj.user.Email = $("#email").val();
    dataObj.user.Password = $("#password").val();
    $.ajax({
        url: 'http://localhost:45678/Service1.svc/DbClient/AddUser',
        type: "POST",
        contentType: "application/json",
        cache: false,
        dataType: "json",
        xhrFields: {
            withCredentials: true
        },
        crossDomain: true,
        data: JSON.stringify(dataObj),

        success: function (data) {
            console.log(data);
        },
        error: function (data) {
            alert("alarm!!!");
        }
    });
}