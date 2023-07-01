using System.Diagnostics;
using System;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using web.Models;
using web.Models.ViewModels;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.AspNetCore.SignalR;
using ListApiCli.Client;
using ListApiCli.Api;
using ListApiCli.Model;
namespace web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    Configuration config;
    ListApi Api;
    HubConnection hubConnection;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        config = new Configuration()
        {
            BasePath = "http://localhost:5051"
        };
        Api = new ListApi(config);
        hubConnection = new HubConnectionBuilder()
        .WithUrl("http://localhost:5051/HubConnection")
        .Build();
        hubConnection.On("RefreshUI",() => {Update();});
        hubConnection.StartAsync();
    }

    public RedirectResult Update()
    {
        return Redirect("/");
    }

    public IActionResult Index()
    {
        var ListModel = GetAllToDoItems();
        return View(ListModel);
    }
    public RedirectResult Insert(ToDoModel i)
    {
        if (i.todo.ToDoItemsId != null && i.todo.deadline >= DateTime.Now)
        {
            try
            {
                ListApiCli.Model.ToDoItems item = new ListApiCli.Model.ToDoItems(i.todo.ToDoItemsId, i.todo.Details, i.todo.deadline);
                Api.ListListAddItemPost(item);
                hubConnection.SendAsync("MakeConnection");
            }
            catch
            {
                return Redirect("/");
            }
        }
        return Redirect("/");
    }
    internal ToDoModel GetAllToDoItems()
    {
        List<web.Models.ToDoItems> itemsList = new();
        var items = Api.ListGet();
        foreach (var item in items)
        {

            itemsList.Add(new web.Models.ToDoItems
            {
                ToDoItemsId = item.ToDoItemsId,
                Details = item.Details,
                deadline = item.Deadline
            });
        }
        return new ToDoModel
        {
            ItemsList = itemsList
        };
    }
    public RedirectResult Delete(ToDoModel item)

    {

        if (item.todo.ToDoItemsId != null)
        {
            try
            {
                Api.ListListDeleteIdiDelete(item.todo.ToDoItemsId);
                hubConnection.SendAsync("MakeConnection");
            }
            catch
            {
                return Redirect("/");
            }
        }
        return Redirect("/");

    }
}
