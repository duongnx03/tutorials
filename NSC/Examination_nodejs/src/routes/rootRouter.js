const express = require('express');
const eventRouter = require('./eventRouter');
const rootRouter = express.Router();
rootRouter.use('/event', eventRouter);
module.exports  = rootRouter;