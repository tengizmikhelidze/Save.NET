using Microsoft.AspNetCore.Mvc;

namespace Save.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class BookmarkController : Controller
{
    [HttpGet("{id}")]
    public IActionResult GetById(string id)
    {
        return View();
    }
    
    [HttpGet("/api/v1/[controller]s")]
    public IActionResult GetAll()
    {
        return View();
    }
}