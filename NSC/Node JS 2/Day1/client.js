const { response } = require('express');
const fetch = require('node-fetch');
const postData = {
    message: "This is message from client"
}

fetch("http://localhost:3000/hello", {
    method: "post",
    header: {
        'content-Type': 'application/json'
    },
    body: JSON.stringify(postData)
}).then(response => response.test())
.then(data => console.log("response from server: ", data))
.catch(error => console.log("error", error));