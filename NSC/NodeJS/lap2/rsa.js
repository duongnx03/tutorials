const crypto = require('crypto');
const { publicKey, privateKey } = crypto.generateKeyPairSync("rsa", {
    modulusLength: 2048,
})

const data = "my secret data";
const encryptedData = crypto.publicEncrypt(
    {
        key: publicKey,
        padding: crypto.constants.RSA_PKCS1_OAEP_PADDING,
        oaepHash: "sha256"
    },
    Buffer.from(data)
);
console.log("encrypted data: ", encryptedData.toString("base64"));

const decryptedData = crypto.privateDecrypt(
    {
        key: privateKey,
        padding: crypto.constants.RSA_PKCS1_OAEP_PADDING,
        oaepHash: "sha256"
    },
    encryptedData
);
console.log("decrypted data: ", decryptedData.toString());
