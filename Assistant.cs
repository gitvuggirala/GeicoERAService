using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GeicoERAService
{
    public class Assistant : IComparable<Assistant>
    {
        public string AsssistName { get; set; }
        public int AssistID { get; set; }
        public double AssistantLocationDistance { get; set; }

        
        public Assistant CreateAssistant()
        {
            Random rnd = new Random();
        
            Assistant assistant = new Assistant();
            assistant.AsssistName = "Assistant"+ rnd.Next(); 
            assistant.AssistID = rnd.Next();
            return assistant;
  
        }

        public int CompareTo(Assistant? second)
        {
            if (second == null)
            {
                return 1;
            }

            return this.AssistantLocationDistance.CompareTo(second.AssistantLocationDistance);
        }

        public Geolocation AssistantCurrentLocation()
        {
            Geolocation geolocation = new Geolocation();
            return geolocation.GetCurrentLocation();
        }



    }







}
