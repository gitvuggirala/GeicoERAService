using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeicoERAService
{
    internal class RoadSideAssistance: RoadsideAssistanceService
    {
        public Hashtable TrackStatus { get; set; }
        public RoadSideAssistance() {
            TrackStatus = new Hashtable();
        }

         
        public SortedSet<Assistant> findNearestAssistants(Geolocation geolocation, int limit)
        {
            SortedSet<Assistant> setAssists = new SortedSet<Assistant>();

            try
            {

            
                    
                  //  return setAssists;

                   Assistant assistantData = new Assistant();

                    for (int iLoop=0; iLoop < limit;  iLoop++)
                    {

                        assistantData = assistantData.CreateAssistant();
                        updateAssistantLocation(assistantData, geolocation);
                        assistantData.AssistantLocationDistance = geolocation.GetDistance() + iLoop;
                        setAssists.Add(assistantData); 
                    }
            
                  return setAssists;
            }
            catch (Exception ex) {
                Console.WriteLine("Exception occured in FindNearestAssistants Method {0}", ex.Message);
                return setAssists;
            }

        }

        public void releaseAssistant(Customer customer, Assistant assistant)
        {
            try
            {
                TrackStatus.Remove(customer.CustomerID);

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured in releaseAssistant Method {0}", e.Message);
                return;
            }



        }

        public Assistant reserveAssistant(Customer customer, Geolocation customerLocation)
        {

            try
            {
                SortedSet<Assistant> assistResult = new SortedSet<Assistant>();
                assistResult = findNearestAssistants(customerLocation, 5);
                TrackStatus.Add(customer.CustomerID, assistResult.First().AssistID);
                return assistResult.First();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured in reserveAssistant Method {0}", e.Message);
                Assistant tempAssist = new Assistant();
                tempAssist.AssistID = (int)TrackStatus[customer.CustomerID];
                return tempAssist;

            }
        }

        public void updateAssistantLocation(Assistant assistant, Geolocation assistantLocation)
        {
            try
            {
                assistantLocation = assistant.AssistantCurrentLocation();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured in updateAssistantLocation Method {0}", e.Message);
                return;
            }


        }
    }
}
