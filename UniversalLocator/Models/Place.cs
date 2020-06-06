using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalLocator.Models
{
    // Place class represts DB entity in Sqllite database
    public class Place
    {
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; } 
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}
