using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalLocator.Models
{
    // Wrapper class used to serialize zipcode dataset in json into c# objects
    public class PlaceWrapper
    {
        public string datasetid { get; set; }
        public PlaceField fields { get; set; }
    }

    public class PlaceField
    {
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
    }
}
