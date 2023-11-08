const express= require('express');
const bodyParser = require('body-parser');
const app = express();

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({extended: true}));

app.get('/', function(req, res){
    console.log("/get");
    res.send("Hello world");
});

app.get("/helo", function(req, res){
    console.log("get: /hello");
    res.send("helo , im from /helo");
});

app.post("hello", function(req,res){
    const postData = req.body;
    console.log(JSON.stringify(postData));
    
})