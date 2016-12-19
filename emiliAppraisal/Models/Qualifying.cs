using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emiliAppraisal.Models
{
    public class Qualifying
    {
        public int qualifyingId { get; set; }
        public int monthAtEmployer { get; set; }
        public int monthAtBank { get; set; }
        public string creditNo { get; set; }
        public int genericScore { get; set; }
        public double GDS { get; set; }
        public double TDS { get; set; }


    }
}
