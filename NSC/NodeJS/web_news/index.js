const express = require('express');
const app = express();
const expressLayouts = require('express-ejs-layouts');
const port = 3000;

const db = require('./config/db')
// connect to d

app.use(express.static("public"));
app.use(express.urlencoded({ extended: true }));
app.use(express.json());
app.use(expressLayouts);
app.set('view engine', 'ejs')
app.set('views', './Views')

app.get('/', (req, res) => {
    res.send("Welcome to news");
})

app.listen(port, () => {
    console.log(`Listening on port: ${port}`);
});

//router
app.use("",require("./Routes/Post"));

//connect database
var mongoose = require('mongoose');
mongoose.connect("mongodb://127.0.0.1:27017/web_news", {
    useNewUrlParser: true,
    useUnifiedTopology: true,
});
mongoose.connection.on("error", () => {
    console.log("Kết nối thất bại");
});
mongoose.connection.once("open", () => {
    console.log("Kết nối thành công");
});
