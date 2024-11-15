using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APiClinique.Dtos
{   
    // DTO for Patient
    public class PatientDTO
    {

        [Required(ErrorMessage = "El UserId es obligatorio")]
        public int UserId { get; set; }
    }
}