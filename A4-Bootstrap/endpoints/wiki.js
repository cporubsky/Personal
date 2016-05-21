"use strict"

var db = require('../db'),
    formidable = require('formidable');

class Wiki {

  index(req, res){
    var wiki = db.all('SELECT * FROM wiki', function(err, wiki){
      if(err) {
        console.error(err);
        return res.sendStatus(500);
      }
      res.render('wiki/index', {wiki: wiki, user: req.user});
    });
  }

  new(req, res){
    res.render('wiki/new', {user: req.user});
  }

  show(req, res){
    var wiki = db.get('SELECT * FROM wiki WHERE ID=?', req.params.id, function(err, item){
      if(err) {
        console.error(err);
        return res.sendStatus(400);
      }
      res.render('wiki/show', {wiki: item, user: req.user});
    });
  }

  update(req, res){
    var form = new formidable.IncomingForm();
    form.parse(req, function(err, fields, files) {
      console.log(fields)
      db.run('UPDATE wiki set title = ?, entry = ? WHERE id = ? ',
        fields.title,
        fields.entry,
        req.params.id
      );
      res.redirect('/wiki');
    });
  }

  edit(req, res) {
    var wiki = db.get('SELECT * from wiki WHERE id = ?', req.params.id, function(err, wiki){
      console.log(wiki)
      if(err) console.log(err);
      res.render('wiki/edit', {wiki: wiki, user: req.user});
    });
  }




  create(req, res){
    var form = new formidable.IncomingForm();
    form.parse(req, function(err, fields, files) {
      db.run('INSERT INTO wiki (title, entry) values (?,?)',
        fields.title,
        fields.entry
      );
      res.redirect('/wiki');
    });
  }

  destroy(req, res) {
    db.run('DELETE FROM wiki WHERE id=?', req.params.id);
        res.redirect('/wiki');
  }

  redirect(req, res) {
    res.writeHead(301, {"Content-Type":"text/html", "Location":"/wiki"});
        res.end("This page has moved to <a href='/wiki'>wiki</a>");
  }

}

module.exports = exports = new Wiki();
