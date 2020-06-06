using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversalLocator.Data;
using UniversalLocator.Models;

namespace UniversalLocator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocatorController : ControllerBase
    {
        private readonly int MINDGRUB_ZIP = 21230;
        private readonly LocatorContext _context;

        public LocatorController(LocatorContext context)
        {
            this._context = context;
        }

        [HttpGet("{zipcode}")]
        [EnableCors("AllowAll")]
        public ActionResult<PlaceResponse> GetPlace(int zipcode)
        {
            PlaceResponse result = null;

            var place = _context.Places
                .Where(place => place.Zipcode == zipcode)
                .FirstOrDefault();

            // if entered zipcode is valid, then calculate the distance from mindgrub
            if (place != null)
            {
                result = new PlaceResponse();
                result.City = place.City;
                result.State = place.State;
                result.Zipcode = place.Zipcode;
                result.Longitude = place.Longitude;
                result.Latitude = place.Latitude;

                // get latitude and longitute of mindgrub's location
                var mindGrub = _context.Places
                    .Where(place => place.Zipcode == MINDGRUB_ZIP)
                    .FirstOrDefault();

                result.DistanceFromMindGrub =
                    DistanceHelper.haversine(mindGrub.Latitude, mindGrub.Longitude, place.Latitude, place.Longitude);
            }

            return result;
        }
    }
}
