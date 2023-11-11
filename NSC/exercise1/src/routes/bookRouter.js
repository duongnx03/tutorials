const express = require('express');
const {getAllBook, getFormCreate, createBook,getFromEdit, editBook, deleteBook} = require('../controllers/bookController');

const bookRouter = express.Router();
bookRouter.get('/', getAllBook);
bookRouter.get('/create', getFormCreate);
bookRouter.post('/create', createBook);
bookRouter.get('/edit/:id', getFromEdit);
bookRouter.post('/edit/:id', editBook);
bookRouter.get('/delete/:id', deleteBook);

module.exports = bookRouter;