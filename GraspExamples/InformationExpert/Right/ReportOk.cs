
namespace GraspExamples.InformationExpert.Wrong
{
    public class ReportOk
    {
        public int[] Exams { get; set; }

        public double CalculateAverage()
        {
            var average = 0;
            foreach (var exam in Exams)
            {
                average += exam;
            }

            return average / Exams.Length;
        }
    }
}
