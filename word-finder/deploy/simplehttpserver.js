var Program__main$;
Program__main$ = (function(unitVar0)
{
    var http = require('http');
    var express = require('express');
    var bodyParser = require('body-parser');
    var port = 8124;
    var app = express();
    var ignored0 = (app.set("view engine", "mustache"));
    app.use('/public', express.static('public'));
    app.use(bodyParser());
    return ((http.createServer((function(req,res)
    {
      (res.writeHead(200.000000));
      return (res.end("Hello World!"));
    }))).listen(port));
});
Program__main$()