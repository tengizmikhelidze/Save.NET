using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Save.Api.Models;
using Save.Application.Bookmark.Commands.Create;
using Save.Application.Bookmark.Queries;
using Save.Domain.Models.Bookmark;

[ApiController]
[Route("api/v1/[controller]")]
public class BookmarkController : Controller
{
    private readonly IWebHostEnvironment _environment;
    private readonly BookmarkConfigOptions _bookmarkConfigOptions;
    
    public BookmarkController(
        IWebHostEnvironment environment
        , IOptions<BookmarkConfigOptions> bookmarkConfigOptions
        )
    {
        _environment = environment;
        _bookmarkConfigOptions = bookmarkConfigOptions.Value;
    }
    
    [HttpGet("{bookmarkId}")]
    public IActionResult GetById([FromRoute]int bookmarkId)
    {
        return Ok(_environment.EnvironmentName + " " + _bookmarkConfigOptions.setting1 + " " + bookmarkId);
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