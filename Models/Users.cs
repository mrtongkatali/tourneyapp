using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tourneyapp.Models;

public class User
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("email", TypeName = "varchar(100)")]
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    // [StringLength(2, ErrorMessage = "Name cannot exceed 2 characters.")]
    public string Email { get; set; } = string.Empty;

    [Column("password", TypeName = "varchar(100)")]
    [Required(ErrorMessage = "Password is required")]
    public string Password { get; set; } = string.Empty;

    [Column("first_name", TypeName = "varchar(50)")]
    public string FirstName { get; set; } = string.Empty;

    [Column("last_name", TypeName = "varchar(50)")]
    public string LastName { get; set; } = string.Empty;

    [Column("created_at")]
    [DataType(DataType.Date)]
    public DateTime CreatedAt { get; set; }
}