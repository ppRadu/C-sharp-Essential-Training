using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    class ScienceExperiment : IScored
    {
        public string Hypothesis { get; set; }
        public string Materials { get; set; }
        public string Method { get; set; }
        public string Conclusion { get; set; }
        public float Score { get; set; }
        public float MaximumScore { get; set; }
    }
}
