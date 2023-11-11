const express = require('express');
const bookRouter = require('./bookRouter');
const rootRouter = express.Router();
rootRouter.use('/book', bookRouter);
module.exports  = rootRouter;