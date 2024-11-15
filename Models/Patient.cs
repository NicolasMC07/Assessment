using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APiClinique.Models
{   
    // class Model
    [Table("patients")]
    public class Patient
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

        [Column("phone_number")]
        [Required]
        [StringLength(15)]
        public string? PhoneNumber { get; set; }

        [Column("appointments")]
        [Required]  
        public List<Appointment>? Appointments { get; set; }

        // constructor
        public Patient(string name, string email, string phoneNumber, List<Appointment>? appointments)
        {                                                                                                                                                                       
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Appointments = appointments;
        }

        
        Patient()
        {
            
        }
    }
}