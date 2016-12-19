using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emiliAppraisal.Models
{
    public class Address
    {
        public int addressId { get; set; }
        public int unitNo { get; set; }
        public string streetNo { get; set; }
        public string streetName { get; set; }
        public string streetType { get; set; }
        public string municipality { get; set; }
        public string province { get; set; }
        public string postalCode { get; set; }

    }
}
