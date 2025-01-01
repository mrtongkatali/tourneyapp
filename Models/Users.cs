using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tourneyapp.Models;

public class User
{
    public int Id { get; set; }
    
    [Column(TypeName = "varchar(100)")]
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    // [StringLength(2, ErrorMessage = "Name cannot exceed 2 characters.")]
    public string Email { get; set; } = string.Empty;

    [Column(TypeName = "varchar(100)")]
    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; } = string.Empty;

    [Column(TypeName = "varchar(50)")]
    public string FirstName { get; set; } = string.Empty;

    [Column(TypeName = "varchar(50)")]
    public string LastName { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    public DateTime CreatedAt { get; set; }
}