"use strict";
const connection = new signalR.HubConnectionBuilder()
    .withUrl("https://gloryhall.azurewebsites.net/Messages/Chathub")
    .configureLogging(signalR.LogLevel.Debug)
    .build();
https://gloryhall.azurewebsites.net/Messages/Chathub
//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var msg = "    " + message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = user + " says " + msg;
    var div = document.createElement("div");
    div.className = "row mb-3";
    var divUser = document.createElement("div");
    divUser.className = "row-md-4 themed-grid-col";
    divUser.style = "font-weight:bold";
    var divMessage = document.createElement("div");
    divMessage.className = "row-md-8 themed-grid-col";
    divUser.textContent = user;
    divMessage.textContent = msg;
    div.appendChild(divUser);
    div.appendChild(divMessage);
    document.getElementById("messages").appendChild(div);
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var message = document.getElementById("messageInput").value;
    var threadId = document.getElementById("threadID").value;
    
    connection.invoke("SendMessage", message, threadId).catch(function (err) {
        return console.error(err.toString());
    });
    document.getElementById("messageInput").value = "";
    event.preventDefault();
});