# AddressBookAPI

To run and compile the file correctly, you need to install the following nuggets:   
MongoDB.Driver  
MongoDB.Bson  
NETStandard.Library 

Additionally, .netcore version 5.0 is required (without it there may be a problem in finding and adding parameters, there may be an error that the parameter will have a value of 0, which will cause an error)

The AddressBookAPI.sln file in the AddressBookAPI location is used to start the program. After starting, we have an empty swagger to which we can add a new item using the POST method. There are 4 strings: ID CIty Address and Number to which we assign the parameters provided by the user. There are also GET methods returning all the parameters we have added and GET, where we can check a specific parameter after the Id number Additionally, there are PUT methods thanks to which we can add parameters that can be added only once (the difference between POST is that PUT will not duplicate, much less overwrite parameters) and DELETE, which is used to delete parameters.

