using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeicoERAService
{
    public class Geolocation
    {

        private double latitude { get; set; }
        private double longitude { get; set; }

        public Geolocation() { }

        public Geolocation(double latitude, double longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }

        // Get the Current location
        public Geolocation GetCurrentLocation()
        { 
            Random longit = new Random();
            Random latitu = new Random();
            return new Geolocation(longit.Next(1,10), latitu.Next(50,90));
        }
        public double GetDistance() 
        {
            return longitude * latitude;
        }
     
      }
            
}
