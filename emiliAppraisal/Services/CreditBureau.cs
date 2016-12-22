using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using emiliAppraisal.Models;

namespace emiliAppraisal.Services
{
    public class CreditBureau
    {
        public int GetCreditScore(Borrower inBorrower)
        {
            int creditScore = 0;

            if  (inBorrower.qualifying.monthAtEmployer > 10)
            {
                creditScore = 680;
            }
            else
            {
                creditScore = 550;
            }
                
            return creditScore;
        }
    }
}
