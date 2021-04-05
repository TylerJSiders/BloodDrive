using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloodDriveDonation.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BloodDriveDonation.Models.ViewModels
{
    public class MainViewModel
    {
        public List<string> BloodTypes { get; set; }
        public List<Donator> Donators { get; set; }

    }
}
