// mã hóa đối xứng dùng chung một key
var crypto = require('crypto'); // gọi thư viện crypto
let key = Buffer.from('jhsgatt12sgsssqswhwqfsaxasxuasxs', 'base64'); // tạo key với 32 kí tự
const cipher = crypto.createCipheriv("des-ede3", key, null); // des-ede3: kiểu mã hóa
let encryptedData = cipher.update('Hello my friend', 'utf-8', 'base64');
encryptedData += cipher.final('base64');
console.log("dữ liệu mã hóa: " + encryptedData);

const decipher = crypto.createDecipheriv("des-ede3", key, null); // des-ede3: kiểu mã hóa
let decryptedData = decipher.update(encryptedData, 'base64', 'utf-8');
decryptedData += decipher.final("utf8");
console.log("dữ liệu giải mã: " + decryptedData);
