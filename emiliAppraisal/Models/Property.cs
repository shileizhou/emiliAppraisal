using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emiliAppraisal.Models
{
    public class Property
    {
        public int propertyId { get; set; }
        public Address address { get; set; }
        public int age { get; set; }
        public string propertyType { get; set; }
        public bool newBuild { get; set; }

    }
}
