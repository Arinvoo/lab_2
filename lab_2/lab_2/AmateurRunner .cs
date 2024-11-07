using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2
{
    public class AmateurRunner : IRunner
    {
        public string GetRunnerType() => "Amateur Runner";
    }

    public class ProfessionalRunner : IRunner
    {
        public string GetRunnerType() => "Professional Runner";
    }

}
