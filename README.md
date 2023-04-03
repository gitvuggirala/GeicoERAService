# GeicoERAService



Assumptions:

1. As per instructions, persistance data is not strictly needed. Hence, managing with dummy data.
2. As per instructions, REST API is not strictly needed, hence, implemented code using a Console app.
3. Emergency Assistance Service trucks location data generated and tested.
4. Interacting with live Geo data is out of scope, due to this, created a dummy data.
5. There is no information about Testing Framework. Hence, created a test scenario in console app. 
6. Assumed the following flow to use RoadsideAssistance Service Class.

//1 .Get the Current Location of Customer
//2. Get List of 5 Emergency Assistant providers based on customer Geo location.
//3. Reserve the Assistant
//3. Release the Assistnat

We don't have a persistent data or Redis Cache mechanism, Due to this, tracked the allocation/de-allocation using Hash Table Data Structure


Build Instructions:

dotnet msbuild GeicoERAService.sln -property:configuration=release

Run the Applicaiton
GeicoERAService.exe

![image](https://user-images.githubusercontent.com/104606095/229423181-ef0ac0b9-2d02-4d34-8cce-2d238f0e97d3.png)
