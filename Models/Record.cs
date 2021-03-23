using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDriveDonation.Models
{
    public class Record
    {
        public int ID { get; set; }
        public virtual Donator Donator { get; set; }
        public DateTime DateDonated { get; set; }
    }
}
