namespace Save.Models.Queries;

public class GetBookmarkById
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int BookmarkCategoryId { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; }  = DateTime.UtcNow;
    public DateTime LastModifiedAt { get; set; }  = DateTime.UtcNow;
    public bool IsDeleted { get; set; } = false;
    public bool IsPinned { get; set; } = false;
    public DateTime? PinnedDate { get; set; }
}