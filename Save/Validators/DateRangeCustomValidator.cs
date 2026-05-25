using System.ComponentModel.DataAnnotations;

namespace Save.Validators;

public class DateRangeCustomValidator(string dateFrom = "", string dateTo = ""): ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var dateToCheck = (DateTime)value;
        DateTime date_from = DateTime.Parse(dateFrom);
        DateTime date_to = DateTime.Parse(dateTo);
        return date_from <= dateToCheck && date_to >= dateToCheck
            ? ValidationResult.Success!
            : new ValidationResult(ErrorMessage ?? "Custom Date Range Validation Message, Date must be in the future or present");
    }
}