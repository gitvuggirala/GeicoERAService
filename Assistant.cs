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
        public string? AsssistName;
        public int AssistID;
        public double Assistlocation;
  
        public Assistant GetAssistant()
        {
            Random rnd = new Random();
            Assistant assistant = new Assistant();
            assistant.AsssistName = "Assistant"+ rnd.Next(); 
            assistant.AssistID = rnd.Next();
            return assistant;
  
        }

    }



}
