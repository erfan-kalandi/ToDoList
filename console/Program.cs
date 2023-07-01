using ListApiCli.Api;
using ListApiCli.Model;
using ListApiCli.Client;
using Microsoft.AspNetCore.SignalR.Client;
using System;
public class program
{
    HubConnection hubConnection;
    Configuration config;
    ListApi apiInstance;
    public static void Main()
    {
        program p = new program();
        p.Start();
    }
    public void Start()
    {
        Console.Clear();
        config = new Configuration() { BasePath = "http://localhost:5051" };
        apiInstance = new ListApi(config);
        hubConnection = new HubConnectionBuilder()
        .WithUrl("http://localhost:5051/HubConnection")
        .Build();//https://localhost:7158
        hubConnection.On("RefreshUI", () =>{});
        hubConnection.StartAsync();
        var input = MainMenu();

        switch (input)
        {
            case "1":
                Add_ToDo();
                Start();
                break;

            case "2":
                Delete_Todo();
                Start();
                break;

            case "3":
                try
                {
                    foreach (var t in apiInstance.ListGet())
                        Console.WriteLine(t);
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("unable to get tasks");
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("for return to main menu enter anything");
                Console.ReadKey();
                Start();
                break;
        }
    }
    public  void Add_ToDo()
    {
        Configuration config = new Configuration() { BasePath = "http://localhost:5051" };
        ListApi apiInstance = new ListApi(config);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Enter your Todo name to add --->");
        Console.ForegroundColor = ConsoleColor.Yellow;
        string Name = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Enter your Todo Details to add --->");
        Console.ForegroundColor = ConsoleColor.Yellow;
        string details = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Green;

        int year = 0;
        string input1 = "0";
        bool situ = true;
        while (situ)
        {
            if (!int.TryParse(input1, out year) || (year < 2022) || (year >=2050))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("how long does it take to do?(Enter your year)");
                Console.ForegroundColor = ConsoleColor.Yellow;
                input1 = Console.ReadLine();
            }
            else
            {
                situ = false;
            }
        }


        int month = 0;
        var input2 = "0";
        situ = true;
        while (situ)
        {
            if (!int.TryParse(input2, out month) || (month < 1) || (month > 12))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("how long does it take to do?(Enter your month)");
                Console.ForegroundColor = ConsoleColor.Yellow;
                input2 = Console.ReadLine();

            }
            else
            {
                situ = false;
            }
        }



        int day = 0;
        var input3 = "0";
        situ = true;
        DateTime date = DateTime.Now;
        while (situ)
        {

            if (!int.TryParse(input3, out day) || (day < 1) || (day > 30))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("how long does it take to do?(Enter your ay)");
                Console.ForegroundColor = ConsoleColor.Yellow;
                input3 = Console.ReadLine();


            }
            else
                situ = false;
        }

        if (month == 2 && day > 28)
            day = 28;

        date = DateTime.Parse($"{month}/{day}/{year}");
        ToDoItems item = new ToDoItems(Name, details, date);
        try
        {
            apiInstance.ListListAddItemPost(item);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("your task succesfully added");
            hubConnection.SendAsync("MakeConnection");
            Thread.Sleep(1500);
        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("failed to add task");
            Thread.Sleep(1500);
        }
        finally
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public  void Delete_Todo()
    {
        Configuration config = new Configuration() { BasePath = "http://localhost:5051" };
        ListApi apiInstance = new ListApi(config);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Enter your ToDo name for delete --->");
        Console.ForegroundColor = ConsoleColor.Yellow;
        string Id = Console.ReadLine();
        try
        {
            apiInstance.ListListDeleteIdiDelete(Id);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("your Todo succesfully deleted");
            hubConnection.SendAsync("MakeConnection");
            Thread.Sleep(1500);
        }
        catch (Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("your task not found");
            Thread.Sleep(1500);
        }
        finally
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public static string MainMenu()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("## ToDo List ##");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("1)Add ToDo Item");
        Console.WriteLine("2)Delete ToDo Item");
        Console.WriteLine("3)Show all ToDos");

        string input = "null";
        for (int i = 0; i < 50; i++)
        {
            Console.WriteLine("// print your number and enter to run command //");
            Console.ForegroundColor = ConsoleColor.Blue;
            input = Console.ReadLine();
            if (input == "1" || input == "2" || input == "3")
                break;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("please print the correct input");
            Console.ForegroundColor = ConsoleColor.Green;
        }
        Console.ForegroundColor = ConsoleColor.White;
        return input;
    }

}