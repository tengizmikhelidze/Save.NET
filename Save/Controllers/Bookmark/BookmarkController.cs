using Microsoft.AspNetCore.Mvc;
using Save.Models;
using Save.Models.Commands;

namespace Save.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class BookmarkController : Controller
{
    [HttpGet("{bookmarkId}")]
    public IActionResult GetById([FromRoute]int bookmarkId)
    {
        return Ok();
    }
    
    [HttpGet("/api/v1/[controller]s")]
    public IActionResult GetAll([FromQuery]Bookmark bookmark)
    {
        return Ok($"{bookmark}");
    }

    [HttpPost]
    public IActionResult Post(
        [FromBody] 
        CreateBookmark createBookmark)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return Ok($"{createBookmark}");
    }
    
    [HttpGet("Categories")]
    public IActionResult GetAllCategories()
    {
        return Ok();
    }
    
    [HttpGet("Category/{categoryId}")]
    public IActionResult GetCategory(int categoryId)
    {
        return Ok();
    }
}