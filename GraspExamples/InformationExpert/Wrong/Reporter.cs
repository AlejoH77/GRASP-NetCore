using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraspExamples.InformationExpert.Right
{
    public class Reporter
    {
        readonly Report _report;

        public double SubmitAverage()
        {
            var average = 0;
            foreach (var exam in _report.Exams)
            {
                average += exam;
            }

            return average / _report.Exams.Length;
        }
    }
}
