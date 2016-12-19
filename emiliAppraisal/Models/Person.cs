using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace emiliAppraisal.Models
{
    [Table("Person")]
    public abstract class Person
    {
        protected Person() {}
        public int uid { get; set; }
        public int sin { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime DOB { get; set; }
        public string phoneNo { get; set; }
        public string marriedStatus { get; set; }

    }
}
