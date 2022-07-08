using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraspExamples.Indirection.Right
{
    public class PresenterOk
    {
        private LogService _logService = new LogService();

        public void SomethingHasHappened()
        {
            _logService.Log("Something has happened and we must save the log");
        }

    }
}
