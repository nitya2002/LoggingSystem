// See https://aka.ms/new-console-template for more information
using LoggingSystem;


LoggingHandler obj =new InfoHandler(new DebugHandler(new ErrorHandler(null)));


// obj.log("Info","this is info");
// obj.log("Error","This is error message");
obj.log("Debug","this is debug message");

