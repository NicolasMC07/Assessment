using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APiClinique.Models
{
    // class Model
    [Table("Appointments")]
    public class Appointment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int DoctorId { get; set; } 

        [ForeignKey("DoctorId")]
        public Doctor? Doctor { get; set; }

        [Required]
        public int PatientId { get; set; } 

        [ForeignKey("PatientId")]
        public Patient? Patient { get; set; }

        [Column("appointment_date")]
        [Required]
        public DateTime AppointmentDate { get; set; }

        public bool IsCanceled { get; set; }


        // constructor
        public Appointment(int patientId, int doctorId, DateTime appointmentTime, string reason, bool isCanceled)
        {
            PatientId = patientId;
            DoctorId = doctorId;
            AppointmentDate = appointmentTime;
            IsCanceled = isCanceled;
        }
        public Appointment()
        {

        }
    }
}

