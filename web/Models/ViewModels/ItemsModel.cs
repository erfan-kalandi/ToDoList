using web.Models;
using System;
namespace web.Models.ViewModels;

public class ToDoModel
{
    public List<ToDoItems> ItemsList{get;set;}
    public ToDoItems todo {get;set;}
}