using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraspExamples.Polymorphism.Right
{
    public class Info: ILogMessage
    {
        private readonly string _message;

        public Info(string message)
        {
            _message = message;
        }

        public string Value => string.Format("[Info];{0}", _message);
    }
}
