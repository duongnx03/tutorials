const express = require('express');
const lapRouter = require('./lapRouter');
const rootRouter = express.Router();
rootRouter.use('/laptop', lapRouter);
module.exports  = rootRouter;