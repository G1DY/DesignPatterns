using BehaviouralDesignPatterns.ChainOfResponsibility.GoodSln;

var validator = new Validator();
var authenticator = new Authenticator();
var logger = new Logger();

validator.SetNext(authenticator).SetNext(logger);

var server = new WebServer(validator);
var req = new HttpRequest("Gideon", "123");
server.Handle(req);

var req2 = new HttpRequest("", "123");
server.Handle(req2);