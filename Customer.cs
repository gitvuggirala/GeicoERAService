using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeicoERAService
{
    public class Customer
    {
       public  string? CustomerName;
       public  string? CustomerPhone;
       public  string? CustomerAddress;
        public Customer GetCustomer()
        {

            Customer custDetails = new Customer { CustomerName = "test", CustomerPhone = "312-234-5679", CustomerAddress = "test" };
            return custDetails;


        }

    }


}
