"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/notificationHub").configureLogging(signalR.LogLevel.None).build();

connection.on("ReceiveNotification", function (message, type) {
    const notyf = new Notyf({
        duration: 5000,
        dismissible: true,
        types: [
            {
                type: 'info',
                background: 'blue',
                icon: false
            }
        ]
    });

    if (type === 'info') {
        notyf.open({
            type: 'info',
            message: message.message
        }).on('dismiss', () => {
            connection.invoke("DismissNotification", message.id).catch(function (err) {
                return console.error(err);
            });
        });;
    } else if (type === 'success') {
        notyf.success(message.message);
    } else if (type === 'error') {
        notyf.error(message.message);
    }
});

connection.start().catch(function (err) {
    return console.log();
});