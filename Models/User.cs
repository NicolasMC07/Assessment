using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace APiClinique.Models
{
    // class Model
    [Table("Users")]
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }

    [Required]
    [EmailAddress]
    [MaxLength(100)]
    public string? Email { get; set; }

    [Required]
    public string? Password { get; set; }

    [Required]
    public string? Role { get; set; }

    public DateTime CreatedAt { get; set; }

    public Doctor? Doctor { get; set; }
    public Patient? Patient { get; set; }

    // Constructor
    public User(string name, string email, string password, string role, DateTime createdAt)
    {
        Name = name;
        Email = email;
        Password = password;
        Role = role;
        CreatedAt = createdAt;
    }

    public User() { }
}

}