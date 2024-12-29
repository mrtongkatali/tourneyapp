using System.ComponentModel.DataAnnotations;

namespace tourneyapp.Models;

public class User
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Email is required")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "Email is required")]
    public string Password { get; set; } = string.Empty;

    [Required(ErrorMessage = "FirstName is required")]
    public string FirstName { get; set; } = string.Empty;

    [Required(ErrorMessage = "LastName is required")]
    public string LastName { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    public DateTime CreatedAt { get; set; }
}