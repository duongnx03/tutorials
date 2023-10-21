const { json } = require("express");
var express = require("express"); //goi thu vien express
var app = express();
var port = 8000; //port cua web

app.use(express.static("public"));
app.set("view engine", "ejs");//khai bao file co duoi mo rong
app.set("views", "./views");
app.use(express, json());
app.use(express.urlencoded);
app.listen(port);

app.get("/", function (req, res) {
    res.render("home");
});

app.get("/thuat-toan-des", function (req, res) {
    res.render("thuattoandes");
})
app.post("/post-thuat-toan-des", function (req, res) {
    console.log(req.body.dulieu);
    res.send("ok");
    var crypto = require("crypto"); //goi thu vien ma hoa
    var key = Buffer.from("awivbajevbajivbaidaijbafiubwiuvw", "base64");
    var kieumahoa = crypto.createCipheriv("des-ede3", key, null);
    var mahoa = kieumahoa.update(req.body.dulieu, "utf8", "base64");
    mahoa += kieumahoa.final("base64");

    console.log("Du lieu sau khi ma hoa: " + mahoa)

})

app.get("/thuat-toan-aes", function (req, res) {
    res.render("thuattoanaes");
})

app.get("/thuat-toan-rsa", function (req, res) {
    res.render("thuattoanrsa");
})


