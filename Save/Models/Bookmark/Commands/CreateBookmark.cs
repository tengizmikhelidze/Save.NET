using System.ComponentModel.DataAnnotations;
using Save.Validators;

namespace Save.Models.Commands;

public class CreateBookmark : IValidatableObject
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
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }  = DateTime.UtcNow;
    public DateTime LastModifiedAt { get; set; }  = DateTime.UtcNow;
    public bool? IsDeleted { get; set; }
    public bool? IsPinned { get; set; }
    public DateTime? PinnedDate { get; set; }
    
    public override string ToString()
    {
        return $"CreateBookmark: {UserId} - {Title} - {Url}";
    }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (IsDeleted.HasValue && IsDeleted.Value)
        {
            if (IsPinned.HasValue && IsPinned.Value)
            {
                yield return new ValidationResult("Custom Validation Message, A deleted bookmark cannot be pinned", new [] { nameof(IsPinned) });
            }
        }
    }
}