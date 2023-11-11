const fs = require('fs');
const Book = require('../models/Book');


const getAllBook = async (req, res) => {
    const books = await Book.find({});
    res.render('list', { books });
}

const getFormCreate = (req, res) => {
    res.render('create', { data: null, errors: null });
}

const createBook = async (req, res) => {
    const { name, price, quantity } = req.body;
    // console.log('Received data:', name, price, quantity);

    const dataSubmit = {
        name: name,
        price: price,
        quantity: quantity,
    };

    try {
        const result = await Book.create(dataSubmit);
        console.log('Book created successfully:', result);

        req.session.message = 'Book created successfully';
        res.redirect('/book');
    } catch (err) {
        console.error('Error creating book:', err);

        let errors = {};
        if (err.name === 'ValidationError') {
            for (const field in err.errors) {
                errors[field] = err.errors[field].message;
            }
            console.error('Validation errors:', errors);

            res.render('create', { errors, data: dataSubmit });
        }
    }
}


const getFromEdit = async (req, res) => {
    const { id } = req.params;
    try {
        const result = await Book.findById(id);
        if (!result) {
            throw new Error('Book not found');
        }
        res.render('edit', { errors: null, data: result });
    } catch (err) {
        console.error(err);
        res.redirect('/book');
    }
}


const editBook = async (req, res) => {
    const { id, name, price, quantity } = req.body;
    const dataSubmit = {
        name: name,
        price: price,
        quantity: quantity
    };
    const opts = { runValidators: true };

    try {
        const result = await Book.findByIdAndUpdate(id, dataSubmit, opts);
        req.session.message = 'Book updated successfully';
        res.redirect('/book');
    } catch (err) {
        let errors = {};
        if (err.name === 'ValidationError') {
            for (const field in err.errors) {
                errors[field] = err.errors[field].message;
            }
            res.render('edit', { errors, data: dataSubmit });
        } else {
            console.error('Error updating book:', err);
            res.redirect('/book');
        }
    }
}


const deleteBook = async (req, res) => {
    const { id } = req.params;
    try {
        const result = await Book.findByIdAndDelete(id);
        if (!result) {
            throw new Error('Book not found');
        }
        req.session.message = 'Book deleted successfully';
        res.redirect('/book');
    } catch (err) {
        console.error('Error deleting book:', err);
        res.redirect('/book');
    }
}


module.exports = { getAllBook, getFormCreate, createBook, getFromEdit, editBook, deleteBook };
