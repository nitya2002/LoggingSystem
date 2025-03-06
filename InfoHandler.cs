namespace LoggingSystem{
    public class InfoHandler:LoggingHandler{
        
        public InfoHandler(LoggingHandler nextlogginghandler): base(nextlogginghandler){
            
        }

        public override void log(string logLevel,string message){
            if(logLevel=="Info"){
                Console.WriteLine($"Info: {message}");
            }
            else if(nextlogginghandler!=null)  nextlogginghandler.log(logLevel,message);
        }
    }
}