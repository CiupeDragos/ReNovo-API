using System.ComponentModel.DataAnnotations;

namespace ReNovo_API.Database.Models;

public class User
{
    public Guid Id { get; set; }

    [Required]
    [MinLength(4)]
    [MaxLength(24)]
    public string Username { get; set; }

    [Required]
    [MinLength(6)]
    public string Password { get; set; }

    [Required]
    [MinLength(3)]
    [MaxLength(20)]
    public string Name { get; set; }

    [Required]
    public DateTime CreatedDate { get; set; }
}
