const db = require('../db');

function getAllProduct(callback){
    const sql = "SELECT * from productdb";
    db.query(sql, callback);
};

function createProduct(product, callback){
    const sql = "INSERT INTO productdb (name, price, description) VALUES (?, ?, ?)";
    const {name, price, description} = product;
    db.query(sql, [name, price, description], callback);
};

function deleteProduct(id, callback){
    const sql = "DELETE FROM productdb where id = ?";
    db.query(sql, [id], callback);
};

function getOneProduct(id, callback){
    const sql = "SELECT * FROM productdb WHERE id = ?";
    db.query(sql, [id], callback);
}

function updateProduct(product, callback){
    const sql = "UPDATE productdb SET name = ?, price = ?, description = ? WHERE id = ?";
    const {name, price, description, id} = product;
    db.query(sql, [name, price, description, id], callback); 
}

module.exports = {
    getAllProduct,
    createProduct,
    deleteProduct,
    getOneProduct,
    updateProduct

};