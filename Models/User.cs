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
    [Table("users")]
    public class User
    {
        // properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Column("email")]
        [Required]
        [StringLength(200)]
        public string? Email { get; set; }

        [Column("password")]
        [Required]
        public string? Password { get; set; }

        [Column("role")]
        [Required]
        [StringLength(20)] 
        public string? Role { get; set; } 

        [Column("created_at")]
        public DateTime CreatedAt { get; set; }

        // contructor
        public User(string name, string email, string password, string role, DateTime createdAt)
        {
            Name = name;
            Email = email;
            Password = password;
            Role = role;
            CreatedAt = createdAt;
        }

        public User()
        {
        }
    }
}