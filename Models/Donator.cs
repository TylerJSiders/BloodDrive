using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDriveDonation.Models
{
    public class Donator
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        
        public string Email { get; set; }
        public long PhoneNumber { get; set; }
        public string State { get; set; }
        public bool Elligible { get; set; }

        public virtual BloodType BloodType { get; set; }
    }
}
