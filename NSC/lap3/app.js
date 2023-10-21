var express = require("express"); //goi thu vien express
var app = express();
var port = 3000; //port cua web

app.get("/", function(req, res){//url trang chu 
    res.send("Hello Duongk");// noi dung display trang chu
})

app.listen(port, (
    console.log(port)
));
