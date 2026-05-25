using System.ComponentModel.DataAnnotations;
using Save.Validators;

namespace Save.Models.Commands;

public class CreateBookmark
{
    public int UserId { get; set; }
    public int BookmarkCategoryId { get; set; }
    [Required(ErrorMessage = "Custom Required Message, {0} can't be empty or null")]
    [Display(Name = "Bookmark Title")]
    public string Title { get; set; }
    [Required]
    [UrlCustomValidator(ErrorMessage = "Custom URL Validation Message, {0} is not a valid URL")]
    public string Url { get; set; }
    public string? Description { get; set; } = String.Empty;
    [DateRangeCustomValidator("22/05/2026", "26/05/2026")]
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }  = DateTime.UtcNow;
    public DateTime LastModifiedAt { get; set; }  = DateTime.UtcNow;
    public bool IsDeleted { get; set; } = false;
    public bool IsPinned { get; set; } = false;
    public DateTime? PinnedDate { get; set; }
    
    public override string ToString()
    {
        return $"CreateBookmark: {UserId} - {Title} - {Url}";
    }
}