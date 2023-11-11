const {Schema, default:mongoose} = require('mongoose');
const productSchema = new Schema({
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
    image: {
        type: String,
        validate: { 
            validator: function (v){
                return /\.(jpg|jpeg|png)$/i.test(v);
            },
            message: (props) => `${props.value} allow type: jpq, jpeg, png`
        },   
        required: [true, 'Image is required']   
    },
});
const Laptop = mongoose.model('Laptop', productSchema);
module.exports = Laptop;