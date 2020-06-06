using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalLocator
{
    public static class DistanceHelper
    {
        // Calculates harvsine distance between a given pair of latitude and longitude
        public static double haversine(double lat1, double lon1,
                        double lat2, double lon2)
        {
            double dLat = (Math.PI / 180) * (lat2 - lat1);
            double dLon = (Math.PI / 180) * (lon2 - lon1);

            double a = Math.Pow(Math.Sin(dLat / 2), 2) +
                       Math.Pow(Math.Sin(dLon / 2), 2) *
                       Math.Cos((Math.PI / 180) * (lat1)) * Math.Cos((Math.PI / 180) * (lat2));
            double rad = 6371;
            double c = 2 * Math.Asin(Math.Sqrt(a));
            // return distance in miles
            double result = (rad * c) / 1.6;
            return Math.Round(result, 2);

        }
    }
}
