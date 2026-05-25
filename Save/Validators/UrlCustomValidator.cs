using System.ComponentModel.DataAnnotations;

namespace Save.Validators;

public class UrlCustomValidator: ValidationAttribute
{
    protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {
        if(value is string url)
        {
            if (Uri.TryCreate(url, UriKind.Absolute, out var uriResult) && 
                (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
            {
                return ValidationResult.Success!;
            }
            else
            {
                return new ValidationResult(ErrorMessage ?? "Invalid URL format");
            }
        }
        
        return new ValidationResult(ErrorMessage ?? "Other Error In Custom Url Validator");
    }
}