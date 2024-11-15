using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APiClinique.Dtos
{
    // DTO for Appointment
    public class AppointmentDTO
    {

        [Required(ErrorMessage = "La fecha de la cita es obligatoria")]
        public DateTime AppointmentDate { get; set; }

        public bool IsCanceled { get; set; } = false;
        
        [Required(ErrorMessage = "El DoctorId es obligatorio")]
        public int DoctorId { get; set; }

        [Required(ErrorMessage = "El PatientId es obligatorio")]
        public int PatientId { get; set; }
    }
}