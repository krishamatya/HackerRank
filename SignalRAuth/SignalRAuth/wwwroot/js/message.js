"use strict";

var connection = new signalR.HubConnectionBuilder()
    .withUrl("/messages")
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
document.getElementById("logout").addEventListener("click", function (event) { connection.hub.stop(); });
function ensureStillLoggedIn() {
    if (document.visibilityState === "visible") {
        // Tab is now active, check if we're still logged in
        fetch("/Home/IsStillLoggedIn", { credentials: "same-origin" })
            .then(response => {
                if (response === "false") {
                    window.location = "/Home/Index";
                }
            });
    }
}

document.addEventListener("visibilitychange", ensureStillLoggedIn);
   


