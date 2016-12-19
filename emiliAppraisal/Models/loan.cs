using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emiliAppraisal.Models
{
    public class Loan
    {

        public int loanId { get; set; }
        public double loanAmount { get; set; }
        public double marketValue { get; set; }
        public double LTV { get; set; }

    }
}
