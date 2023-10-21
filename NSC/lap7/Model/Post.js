var mongoose = require('mongoose');
var PostSchema = mongoose.Schema({
    title:{
        type: String,
        require: true,
    },
    des:{
        type: String,
        require: true,
    },
    date:{
        type: String,
        default: Date.now,
    },
});
module.exports = mongoose.model("posts", PostSchema);