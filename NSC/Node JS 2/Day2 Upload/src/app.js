
const {default: mongoose} = require('mongoose');
const express = require('express');
const app = express();
const path = require('path');
const session = require('express-session');
const rootRouter = require('./router/rootRouter');


mongoose.connect('mongodb://127.0.0.1:27017/userdb')
    .then(()=> console.log("connect success"))
    .catch(error => {
        console.log("Error:", error);
      });


app.use(express.urlencoded({extended: true}));
app.use(express.static("src/public"));//đọc đường dẫn hình ảnh
app.set('views', path.join(__dirname,'views'));
app.set('view engine', 'ejs');

//cai dat session
app.use(session({
    secret: 'abc123',
    resave: false,
    saveUninitialized: false,
}));

//xu ly middleware
app.use((req, res, next)=>{
    res.locals.user = req.session.user;
    res.locals.message = req.session.message;
    delete req.session.message;
    delete req.session.errorMessage;
    next();
});

app.use(rootRouter);

const port = 3000;
app.listen(port, () => console.log(`listening on http://localhost:${port}/product`));
