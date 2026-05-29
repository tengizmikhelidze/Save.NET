using System.ComponentModel.DataAnnotations;

namespace Save.Domain.Models.Bookmark;

public class Bookmark
{
    public int Id { get; set; }
    [Required]
    public int UserId { get; set; }
    public int BookmarkCategoryId { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    [Url]
    public string Url { get; set; }
    public string? Description { get; set; } = String.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; }  = DateTime.UtcNow;
    public DateTime LastModifiedAt { get; set; }  = DateTime.UtcNow;
    public bool IsDeleted { get; set; } = false;
    public bool IsPinned { get; set; } = false;
    public DateTime? PinnedDate { get; set; }
    public static int OpenedCount = 0;

    public override string ToString()
    {
        return $"Bookmark: {Id} - {Title} - {Url}";
    }
}