using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraspExamples.Polymorphism.Right
{
    public class LogOk
    {
        public void Write(ILogMessage logMessage)
        {
            Console.WriteLine(logMessage.Value);
        }
    }
}
