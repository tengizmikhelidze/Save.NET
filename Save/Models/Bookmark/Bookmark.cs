namespace Save.Models;

public class Bookmark
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int BookmarkCategoryId { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime LastModifiedAt { get; set; }
    public bool IsDeleted { get; set; }
}