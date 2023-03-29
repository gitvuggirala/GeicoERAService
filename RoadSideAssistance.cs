using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeicoERAService
{
    internal class RoadSideAssistance: RoadsideAssistanceService
    {
        public RoadSideAssistance() { }

        public 
        public SortedSet<Assistant> findNearestAssistants(Geolocation geolocation, int limit)
        {
            SortedSet<Assistant> setAssists = new SortedSet<Assistant>();
            
            for(int iLoop=0; iLoop < limit;  iLoop++)
            {

                Assistant assistantData = new Assistant();
                assistantData.GetAssistant();
                updateAssistantLocation(assistantData, geolocation);
                setAssists.Add(assistantData);
            }
            
          
           return setAssists;
        }

        public void releaseAssistant(Customer customer, Assistant assistant)
        {
            throw new NotImplementedException();
        }

        public Assistant reserveAssistant(Customer customer, Geolocation customerLocation)
        {
            SortedSet<Assistant> assistResult = new SortedSet<Assistant>();

            assistResult= findNearestAssistants(customerLocation, 5);
            return assistResult.First();
            
        }

        public void updateAssistantLocation(Assistant assistant, Geolocation assistantLocation)
        {
            assistant.Driverlocation= assistantLocation.g

            throw new NotImplementedException();
        }
    }
}
