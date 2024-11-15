using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APiClinique.Data;
using APiClinique.Dtos;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace APiClinique.Controllers.DoctorController
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DoctorController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPut("/api/doctors/{id}")]
        [SwaggerOperation(Summary = "Update doctor details", Description = "Updates the details of a specific doctor.")]
        public async Task<IActionResult> UpdateDoctor(int id, DoctorDTO doctorDto)
        {
            var doctor = await _context.Doctors.FindAsync(id);

            if (doctor == null)
            {
                return NotFound();
            }

            doctor.UserId = doctorDto.UserId;
            _context.Doctors.Update(doctor);
            await _context.SaveChangesAsync();

            return Ok(doctor);
        }

        [HttpGet("/api/doctors/{id}")]
        [SwaggerOperation(Summary = "Get doctor by ID", Description = "Fetches a doctor by their ID.")]
        public async Task<IActionResult> GetDoctor(int id)
        {
            var doctor = await _context.Doctors.FindAsync(id);

            if (doctor == null)
            {
                return NotFound();
            }

            return Ok(doctor);
        }


    }
}