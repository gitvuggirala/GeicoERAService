using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeicoERAService
{
    public class Customer
    {
       public  string CustomerName { get; set; }
       public  string CustomerPhone { get; set; }
       public int CustomerID{ get; set; }
        public Customer (int customerID, string CustomerName, string CustomerPhone)
        {
            this.CustomerName = CustomerName;
            this.CustomerPhone = CustomerPhone;
            this.CustomerID = customerID;
             
        }

        public Geolocation CustomerCurrentLocation()
        {
            Geolocation geolocation = new Geolocation();
            return geolocation.GetCurrentLocation();
        }

    }


}
