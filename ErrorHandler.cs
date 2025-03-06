namespace LoggingSystem {
    public class ErrorHandler:LoggingHandler{
        public ErrorHandler(LoggingHandler nextlogginghandler):base(nextlogginghandler){}
        
        public override void log(string logLevel,string message){
            if(logLevel=="Error"){
                Console.WriteLine($"Error: {message}");
            }
            else if(nextlogginghandler!=null) nextlogginghandler.log(logLevel,message);
        }
    }
}