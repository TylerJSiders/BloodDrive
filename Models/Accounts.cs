using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDriveDonation.Models
{
    public class Accounts
    {
        [Key]
        public string Email { get; set; }
        public string Pass { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool CanUpdateRecords { get; set; }
    }
}
