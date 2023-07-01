using Microsoft.AspNetCore.Mvc;
using library;
[ApiController]
[Route("[controller]")]
public class ListController : ControllerBase
{
    ListService _service;
    
    public ListController(ListService service)
    {
        _service = service;
    }

    [HttpGet]
    public IEnumerable<ToDoItems> GetAll()
    {
        return _service.GetAll();
    }
    [HttpGet("List/Get/{id}")]
    public ActionResult<ToDoItems> GetById(string id)
    {
        var item = _service.GetItemById(id);

        if(item is not null)
        {
            return item;
        }
        else
        {
            return NotFound();
        }
    }

    [HttpPost("List/AddItem")]
    public IActionResult AddToList(ToDoItems newItem)
    {
        var item = _service.AddItem(newItem);
        return CreatedAtAction(nameof(GetById), new { id = item!.ToDoItemsId }, item);
    }

    [HttpDelete("List/Delete/{idi}")]
    public IActionResult Delete(string idi)
    {
        var item = _service.GetItemById(idi);

        if(item is not null)
        {
            _service.DeleteItemById(idi);
            return Ok();
        }
        else
        {
            return NotFound();
        }
    }
}