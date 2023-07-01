using Microsoft.EntityFrameworkCore;
using library;


public class ListContext : DbContext
{
    public ListContext(DbContextOptions<ListContext> options)
        : base(options)
    {
    }

    public ListContext()
    {
    }
    public DbSet<ToDoItems> items { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source=ToDoList.db");
    }
}