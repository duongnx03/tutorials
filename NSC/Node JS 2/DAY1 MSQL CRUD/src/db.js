const mysqli = require('mysql2');
const db = mysqli.createConnection({
    host: "localhost",
    user: 'root',
    password: '',
    database: 'NodeJS'
});

db.connect(err =>{
    if(err){
        console.log('connect-fail', err);
        return;
    }
    console.log('connect susscess')
});

module.exports = db;