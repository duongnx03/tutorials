const express = require('express');

const userRouter = require('./UserRouter');


const rootRouter = express.Router();
rootRouter.use('/user', userRouter);

module.exports = rootRouter;