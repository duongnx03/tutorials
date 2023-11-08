const express = require('express');
const app = express();
const path = require('path');
const session = require('express-session');
const rootRouter = require('./routers/RootRouter');
const {default: mongoose} = require('mongoose');

mongoose.connect('mongodb://127.0.0.1:27017/userdb')
    .then(()=> console.log("connect success"))
    .catch(error => {
        console.log("Error:", error);
      });


app.use(express.urlencoded({extended: true}));
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
    next();
});

app.use(rootRouter);

const port = 3000;
app.listen(port, () => console.log(`listening on http://localhost:${port}`));
