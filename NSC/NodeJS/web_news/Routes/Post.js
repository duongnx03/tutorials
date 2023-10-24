const express = require('express');
const router = express.Router();
const res = require("express/lib/request");

var Post = require("../Models/Post");

//async, await: xu li bat dong bo
//hien thi tat ca record
router.get('/posts', async (req, res) => {
    try {
        var dataPost = await Post.find();
        res.json(dataPost);
    } catch (error) {
        res.json({ "message": error });
    }
});

//them record
router.post("post", async(req, res)=>{
    var date = new Post({
        title: req.body.title,
        des: req.body.des,
    });
    try{
        var savepost = await data.save();  
    }
    catch(error){
        res.json({message: error});
    }
});

module.exports = router;