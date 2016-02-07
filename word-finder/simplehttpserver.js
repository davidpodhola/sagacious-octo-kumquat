var Program__main$;
Program__main$ = (function(unitVar0)
{
    var http = require('http');
    var port = 8124;
    return ((http.createServer((function(req,res)
    {
      (res.writeHead(200.000000));
      return (res.end("Hello World!"));
    }))).listen(port));
});
Program__main$()