"use strict"

var db = require('../db'),
    formidable = require('formidable'),
    encryption = require('../encryption');

class User {

  create(req, res){
    var form = new formidable.IncomingForm();
    form.parse(req, function(err, fields, files) {
      var user = db.all('SELECT * from users WHERE user_name = ?', fields.user, function (rows , err) {
        if(rows.length > 0) {
          alert("username taken");
          res.redirect('/wiki');
        }
        //else create user
        var salt = encryption.salt();
        db.run("INSERT INTO users (username, admin, password_digest, salt) values (?,?,?,?)",
          fields.user_name,                          //username
          false,                                     //not an admin by default
          encryption.digest(fields.password + salt), //encrypt password
          salt                                       //store salt
        );
      });
      res.redirect('/wiki');
    });
  }
}

module.exports = exports = new User();
