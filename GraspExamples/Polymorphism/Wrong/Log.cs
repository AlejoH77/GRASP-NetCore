using System;

namespace GraspExamples.Polymorphism.Wrong
{
    public class Log
    {
        public void Write(string message, ErrorType errorType)
        {
            switch (errorType)
            {
                case ErrorType.Info:
                    Console.WriteLine("[Info];{0}", message);
                    break;
                case ErrorType.Error:
                    Console.WriteLine("[Error];{0}", message);
                    break;
            }
        }
    }
}
