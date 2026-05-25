using System.ComponentModel.DataAnnotations;

namespace Save.Models.User;

public class User
{
    public int Id { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    
    public ICollection<Bookmark> Bookmarks { get; set; }
    public ICollection<BookmarkCategory> Categories { get; set; }
}