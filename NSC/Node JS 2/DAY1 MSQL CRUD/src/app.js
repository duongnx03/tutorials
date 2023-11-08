const express = require('express');
const app = express();
const path = require('path');
const {getAllProduct, createProduct, getOneProduct, updateProduct, deleteProduct} = require('./controller/productController');

app.use(express.urlencoded({extended: true}));
app.set('views', path.join(__dirname, 'views'));
app.set('view engine', 'ejs');

app.get('/', (req, res)=> {
    getAllProduct((err, products)=>{
        if(err){
            res.status(500).send(err.message);
            return;
        }
        res.render('index', {products});
    })
})

app.get('/create', (req, res)=>{
    res.render('create');
})

app.post('/create', (req, res)=>{
    const data = req.body;
    createProduct(data, (err, result)=>{
        if(err){
            res.status(500).send(err.message);
            return; 
        }
        res.redirect("/");
    })
});

app.get('/edit/:id', (req, res)=> {
    const {id} = req.params;
    getOneProduct(id, (err, result)=>{
        if(err){
            res.status(500).send(err.message);
            return;
        }
        products = result[0];
        res.render('edit', {products});
    })
})

app.post('/edit', (req, res)=>{
    const data = req.body;
    updateProduct(data, (err, result)=>{
        if(err){
            res.status(500).send(err.message);
            return;
        }
        res.redirect('/');
    });
});

app.get('/delete/:id', (req, res)=> {
    const {id} = req.params;
    deleteProduct(id, (err, result)=>{
        if(err){
            res.status(500).send(err.message);
            return;
        }
        res.redirect('/');
    })
})

const port = 3000;
app.listen(port, ()=>{
    console.log(`Server is listening on http://localhost: ${port}`);
});