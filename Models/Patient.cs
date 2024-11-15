using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APiClinique.Models
{
    // class Model
    [Table("Patients")]
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }

        public ICollection<Appointment>? Appointments { get; set; }

        // Constructor
        public Patient(int userId, List<Appointment>? appointments)
        {
            UserId = userId;
            Appointments = appointments;
        }

        public Patient() { }
    }

}