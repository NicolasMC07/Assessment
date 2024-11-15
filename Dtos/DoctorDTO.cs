using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APiClinique.Dtos
{   
    // DTO for Doctor
    public class DoctorDTO
    {
        [Required(ErrorMessage = "El UserId es obligatorio")]
        public int UserId { get; set; }
    }
}