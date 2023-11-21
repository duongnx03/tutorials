const express = require('express');
const {getAllEvent, getFormCreate, createEvent,getFromEdit, editEvent, deleteEvent} = require('../controllers/eventController');

const eventRouter = express.Router();
eventRouter.get('/', getAllEvent);
eventRouter.get('/create', getFormCreate);
eventRouter.post('/create', createEvent);
eventRouter.get('/edit/:id', getFromEdit);
eventRouter.post('/edit/:id', editEvent);
eventRouter.get('/delete/:id', deleteEvent);

module.exports = eventRouter;