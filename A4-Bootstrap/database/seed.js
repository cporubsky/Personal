var encryption = require('../encryption'),
    sqlite3 = require('sqlite3'),
    db = new sqlite3.Database('development.sqlite3');

// Create the database schema and populate
db.serialize(function() {

  //salt from encryption
  var salt = encryption.salt();

  /**********
  users table
  **********/

  //Drop users table if it exists
  db.run("DROP TABLE IF EXISTS users");
  //Create the users table
  db.run("CREATE TABLE users (id INTEGER PRIMARY KEY AUTOINCREMENT, username TEXT UNIQUE, is_admin BOOLEAN, is_banned BOOLEAN, password_digest TEXT, salt TEXT)");

  //Create a default admin
  db.run("INSERT INTO users (username, is_admin, is_banned, password_digest, salt) values (?,?,?,?,?)",
    'admin', //create admin
    true,    //set to wiki admin
    false,   //not banned
    encryption.digest('password' + salt),
    salt
  );
  //Create a default user
  db.run("INSERT INTO users (username, is_admin, is_banned, password_digest, salt) values (?,?,?,?,?)",
    'user', //create user (non-admin)
    false,  //not an admin
    false,  //not banned
    encryption.digest('password' + salt),
    salt
  );
  //Log contents of the user table to the console
  db.each("SELECT * FROM users", function(err, row){
    if(err) return console.error(err);
    console.log(row);
  });

  /*********
  wiki table
  *********/

  //Drop wiki table if it exists
  db.run("DROP TABLE IF EXISTS wiki");
  //Create the equipment table
  db.run("CREATE TABLE wiki (id INTEGER PRIMARY KEY AUTOINCREMENT, title VARCHAR(50), entry TEXT, talk TEXT)");
  //Populate the equipment table
  for(var i = 1; i < 6; i++) {
    db.run("INSERT INTO wiki (title, entry, talk) VALUES ('Title of wiki #:" + i + "', 'Entry of wiki post#:" + i + "', 'Talk for wiki post #:" + i + "')");
  }
  //Log contents of wiki table to the console
  db.each("SELECT * FROM wiki", function(err, row){
    if(err) return console.error(err);
    console.log(row);
  });
});
