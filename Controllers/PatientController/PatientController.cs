using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APiClinique.Data;
using APiClinique.Dtos;
using APiClinique.Models;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace APiClinique.Controllers.PatientController
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PatientController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("/api/patients")]
        [SwaggerOperation(Summary = "Create a new patient", Description = "Creates a new patient and associates them with a user.")]
        public async Task<IActionResult> CreatePatient(PatientDTO patientDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newPatient = new Patient
            {
                UserId = patientDto.UserId,
                Appointments = new List<Appointment>() 
            };

            await _context.Patients.AddAsync(newPatient);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPatient), new { id = newPatient.Id }, newPatient);
        }

        [HttpGet("/api/patients/{id}")]
        [SwaggerOperation(Summary = "Get patient by ID", Description = "Fetches a patient by their ID.")]
        public async Task<IActionResult> GetPatient(int id)
        {
            var patient = await _context.Patients.FindAsync(id);

            if (patient == null)
            {
                return NotFound();
            }

            return Ok(patient);
        }

    }
}