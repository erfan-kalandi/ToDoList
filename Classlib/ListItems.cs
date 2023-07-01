namespace library;

public class ToDoItems
{
    public ToDoItems(string toDoItemsId,string details,DateTime deadline)
    {
        ToDoItemsId = toDoItemsId;
        Details = details;
        this.deadline = deadline;
    }
    public string ToDoItemsId{get;set;}
    public string Details{get;set;}
    public DateTime deadline{get;set;}
}