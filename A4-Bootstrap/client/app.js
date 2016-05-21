 //browserify client/app.js -o public/bundle.js

/* link ids */
// promote
// demote
// ban
// unban

//also refresh page

var $ = require('jquery');

$(function(){
    $(".user-change").click(function(event){
      //check on success handler
      event.preventDefault();
      var button = $(event.target);
      var role = button.data('role');
      var id = buton.data('id');
      if(role === 'demote'){
        $.get("/wiki/users/" + id + "/demote");
        button.text('promote');
        button.data('role', 'promote');
      } else {
          $.get("/wiki/users/" + id + "/upgrade");
          button.text('demote');
          button.data('role', 'demote');
      }
    });
});



/* jfiddle html*/
// <html xmlns="http://www.w3.org/1999/xhtml">
// <head>
// </head>
// <body>
// <span></span>
// <span></span>
// <p></p>
// <div id="myContentToFill">old stuff</div>
// <button type="button" class="user-change" data-id="7" data-role="demote">demote</button>
// </body>
// </html>


/* jfiddle javascript*/
// $('.user-change').click(function(event){
//     var id = $('.user-change').attr('data-id');
//     var role = $('.user-change').attr('data-role');
//     var buttonText = $('.user-change').text();
//     if(role === 'demote'){
//       $('.user-change').attr( 'data-id', 8 )
//       $('.user-change').attr( 'data-role', "promote" )
//     }
//     if(role === 'promote'){
//     	$('.user-change').attr( 'data-id', 9 )
//       $('.user-change').attr( 'data-role', "demote" )
//     }
//     var id2 = $('.user-change').attr('data-id');
// 		var role2 = $('.user-change').attr('data-role');
//     $('p').html(id2);
//     $('button').html(role2);
// });
