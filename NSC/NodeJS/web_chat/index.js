const express = require('express');
const app = express();
const expressLayouts = require('express-ejs-layouts');
const { Server } = require("socket.io");
const http = require('http');
const server = http.createServer(app);
const io = new Server(server);
const post = 3001;

app.use(express.static('public'));
app.use(express.urlencoded({ extended: true }));
app.use(express.json());

app.use(expressLayouts);
app.set('view engine', 'ejs');
app.set("views", "./views");

app.get('/', (req, res) => {
    res.render("home");
})

io.on('connection', (socket) => {
    socket.on('send name', (username) => {
        io.emit('send name', (username));
    })

    socket.on('send message', (chat) => {
        io.emit('send message', (chat));
    })
});

server.listen(post, () => {
    console.log(`Listening on port: ${post}`);
})