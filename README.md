# ToDoList

This project is the implementation of a to do list using the C# language,      
which is done in different and coordinated WPF ,console, WEP clients    
and different clients are connected with each other using singalR.

The steps involved in this task are as follows:    
   
1. Create a database class.           
2. Create the relevant database and use the Swagger package.       
3. Establish a connection between the class and the database using the OpenAPI Generator.         
4. Build a WPF client and add the necessary methods.         
5. Build a console client.                  
6. Build a web client using the MVC pattern.                    
7. Set up SignalR in the project for client communication.       

WPF client:               
This client is composed of a queue that includes a list of tasks and sections for adding and removing tasks from the list. Adding each item is done by calling the
Add method, and deletion is done by calling the Delete method in the MainWindow.xaml.cs file. The showItems method is responsible for updating and displaying the
data grid (list of tasks).    
  
Console client:    
When executed, this client displays a menu that performs a specific task based on user input. Each input calls a unique method using a switch statement,     
allowing the user to add, delete, and display the list.     

Web client:     
This client is built using the MVC pattern, which includes three components: models, views, and controllers.     
- Model: Contains classes related to item instances, which are used in the controller.     
- Views: Contains UI-related details. The Index.cshtml file represents the main view. The _Form.cshtml file provides the necessary forms for deleting or      
-  adding items.    
- Controller: Contains project's web methods. These methods are called based on changes in the UI, and they include Insert, Delete, GetAllToDoItems, and Index.    

Index: Responsible for updating the UI after changes in the database.

ListApiCli:
This project is created from a class along with a database. The methods and models created in ListController.cs, ListService.cs, and the class itself allow us
to use them in the clients. It enables adding, deleting, finding items, and retrieving all existing items from the database to our client.
