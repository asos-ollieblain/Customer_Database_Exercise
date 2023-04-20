using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string? Forename { get; set; }


        public string? Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string? Email { get; set; }

        public Address? Address { get; set; }
        public Contact? Contact { get; set; }
    }
}
