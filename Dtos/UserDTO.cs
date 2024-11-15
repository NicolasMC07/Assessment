using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APiClinique.Dtos
{   
    // DTO for User
    public class UserDTO
    {

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede superar los 100 caracteres")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "El correo electrónico es obligatorio")]
        [EmailAddress(ErrorMessage = "El formato del correo electrónico es inválido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [StringLength(100, ErrorMessage = "La contraseña no puede superar los 100 caracteres")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "El rol es obligatorio")]
        [StringLength(50, ErrorMessage = "El rol no puede superar los 50 caracteres")]
        public string? Role { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}