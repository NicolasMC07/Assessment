using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APiClinique.Models
{   
    // class Model
    [Table("appointments")]
    public class Appointment
    {   
        // properties
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("patient_id")]
        public int PatientId { get; set; }

        [ForeignKey("PatientId")]
        public Patient? Patient { get; set; } 

        [Column("doctor_id")]
        public int DoctorId { get; set; }

        [ForeignKey("DoctorId")]
        [Required]
        public Doctor? Doctor { get; set; } 

        [Column("appointment_time")]
        [Required]
        public DateTime AppointmentTime { get; set; } 

        [Column("reason")]
        [Required]
        public string? Reason { get; set; } 

        [Column("is_canceled")]
        public bool IsCanceled { get; set; }

        // constructor
        public Appointment(int patientId, int doctorId, DateTime appointmentTime, string reason, bool isCanceled)
        {
            PatientId = patientId;
            DoctorId = doctorId;
            AppointmentTime = appointmentTime;
            Reason = reason;
            IsCanceled = isCanceled;
        }
        public Appointment()
        {
            
        }
    }
}
