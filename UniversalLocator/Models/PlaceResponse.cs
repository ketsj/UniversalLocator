using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalLocator.Models
{
    // PlaceResponse is used as response class
    public class PlaceResponse
    {
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public double DistanceFromMindGrub { get; set; }
    }
}
