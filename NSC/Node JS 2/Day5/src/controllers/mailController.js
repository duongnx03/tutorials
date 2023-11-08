var nodeMailler = require('nodemailer');
const templatemail = require('../template');
const getFormSendMail = (req, res)=>{
    res.render("formmail");
};

const sendMailNodejs = async(req, res)=>{
    const {email, subject, content} = req.body;
    var transporter = nodeMailler.createTransport({
        service: 'gmail',
        auth: {
            user: 'duongnx170803@gmail.com',
            pass: 'qgcd dloi awyt huel'
        },
    });

    var mailOptions = {
        from: 'duongnx170803@gmail.com',
        to: email,
        subject: subject,
        html: templatemail(subject, content)
    };

    transporter.sendMail(mailOptions, function(error, info){
        if(error){
            req.session.message = {
                type: 'Error',
                message: 'Something error. check again'
            }
            res.redirect('/email');
        }else{
            req.session.message = {
                type: 'Success!',
                message: 'Send email successfully!'
            }
            res.redirect('/email');
        }
    })
}

module.exports = {
    getFormSendMail, sendMailNodejs
}