"use strict";

var connection = new signalR.HubConnectionBuilder()
    .withUrl("/messages")
    .configureLogging(signalR.LogLevel.Information)
    .build();

document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);
    li.textContent = `${user} says ${message}`;

});


connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});
document.getElementById("logout").addEventListener("click", function (event) {
    connection.hub.stop();
});

function ensureStillLoggedIn() {
    if (document.visibilityState === "visible") {
        // Tab is now active, check if we're still logged in
        $.ajax({
            type: "POST",
            url: "/Home/IsStillLoggedIn",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                if (data == true) {
                    window.location = "/Identity/Account/Login";
                }
            },
            error: function () {
                alert("Error occured!!")
            }
        });
    }
}

document.addEventListener("visibilitychange", ensureStillLoggedIn);




