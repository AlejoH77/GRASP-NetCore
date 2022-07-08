
namespace GraspExamples.InformationExpert.Wrong
{
    public class ReporterOk
    {
        readonly ReportOk _report;

        public double SubmitAverage()
        {
            return _report.CalculateAverage();
        }
    }
}
