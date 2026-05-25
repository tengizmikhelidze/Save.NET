using Microsoft.AspNetCore.Mvc;

namespace Save.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class BookmarkController : Controller
{
    [HttpGet("{bookmarkId}")]
    public IActionResult GetById(string bookmarkId)
    {
        return View();
    }
    
    [HttpGet("/api/v1/[controller]s")]
    public IActionResult GetAll()
    {
        return View();
    }
    
    [HttpGet("Categories")]
    public IActionResult GetAllCategories()
    {
        return View();
    }
    
    [HttpGet("Category/{categoryId}")]
    public IActionResult GetCategory(int categoryId)
    {
        return View();
    }
}