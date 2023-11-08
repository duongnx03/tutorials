const User = require('../models/User');

const getAllUsers = async(req, res)=>{
    const users = await User.find({}).exec();
    console.log(users);
    if(req.session.user){
        if(req.session.user.role == 'admin'){
            return res.render('list', {users});
        }else{
            return res.redirect('/user/detail');
        }
    }else{
      return  res.redirect('/user/login');
    }
}

const getFormLogin = (req, res)=>{
   return res.render('login', {data:null, error:null});
}

const checkLogin = async (req, res, next) => {
    const { email, password } = req.body;
    const user = await User.findOne({ email, password });
    if (user) {
        req.session.user = user;
        return res.redirect('/user');
    } else {
        return res.render('login', { error: 'fail', data: { email, password } });
    }
}

const getFormCreateUser = (req, res)=>{
    if(req.session.user){
        if(req.session.user.role == 'admin'){
            return res.render('create', {data:null, errors:null});
        }else{
            return res.redirect('/user/detail');
        }
    }else{
      return  res.redirect('/user/login');
    }
     res.render('create', {data:null, error:null})
}

const createUser = async(req, res) => {
    const data = req.body;
    console.log(data);
    await User.create(data)
    .then(result => {
        req.session.message = 'User created successfully';
        res.redirect("/user");
    })
    .catch(err => {
        if(err.name === 'ValidationError'){
            let errors = {};
            for(const field in err.errors){
                errors[field] = err.errors[field].message;
            }
            res.render('create', {errors, data});
        }
    })
}

const logout = (req, res) =>{
    req.session.destroy();
    res.redirect('/user/login');
}

const getDetailUser = (req, res) => {

    res.render('detail')
}

// const deleteUser = async (req, res) => {
//     try {
//         const userId = req.params.id; // Lấy ID của người dùng cần xóa từ request params
//         const deletedUser = await User.findByIdAndDelete(userId); // Sử dụng findByIdAndDelete để xóa người dùng
//         if (!deletedUser) {
//             return res.status(404).json({ message: "Không tìm thấy người dùng để xóa." });
//         }
//         return res.status(200).json({ message: "Người dùng đã được xóa thành công." });
//     } catch (error) {
//         return res.status(500).json({ message: "Lỗi khi xóa người dùng." });
//     }
// };

module.exports = {getAllUsers, getFormLogin, checkLogin, getFormCreateUser, createUser, logout, getDetailUser};