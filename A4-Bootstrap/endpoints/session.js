"use strict"

var encryption = require('../encryption'),
    db = require('../db'),
    formidable = require('formidable');

// An endpoint for logging in and out users
class Session {

  // Renders a login form with no error message
  login(req, res) {
    res.render('session/login', {message: "", user: req.user});
  }

  // Creates a new session, provided the username and password match one in the database,
  // If not, renders the login form with an error message.
  start(req, res, next) {
    req.session.reset();
    var form = new formidable.IncomingForm();
    form.parse(req, (err, fields, files) => {
      if(err) return res.sendStatus(500);
      db.get("SELECT * FROM users WHERE username = ?", fields.username, (err, user) => {
        console.log(user)
        if(err) return res.render('session/login', {message: "Username/Password not found.  Please try again.", user: req.user});
        if(!user) return res.render('session/login', {message: "Username/Password not found.  Please try again.", user: req.user});
        if(user.password_digest != encryption.digest(fields.password + user.salt)) return res.render('session/login', {message: "Username/Password not found.  Please try again.", user: req.user});
        req.session.user_id = user.id;
        return res.redirect('/wiki');
      });
    });
  }



  // Ends a user session by flushing the session cookie.
  stop(req, res) {
    req.session.reset();
    res.render("session/logout", {user: {username: "Guest"}});
  }

  create(req, res){
    var form = new formidable.IncomingForm();
    form.parse(req, function(err, fields, files) {
      var user = db.all('SELECT * from users WHERE user_name = ?', fields.user, function (rows , err) {
        if(rows.length > 0) {
          alert("username taken");
          res.redirect('/create');
        }
        //else create user
        var salt = encryption.salt();
        db.run("INSERT INTO users (username, admin, password_digest, salt) values (?,?,?,?)",
          fields.user_name,                          //username
          false,                                     //not an admin by default
          encryption.digest(fields.password + salt), //encrypt password
          salt                                       //store salt
        );
        req.session.user_id = user.id;
        return res.redirect('/wiki');
      });
    });
  }

  new(req, res) {
    res.render('session/new', {message: "", user: req.user});
  }

}

module.exports = exports = new Session();
