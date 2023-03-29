using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GeicoERAService
{
    public  class Assistant
    {
        public string? DriverName;
        public int DriverID;
        public double Driverlocation;
  
        public Assistant GetAssistant()
        {
            Random rnd = new Random();
            Assistant assistant = new Assistant();
            assistant.DriverName = "Assistant"+ rnd.Next(); 
            assistant.DriverID = rnd.Next();
            return assistant;
  
        }

    }



}
