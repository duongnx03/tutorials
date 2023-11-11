const express = require('express');
const {getAllLaptop, getFormCreate, createLaptop,getFromEdit, editLaptop, deleteLaptop} = require('../controllers/laptopController');

const upload = require('../controllers/middleware/uploadFile');

const lapRouter = express.Router();
lapRouter.get('/', getAllLaptop);
lapRouter.get('/create', getFormCreate);
lapRouter.post('/create',upload.single('image') , createLaptop);
lapRouter.get('/edit/:id', getFromEdit);
lapRouter.post('/edit/:id', upload.single('image') , editLaptop);
lapRouter.get('/delete/:id', deleteLaptop);

module.exports = lapRouter;