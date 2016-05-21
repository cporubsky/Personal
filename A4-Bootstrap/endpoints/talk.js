"use strict"

var db = require('../db'),
    formidable = require('formidable');

class Talk{

  talk(req, res){
    var wiki = db.get('SELECT * FROM wiki WHERE ID=?', req.params.id, function(err, item){
      if(err) {
        console.error(err);
        return res.sendStatus(400);
      }
      res.render('talk/talk', {wiki: item, user: req.user});
    });
  }

  edit(req, res){
    var wiki = db.get('SELECT * from wiki WHERE id = ?', req.params.id, function(err, wiki){
      if(err) console.log(err);
      res.render('talk/edit', {wiki: wiki, user: req.user})
    });
  }

  update(req, res){
    var form = new formidable.IncomingForm();
    form.parse(req, function(err, fields, files) {
      db.run('UPDATE wiki SET talk = ? WHERE id = ?',
        fields.talk,
        req.params.id
      );
      res.redirect('/wiki');
    });
  }
}

module.exports = exports = new Talk();
