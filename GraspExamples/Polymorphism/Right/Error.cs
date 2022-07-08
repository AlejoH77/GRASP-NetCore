using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraspExamples.Polymorphism.Right
{
    public class Error : ILogMessage
    {
        private readonly string _message;

        public Error(string message)
        {
            _message = message;
        }

        public string Value => string.Format("[Error];{0}", _message);
    }
}
