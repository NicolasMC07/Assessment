using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APiClinique.Models;
using Microsoft.EntityFrameworkCore;

namespace APiClinique.Sedeers
{
    // Seeder for Appointment
    public class AppointmentSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>().HasData(
                new Appointment { Id = 1, DoctorId = 1, PatientId = 1, AppointmentDate = DateTime.Now.AddDays(1), IsCanceled = false },
                new Appointment { Id = 2, DoctorId = 2, PatientId = 2, AppointmentDate = DateTime.Now.AddDays(2), IsCanceled = false },
                new Appointment { Id = 3, DoctorId = 1, PatientId = 3, AppointmentDate = DateTime.Now.AddDays(3), IsCanceled = false },
                new Appointment { Id = 4, DoctorId = 3, PatientId = 4, AppointmentDate = DateTime.Now.AddDays(4), IsCanceled = false },
                new Appointment { Id = 5, DoctorId = 2, PatientId = 5, AppointmentDate = DateTime.Now.AddDays(5), IsCanceled = false },
                new Appointment { Id = 6, DoctorId = 1, PatientId = 1, AppointmentDate = DateTime.Now.AddDays(6), IsCanceled = false },
                new Appointment { Id = 7, DoctorId = 3, PatientId = 3, AppointmentDate = DateTime.Now.AddDays(7), IsCanceled = false },
                new Appointment { Id = 8, DoctorId = 2, PatientId = 4, AppointmentDate = DateTime.Now.AddDays(8), IsCanceled = false },
                new Appointment { Id = 9, DoctorId = 1, PatientId = 2, AppointmentDate = DateTime.Now.AddDays(9), IsCanceled = false },
                new Appointment { Id = 10, DoctorId = 3, PatientId = 5, AppointmentDate = DateTime.Now.AddDays(10), IsCanceled = false }
            );
        }
    }

}