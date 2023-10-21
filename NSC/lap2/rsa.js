var crypto = require("crypto");
var { publicKey, privateKey } = crypto.generateKeyPairSync("rsa", {
  modulusLength: 2048,
});

var data = "hello duongk"; // chuỗi cần mã hóa
var encryptedData = crypto.publicEncrypt(
  {
    key: publicKey,
    padding: crypto.constants.RSA_PKCS1_OAEP_PADDING,
    oaepHash: "sha256",
  },
  Buffer.from(data)
);
console.log("encrypted data: ", encryptedData.toString("base64"));

var decryptedData = crypto.privateDecrypt(
  {
    key: privateKey,
    padding: crypto.constants.RSA_PKCS1_OAEP_PADDING,
    oaepHash: "sha256",
  },
  encryptedData
);
console.log("decrypted data: ", decryptedData.toString());
