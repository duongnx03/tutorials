var express = require("express");
var router = express.Router();
var res = require("express/lib/request");
var Book = require("../Models/Book");

//hien thi tat ca record
router.get("/", async (req, res) => {
    try {
        var data = await Book.find();
        res.render("index", { dulieu: data });
    } catch (error) {
        res.json({ message: error });
    }
});
router.get("/them", async (req, res) => {
    res.render("them");
});
router.post("/them", async (req, res) => {
    var data = new Book({
        Title: req.body.Title,
        Description: req.body.Description,
        Author: req.body.Author
    });
    try {
        var savebook = await data.save()
        res.redirect("/");
    } catch (error) {
        res.json({ message: error });
    }
});
router.get("/sua/:id", async (req, res) => {
    var id = req.params.id;
    try {
        var data = await Book.find({ _id: id });
        res.render("sua", { dulieu: data });
    } catch (error) {
        res.redirect("/");
    }
});
router.post("/sua/:id", async (req, res) => {
    try {
        await Book.findByIdAndUpdate(req.params.id, req.body);
        res.redirect("/");
    } catch (error) {
        res.redirect("/");
    }
});
router.get("/tim/:str", async (req, res) => {
    try {
        var data = await Book.find({ Title: req.params.str });
        res.render("tim", { dulieu: data });
    } catch (error) {
        res.json({ message: error });
    }
});
router.get("/xoa/:id", async (req, res) => {
    try {
        await Book.deleteOne({ _id: req.params.id });
        res.redirect("/");
    } catch (error) {
        res.json({ message: error });
    }
});
module.exports = router;