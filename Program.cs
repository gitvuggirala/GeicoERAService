// See https://aka.ms/new-console-template for more information
using GeicoERAService;

Console.WriteLine("Welcome to Geico Service Testing!");

// Sequence of Steps

//1 .Get Current Location of Customer
//2. Get List of 5 Emergency Assistant providers based on customer Geo location.
//3. Reserve the Assistant
//4. Release the Assistnat


// Test Data

Customer customer = new Customer(1234,"Satish","3306873593");
Assistant assignedAsistant = new Assistant();

RoadSideAssistance  roadSideAssistHelper = new RoadSideAssistance();
Console.WriteLine("Road Side Assistance Allocation in Progress");

assignedAsistant = roadSideAssistHelper.reserveAssistant(customer, customer.CustomerCurrentLocation());
Console.WriteLine("Road Side Assistant Name - {0} Assigned to Assist Customer {1} ", assignedAsistant.AsssistName, customer.CustomerName);
roadSideAssistHelper.releaseAssistant(customer, assignedAsistant);

if (!roadSideAssistHelper.TrackStatus.ContainsKey(customer.CustomerID))
{
    Console.WriteLine("Assistant- {0} was released from Customer {1}", assignedAsistant.AsssistName, customer.CustomerName);

}

Console.WriteLine("Geico Service Test Successfully Completed");
Console.Read();


