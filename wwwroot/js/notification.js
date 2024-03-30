"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/notificationHub").configureLogging(signalR.LogLevel.None).build();

connection.on("ReceiveNotification", function (user, message) {
    
});

connection.start().catch(function (err) {
    return console.log();
});