var express = require('express');
var router = express.Router;
var res = require('express/lib/request');

var Post = require('../Model/Post');

router.get("/Post", async(req, res)=>{
    try{
        var data = await Post.find();
        res.json(data);
    }catch(error){
        res.json({message: error});
    }
});

module.exports = router;
