using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Save.Application.Bookmark.Commands.Create;
using Save.Application.Bookmark.Queries;
using Save.Domain.Models.Bookmark;

[ApiController]
[Route("api/v1/[controller]")]
public class BookmarkController : Controller
{
    private IWebHostEnvironment _environment;
    private IConfiguration _configuration;
    
    public BookmarkController(IWebHostEnvironment environment, IConfiguration configuration)
    {
        _environment = environment;
        _configuration = configuration;
    }
    
    [HttpGet("{bookmarkId}")]
    public IActionResult GetById([FromRoute]int bookmarkId)
    {
        return Ok(_environment.EnvironmentName + " " + _configuration.GetValue<string>("Bookmark", "default") + " " + bookmarkId);
    }
    
    [HttpGet("/api/v1/[controller]s")]
    public IActionResult GetAll([FromQuery]GetBookmarksQuery bookmark)
    {
        return Ok($"{bookmark}");
    }

    [HttpPost]
    public IActionResult Post(
        [FromBody] 
        CreateBookmarkCommand createBookmark)
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