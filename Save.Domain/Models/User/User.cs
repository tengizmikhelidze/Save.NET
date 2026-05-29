using System.ComponentModel.DataAnnotations;

namespace Save.Domain.Models.User;

public class User
{
    public int Id { get; set; }
    [EmailAddress]
    public string Email { get; set; }
}