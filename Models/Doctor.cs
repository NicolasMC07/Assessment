using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APiClinique.Models
{   
    // class Model
    [Table("doctors")]
    public class Doctor
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

        [Column("appointments")]
        [Required]  
        public List<Appointment>? Appointments { get; set; }

        //constructor
        public Doctor(string name, List<Appointment>? appointments)
        {
            Name = name;
            Appointments = appointments;
        }

        public Doctor()
        {
            
        }
    }
}