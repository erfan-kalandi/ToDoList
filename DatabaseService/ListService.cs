using Microsoft.EntityFrameworkCore;
using library;
public class ListService
{
    private readonly ListContext _context;
    public ListService(ListContext context)
    {
        _context = context;
    }
    public IEnumerable<ToDoItems> GetAll() => _context.items.AsNoTracking().ToList();
    
    public ToDoItems GetItemById(string? id) => _context.items
        .AsNoTracking()
        .SingleOrDefault(it => it.ToDoItemsId == id);

    public ToDoItems AddItem(ToDoItems newitem)
    {
        _context.items.Add(newitem);
        _context.SaveChanges();
        return newitem;
    }
    public void DeleteItemById(string id)
    {
        var Todelete = _context.items.Find(id);
        if (Todelete is not null)
        {
            _context.items.Remove(Todelete);
            _context.SaveChanges();
        }
    }

}