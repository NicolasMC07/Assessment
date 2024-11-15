using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APiClinique.Data;
using APiClinique.Dtos;
using APiClinique.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;

namespace APiClinique.Controllers.AppointmentController
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AppointmentsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Authorize]
        [SwaggerOperation(Summary = "Create a new appointment", Description = "Creates a new appointment record for a specified patient and doctor.")]
        public async Task<IActionResult> CreateAppointment(AppointmentDTO appointmentDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
          
            var newAppointment = new Appointment(
                appointmentDTO.DoctorId,
                appointmentDTO.PatientId,
                appointmentDTO.AppointmentDate
            );

            await _context.Appointments.AddAsync(newAppointment);
            await _context.SaveChangesAsync();

            return Ok(newAppointment);
        }





        [HttpGet]
        [SwaggerOperation(Summary = "Get appointments for a patient or doctor", Description = "Fetches appointments for a specific patient or doctor.")]
        public IActionResult GetAppointments()
        {
            var userId = User.Identity.Name;


            if (string.IsNullOrEmpty(userId) || !int.TryParse(userId, out var userIdInt))
            {
                return Unauthorized("Invalid user ID.");
            }


            var appointments = _context.Appointments
                .Where(a => a.PatientId == userIdInt || a.DoctorId == userIdInt)
                .ToList();

            return Ok(appointments);
        }

        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = "Cancel an appointment", Description = "Cancels an appointment for the specified patient or doctor.")]
        public async Task<IActionResult> CancelAppointment(int id)
        {
            var userId = User.Identity.Name;
            if (string.IsNullOrEmpty(userId) || !int.TryParse(userId, out var userIdInt))
            {
                return Unauthorized("Invalid user ID.");
            }


            var appointment = await _context.Appointments
                .FirstOrDefaultAsync(a => a.Id == id);

            if (appointment == null)
            {
                return NotFound("Appointment not found.");
            }


            if (appointment.PatientId != userIdInt && appointment.DoctorId != userIdInt)
            {
                return Forbid("You do not have permission to cancel this appointment.");
            }


            appointment.IsCanceled = true;


            _context.Appointments.Update(appointment);
            await _context.SaveChangesAsync();


            return Ok("Appointment canceled successfully.");
        }

    }

}