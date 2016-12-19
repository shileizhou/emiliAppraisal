using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emiliAppraisal.Models
{
    public class emiliConstants
    {
        private static emiliConstants instance;
        private emiliConstants() {

            appMessage = new Dictionary<int, string>();

            appMessage.Add(00, "Succeed");
            appMessage.Add(01, "Invalid Loan Amount");
            appMessage.Add(02, "No Sufficient Credits");
            appMessage.Add(03, "GDS/TDS Too High");
            appMessage.Add(04, "Property Risk Too High");
            
        }

        private readonly Dictionary<int, string> appMessage;

        public static Dictionary<int, string> AppMessage() {

            if (instance == null)
            {
                instance = new emiliConstants();

            }

            return instance.appMessage;
        }

        public static Dictionary<int, string> TestMsg
        {
            get {
                if (instance == null)
                {
                    instance = new emiliConstants();
                }

                return instance.appMessage;

            }

        }

    }
}
