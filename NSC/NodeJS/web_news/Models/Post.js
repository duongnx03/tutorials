const mongoose = require('mongoose');
const PostSchema = mongoose.Schema({
    title: { type: String, require: true },
    des: { type: String, require: true },
}, {
    timestamps: true,
});

module.exports = mongoose.model('Posts', PostSchema);