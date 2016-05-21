"use strict"

var db = require('../db'),
    formidable = require('formidable');

class Admin {

  //lists all users
  index(req, res) {
    var user = db.all('SELECT * FROM users', function(err, users){
      if(err) {
        console.error(err);
        return res.sendStatus(500);
      }
      res.render('admin/index', {users: users, user: req.user});
    });
  }

  //turns standard user into an admin
  upgrade(req, res) {
    console.log(req.params.id);
    var user = db.all('SELECT * FROM users', function(err, users){
      if(err) {
        console.error(err);
        return res.sendStatus(500);
      }
      db.run('UPDATE users SET is_admin = 1 WHERE id = ? ', req.params.id)
      res.render('admin/index', {users: users, user: req.user});
    });
  }

  //demote user
  demote(req, res) {
    console.log(req.params.id);
    var user = db.all('SELECT * FROM users', function(err, users){
      if(err) {
        console.error(err);
        return res.sendStatus(500);
      }
      db.run('UPDATE users SET is_admin = 0 WHERE id = ? ', req.params.id)
      res.render('admin/index', {users: users, user: req.user});
    });
  }

  //bans a user
  ban(req, res) {
    var user = db.all('SELECT * FROM users', function(err, users){
      if(err) {
        console.error(err);
        return res.sendStatus(500);
      }
      db.run('UPDATE users SET is_banned = 1 WHERE id = ? ', req.params.id)
      res.render('admin/index', {users: users, user: req.user});
    });
  }

  //unban user
  unban(req, res) {
    var user = db.all('SELECT * FROM users', function(err, users){
      if(err) {
        console.error(err);
        return res.sendStatus(500);
      }
      db.run('UPDATE users SET is_banned = 0 WHERE id = ? ', req.params.id)
      res.render('admin/index', {users: users, user: req.user});
    });
  }

}

module.exports = exports = new Admin();
