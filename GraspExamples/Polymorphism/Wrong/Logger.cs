namespace GraspExamples.Polymorphism.Wrong
{
    public class Logger
    {
        public Log _log;

        public void WriteLog()
        {
            _log.Write("An error has occurred in the application", ErrorType.Error);
        }
    }
}
