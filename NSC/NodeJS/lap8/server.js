var express = require('express');
const expressEjsLayouts = require('express-ejs-layouts');
var app = express();
var layouts = require('express-ejs-layouts');
var port  = 3000;

app.use(express.static("public"));
app.use(express.json());
app.use(expressEjsLayouts);
app.use(express.urlencoded({extended: true}));
app.set("view engine", "ejs");
app.set("views", "./views")

app.listen(port, ()=>{
    console.log("Running...")
});

//goi router
app.use("", require("./Routers/Book"));

//ket noi database mongodb
var mongoose = require('mongoose');
mongoose.connect("mongodb://127.0.0.1:27017/lap8", {
    useNewUrlParser: true,
    useUnifiedTopology: true,
});
mongoose.connection.on("error", () => {
    console.log("Kết nối thất bại");
});
mongoose.connection.once("open", () => {
    console.log("Kết nối thành công");
});