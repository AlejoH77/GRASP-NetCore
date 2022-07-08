namespace GraspExamples.Indirection.Wrong
{
    public class Presenter
    {
        Log4Net _logger;

        public void SomethingHasHappened()
        {
            _logger.Log("Something has happened and we must save the log");
        }

    }
}
