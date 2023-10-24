const { log } = require('console');
const crypto = require('crypto');
const algorithm = "aes-256-cbc"; // khai báo thuật toán
const initVector = crypto.randomBytes(16);
const message = "Hello my friend";
const securityKey = crypto.randomBytes(32); // tạo chuỗi ngẫu nhiên

// hàm mã hóa dùng thuật toán AES
const cipher = crypto.createCipheriv(algorithm, securityKey, initVector);
let encryptedData = cipher.update(message, "utf-8", "hex");
encryptedData += cipher.final("hex");
console.log("Dữ liệu đã mã hóa: " + encryptedData);

const decipher = crypto.createDecipheriv(algorithm, securityKey, initVector);
let decryptedData = decipher.update(encryptedData, 'hex', 'utf-8');
decryptedData += decipher.final('utf-8');
console.log("Dữ liệu đã được giải mã: " + decryptedData);