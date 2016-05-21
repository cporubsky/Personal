var express = require('express'),
    app = express(),
    sessions = require('client-sessions'),
    loadUser = require('./middleware/load_user'),
    adminOnly = require('./middleware/admin_only'),
    authenticatedOnly = require('./middleware/no_guests'),
    encryption = require('./encryption'),
    PORT = 80;

app.set('view engine', 'ejs');   //set view to ejs
app.set('views', './templates'); //set templates directory

//create sessions cookie
app.use(sessions({
  cookieName: 'session',
  secret: 'somerandomstring',
  duration: 24*90*60*1000,
  activeDuration: 1000*60*5
}));

//load user
app.use(loadUser);

//set static directory
app.use(express.static('public'));

//login routes
var session = require('./endpoints/session');
app.get('/login', session.login);      //user login form
app.post('/login', session.start);  //create session
app.get('/logout', session.stop); //deletes session
//need to test
app.get('/create', session.create); //create new user & start session
app.post('/create', session.new); //create new user & start session

//admin routes
//(\\d+) -> restricts id to only numbers
/* admin routes accessible only if
a user account is an admin account */
var admin = require('./endpoints/admin');
app.get('/wiki/users', adminOnly, admin.index);                     //shows all users
app.get('/wiki/users/:id(\\d+)/upgrade', adminOnly, admin.upgrade); //upgrade to admin
app.get('/wiki/users/:id(\\d+)/demote',adminOnly, admin.demote);    //demote to user
app.get('/wiki/users/:id(\\d+)/ban', adminOnly, admin.ban);         //ban user
app.get('/wiki/users/:id(\\d+)/unban', adminOnly, admin.unban);     //unban user

//wiki routes
//(\\d+) -> restricts id to only numbers
var wiki = require('./endpoints/wiki');
app.get('/', wiki.redirect);                                        //redirects to '/wiki' (index)
app.get('/wiki', wiki.index);                                       //index of wiki pages
app.get('/wiki/:id(\\d+)', wiki.show);                              //show a wiki page

/* wiki routes accessible only
if a user account exits */
app.post('/wiki', authenticatedOnly, wiki.create);                  //creates wiki entry in db
app.get('/wiki/new', authenticatedOnly, wiki.new);                  //new wiki page form
app.post('/wiki/:id(\\d+)', authenticatedOnly, wiki.update);        //update wiki in db
app.get('/wiki/:id(\\d+)/edit', authenticatedOnly, wiki.edit);      //edit wiki form
app.get('/wiki/:id(\\d+)/delete', authenticatedOnly, wiki.destroy); //deletes wiki entry in db

//talk routes
//(\\d+) -> restricts id to only numbers
var talk = require('./endpoints/talk');

app.get('/wiki/:id(\\d+)/talk', talk.talk); //view talk for specific wiki

/* wiki routes accessible only
if a user account exits */
app.get('/wiki/:id(\\d+)/talk/edit', authenticatedOnly, talk.edit); //edit talk form
app.post('/wiki/:id(\\d+)/talk', authenticatedOnly, talk.update);   //update talk entry in db

//start express app
app.listen(PORT, () => {
  console.log("Listening on port " + PORT);
});
