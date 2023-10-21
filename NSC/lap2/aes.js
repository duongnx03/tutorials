let crypto = require("crypto");
let thuattoan = "aes-256-cbc";  
let chuoi = crypto.randomBytes(16);//tao chuoi ngau nhien

// console.log(chuoi);
// console.log(chuoi.toString());

let vanban = "Day la chuoi can ma hoa";
let key = crypto.randomBytes(32);//tao key
//ham ma hoa dung thuat toan AES
let cipher = crypto.createCipheriv(thuattoan, key, chuoi);
let mahoa = cipher.update(vanban, "utf8", "hex");
mahoa += cipher.final("hex");
console.log("Du lieu da ma hoa: "+mahoa);

//ham giai ma
let decode = crypto.createDecipheriv(thuattoan, key, chuoi);
let giaima = decode.update(mahoa, "hex" , "utf8");
giaima += decode.final("utf8");
console.log("Du lieu giai ma la: "+giaima);