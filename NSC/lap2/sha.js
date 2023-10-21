const crypto = require('crypto'); 

const data = 'xin chao'; 

const sh1Data = crypto.createHash('sha1').update(data).digest('hex'); 

 

console.log(sh1Data)