using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int MobileNumber { get; set; }
        public int? HomeNumber { get; set; }
    }
}
