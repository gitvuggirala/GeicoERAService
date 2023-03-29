// See https://aka.ms/new-console-template for more information
using GeicoERAService;

Console.WriteLine("Hello, World!");

// Sequence of Steps

//1 .Get Current Location of Customer
//2. Reserve the Assistant
//3. Release the Assistnat
//4. Get Assistant location

Geolocation geoValues = new Geolocation();
Customer customer = new Customer();
Assistant asistant = new Assistant();
Geolocation assistgeoValues = new Geolocation();

RoadSideAssistance  roadSideHelper = new RoadSideAssistance();
asistant = roadSideHelper.reserveAssistant(customer.GetCustomer(), geoValues.GetCurrentLocation());
roadSideHelper.updateAssistantLocation(asistant, assistgeoValues);



Console.WriteLine();
