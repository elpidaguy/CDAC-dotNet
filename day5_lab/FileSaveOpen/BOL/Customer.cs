using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    [Serializable]      //attribute serializable for making it serializable
    public class Customer
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
