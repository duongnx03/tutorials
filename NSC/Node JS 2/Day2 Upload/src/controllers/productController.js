const fs = require('fs');
const Product = require('../models/Product');

const getAllProduct = async (req, res) => {
    const products = await Product.find({});
    res.render('list', { products });
}

const getFormCreate = (req, res) => {
    res.render('create', { data: null, errors: null });
}

const createProduct = async (req, res) => {
    const { name, price } = req.body; // Sử dụng cú pháp đúng để lấy dữ liệu từ req.body
    const imageUrl = req.file ? `/upload/${req.file.filename}` : '';
    const dataSubmit = {
        name: name,
        price: price,
        image: imageUrl
    };
    try {
        const result = await Product.create(dataSubmit);
        req.session.message = "Product created successfully";
        res.redirect('/product');
    } catch (err) {
        let errors = {};
        if (err.name === 'ValidationError') {
            for (const field in err.errors) {
                errors[field] = err.errors[field].message;
            }
            res.render('create', { errors, data: dataSubmit });
        }
    }
}

const getFromEdit = async(req, res)=>{
    const {id} = req.params;
    
    await Product.findById(id)
        .then(result =>{
            console.log(result);
            res.render('edit', {errors: null, data: result});
        })
        .catch(err => {
            res.redirect("/product");
        })
}

const editProduct = async(req, res)=>{
    let {id, name, price, current_image} = req.body;
    let imageUrl;
    if(req.file){
        imageUrl = `/upload/${req.file.filename}`;
    }else{
        imageUrl = current_image;
    }
    const dataSubmit = {
        id : id,
        name: name,
        price: price,
        image: imageUrl
    }
    console.log(dataSubmit);
    const opts = {runValidator: true};
    await Product.findByIdAndUpdate(id, dataSubmit)
    //await Product.updateOne({}, dataSubmit, opts)
    .then(result =>{
        req.session.message = 'Product updated successfully';
        res.redirect('/product');
    })
    .catch(err =>{
        let errors = {};
        if (err.name === 'ValidationError') {
            for (const field in err.errors) {
                errors[field] = err.errors[field].message;
            }
            res.render('edit', { errors, data: dataSubmit });
        }
    })
}

const deleteProduct = async(req, res)=>{
    const {id} = req.params;
    await Product.findByIdAndDelete(id)
        .then(result =>{
            if(result.image != ''){
                try{
                    fs.unlinkSync('./src/public/'+result.image); //xoa file vat ly
                }catch(err){
                    console.log(err);
                }
            }
            req.session.message = 'Product deleted successfully';
            res.redirect('/product');
        })
        .catch(err =>{
            console.log("err delete: ", err);
    })
}

module.exports = { getAllProduct, getFormCreate, createProduct, getFromEdit, editProduct, deleteProduct };
