var express = require('express');
var app = express();
var port  = 3000;

app.use(express.static("public"));
app.use(express.json());
app.use(express.urlencoded({extended: true}));
app.set("view engine", "ejs");
app.set("views", "/views");

app.listen(port,()=>{
    console.log("Running...");
});