var express = require('express');
var app = express();
var { Server } = require('socket.io');
var http = require('http');
const { dirname } = require('path');
var server = http.createServer(app);
var io = new Server(server);
var port = 8000;

app.use(express.static("public"));

app.get('/', function(req, res){
    res.sendFile(__dirname + '/index.html');
});

io.on('connection', (socket)=> {
    socket.on('send name', (username) => {
        io.emit('send name', (username));
    });

    socket.on('send message', (chat) => {
        io.emit('send message', (chat));
    });
});



server.listen(port, () => {
    console.log('Server is listening at the port: ' + port);
});

