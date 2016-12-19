using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace emiliAppraisal.Models
{

    public enum Lenders { TD,RBC,ScotiaBank,CIBC}
    public class Application
    {
        public Application()
        {
        }
        public int CMHCNO { get; set; }

        [StringLength(26)]
        public string APIDSTMP { get; set; }
        public string accountStatus { get; set; }
        public DateTime updateTime { get; set; }
        public DateTime createTime { get; set; }
        public Borrower borrower1 { get; set; }
        public Borrower borrower2 { get; set; }
        public Borrower guarantor { get; set; }
        public Property property { get; set; }
        public Lenders lender { get; set; }
        public Loan loan { get; set; }
        public int applicationScore { get; set; }

        public bool CreateApplication(InternalMessage msg)
        {
            int outCMHCNO = 0;

            try
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {

            }

            return true;

        }
    }
}
