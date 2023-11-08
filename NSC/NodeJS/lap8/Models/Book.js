var mongoose = require('mongoose');
var Bookschema = mongoose.Schema({
    title: {
        type: String,
        require: true,
    },
    Discription:{
        type: String,
        require: true, 
    },
    Author: {
        type: String,
        require: true,
    },
});

module.exports = mongoose.model("Books", Bookschema);