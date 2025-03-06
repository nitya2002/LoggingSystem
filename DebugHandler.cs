namespace LoggingSystem{
    public class DebugHandler:LoggingHandler{
        public DebugHandler(LoggingHandler nextlogginghandler):base(nextlogginghandler){}
        public override void log(string logLevel,string message){
            if(logLevel=="Debug"){
                Console.WriteLine($"Debug: {message}");
            }
            else if(nextlogginghandler!=null)  nextlogginghandler.log(logLevel,message);
        }
    }
}