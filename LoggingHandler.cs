namespace LoggingSystem{
    public abstract class LoggingHandler{
        public LoggingHandler nextlogginghandler;
       
      

        public LoggingHandler(LoggingHandler nextloggingHandler){
            this.nextlogginghandler=nextloggingHandler;
        }

        public abstract void log(string level,string message);
    }
}