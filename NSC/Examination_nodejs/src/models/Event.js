const {Schema, default:mongoose} = require('mongoose');
const eventSchema = new Schema({
    id: {
        type: Number,
        required: [true, 'Id is required']
    },
    description: {
        type: String,
        required: [true, 'Description is required']
    },
    datetime: {
        type: String,
        required: [true, 'Datetime is required'],
    },
    location: {
        type: String,
        required: [true, 'Location is required'],
    },
    postcode: {
        type: Number,
        required: [true, 'Post-code is required'],
        min: [40000, 'min is 40000'],
        max: [1000000000000000, 'max is 100000000000000'],
       
    },
});
const Event = mongoose.model('tbEvent', eventSchema);
module.exports = Event;