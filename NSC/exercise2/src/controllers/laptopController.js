const fs = require('fs');
const Laptop = require('../models/Laptop');


const getAllLaptop = async (req, res) => {
    const laptops = await Laptop.find({});
    res.render('list', { laptops });
}

const getFormCreate = (req, res) => {
    res.render('create', { data: null, errors: null });
}

const createLaptop = async (req, res) => {
    const { name, price } = req.body; // Sử dụng cú pháp đúng để lấy dữ liệu từ req.body
    const imageUrl = req.file ? `/upload/${req.file.filename}` : '';
    const dataSubmit = {
        name: name,
        price: price,
        image: imageUrl
    };
    try {
        const result = await Laptop.create(dataSubmit);
        req.session.message = "Laptop created successfully";
        res.redirect('/laptop');
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
    
    await Laptop.findById(id)
        .then(result =>{
            console.log(result);
            res.render('edit', {errors: null, data: result});
        })
        .catch(err => {
            res.redirect("/laptop");
        })
}

const editLaptop = async(req, res)=>{
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
    await Laptop.findByIdAndUpdate(id, dataSubmit)
    //await Laptop.updateOne({}, dataSubmit, opts)
    .then(result =>{
        req.session.message = 'Laptop updated successfully';
        res.redirect('/laptop');
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

const deleteLaptop = async(req, res)=>{
    const {id} = req.params;
    await Laptop.findByIdAndDelete(id)
        .then(result =>{
            if(result.image != ''){
                try{
                    fs.unlinkSync('./src/public/'+result.image); //xoa file vat ly
                }catch(err){
                    console.log(err);
                }
            }
            req.session.message = 'Laptop deleted successfully';
            res.redirect('/laptop');
        })
        .catch(err =>{
            console.log("err delete: ", err);
    })
}

module.exports = { getAllLaptop, getFormCreate, createLaptop, getFromEdit, editLaptop, deleteLaptop };
