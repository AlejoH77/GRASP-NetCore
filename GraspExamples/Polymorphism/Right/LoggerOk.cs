namespace GraspExamples.Polymorphism.Right
{
    public class LoggerOk
    {
        LogOk _log;

        public void Error()
        {
            _log.Write(new Error("An error has occurred in the application"));
        }

        public void Info()
        {
            _log.Write(new Info("Information about the application"));
        }
    }
}
