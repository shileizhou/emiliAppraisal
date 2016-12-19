using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace emiliAppraisal.Models
{
    [Table("Borrower")]
    public class Borrower : Person
     {
        public  Borrower()
        {

        }

        public int addressId { get; set; }
        public int qualifyingId { get; set; }
        public Address currentAddress { get; set; }
        public Qualifying qualifying { get; set; }
        
    }
}
