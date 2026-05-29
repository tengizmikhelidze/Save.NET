namespace Save.Application.Bookmark.Queries;

public class GetBookmarksQuery
{
    public int UserId { get; set; }
    public int BookmarkCategoryId { get; set; }
    public string Title { get; set; }
    public string Url { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; } 
    public DateTime LastModifiedAt { get; set; }  
    public bool IsDeleted { get; set; }
    public bool IsPinned { get; set; }
    public DateTime? PinnedDate { get; set; }
    public int OpenedCount;
}