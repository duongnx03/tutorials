const fs = require('fs');
const Event = require('../models/Event');


const getAllEvent = async (req, res) => {
    const tbEvent = await Event.find({});
    res.render('list', { tbEvent });
}

const getFormCreate = (req, res) => {
    res.render('create', { data: null, errors: null });
}

const createEvent = async (req, res) => {
    const { id, description, datetime, location, postcode } = req.body;
    // console.log('Received data:', id, description, datetime, location, postcode);

    const dataSubmit = {
        id: id,
        description: description,
        datetime: datetime,
        location: location,
        postcode: postcode
    };

    try {
        const result = await Event.create(dataSubmit);
        console.log('Event created successfully:', result);

        req.session.message = 'Event created successfully';
        res.redirect('/event');
    } catch (err) {
        console.error('Error creating event:', err);

        let errors = {};
        if (err.name === 'ValidationError') {
            for (const field in err.errors) {
                errors[field] = err.errors[field].message;
            }
            console.error('Validation errors:', errors);

            res.render('create', { errors, data: dataSubmit });
        }
    }
}


const getFromEdit = async (req, res) => {
    const { id } = req.params;
    try {
        const result = await Event.findById(id);
        if (!result) {
            throw new Error('Event not found');
        }
        res.render('edit', { errors: null, data: result });
    } catch (err) {
        console.error(err);
        res.redirect('/event');
    }
}


const editEvent = async (req, res) => {
    const { id, description, datetime, location, postcode } = req.body;
    const dataSubmit = {
        id: id,
        description: description,
        datetime: datetime,
        location: location,
        postcode: postcode,
    };
    const opts = { runValidators: true };

    try {
        const result = await Event.findByIdAndUpdate(id, dataSubmit, opts);
        req.session.message = 'Event updated successfully';
        res.redirect('/event');
    } catch (err) {
        let errors = {};
        if (err.name === 'ValidationError') {
            for (const field in err.errors) {
                errors[field] = err.errors[field].message;
            }
            res.render('edit', { errors, data: dataSubmit });
        } else {
            console.error('Error updating event:', err);
            res.redirect('/event');
        }
    }
}


const deleteEvent = async (req, res) => {
    const { id } = req.params;
    try {
        const result = await Event.findByIdAndDelete(id);
        if (!result) {
            throw new Error('Event not found');
        }
        req.session.message = 'Event deleted successfully';
        res.redirect('/event');
    } catch (err) {
        console.error('Error deleting event:', err);
        res.redirect('/event');
    }
}


module.exports = { getAllEvent, getFormCreate, createEvent, getFromEdit, editEvent, deleteEvent };
