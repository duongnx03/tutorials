//ma hoa doi xung dung chung 1 key - o demo nay laf: key
var crypto=require("crypto"); //goi thu vien ma hoa
var key = Buffer.from("awivbajevbajivbaidaijbafiubwiuvw","base64");
var kieumahoa = crypto.createCipheriv("des-ede3",key,null);
var mahoa = kieumahoa.update("hello duongk", "utf8", "base64");
mahoa += kieumahoa.final("base64");

console.log("Du lieu sau khi ma hoa: "+mahoa)

//ham giai ma
var decode = crypto.createDecipheriv("des-ede3", key, null);
var giaima = decode.update(mahoa, "base64", "utf8");
giaima += decode.final("utf8");

console.log("Du lieu sau khi giai ma: "+giaima);