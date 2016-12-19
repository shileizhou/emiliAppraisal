using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emiliAppraisal.Models
{
    public class Appraisal
    {
        public int propertyId { get; set; }
        public DateTime appraisalDate { get; set; }
        public double estimate { get; set; }
    }
}
