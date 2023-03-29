using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeicoERAService
{
    public class Geolocation
    {

        //latitude coordinate is between -90 and 90.
        //longitude coordinate is between -180 and 180.

        double latitude;
        double longitude;

        public Geolocation() { }
        
        public Geolocation(double latitude, double longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }
       
        public Geolocation GetCurrentLocation()
        { return new Geolocation(33.266669948475354, -96.88488012692407); }

     
        public int GetLocation()
        {
            return
        }
    }
            
}
