namespace GraspExamples.Indirection.Right
{
    public class LogService
    {
        private Log4NetOk _log4Net = new Log4NetOk();

        public void Log(string message)
        {
            _log4Net.Log(message);
        }
    }
}
