
$(function () {
    var basicAuthUI =
        '<div class ="input"> 用户名:<input placeholder ="username" id ="input_username" onchange="addAuthorization();" name ="username" type ="text" size ="15"> </ div>' +
        '<div class ="input"> 密码:<input placeholder ="password" id ="input_password" onchange="addAuthorization();" name ="password" type ="password" size ="20"> </ div>';
    $('#input_apiKey').hide();
    $('#api_selector').html(basicAuthUI);

});

function addAuthorization() {
    var username = $("#input_username").val;
    var password = $("#input_password").val;
    var data = "grant_type=password&username=" + username + "&password=" + password;
    $.ajax({
        url: "http://localhost:2863/token",
        type: "post",
        contenttype: 'x-www-form-urlencoded',
        data: data,
        success: function (response) {
            var bearerToken = 'Bearer ' + response.access_token;
            console.log(bearerToken);
            swaggerUi.api.clientAuthorizations.add('key', new SwaggerClient.ApiKeyAuthorization('Authorization', bearerToken, 'header'));

        }
    });

}
