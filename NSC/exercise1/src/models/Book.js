const {Schema, default:mongoose} = require('mongoose');
const bookSchema = new Schema({
    name: {
        type: String,
        required: [true, 'Name is required']
    },
    price: {
        type: Number,
        required: [true, 'Price is required'],
        min: [200, 'min is 200$'],
        max: [20000, 'max is 20000$']
    },
    quantity: {
        type: Number,
        required: [true, 'Quantity is required'],
        min: [1, 'min is 1'],
        max: [20000, 'max is 100000']
    },
});
const Book = mongoose.model('Book', bookSchema);
module.exports = Book;