using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APiClinique.Models;
using Microsoft.EntityFrameworkCore;

namespace APiClinique.Sedeers
{
    // Seeder for User
    public class UserSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "admin", Email = "admin@example.com", Password = "admin123", Role = "admin", CreatedAt = DateTime.Now },
                new User { Id = 2, Name = "doctor one", Email = "doctorone@example.com", Password = "doctor123", Role = "doctor", CreatedAt = DateTime.Now },
                new User { Id = 3, Name = "doctor two", Email = "doctortwo@example.com", Password = "doctor123", Role = "doctor", CreatedAt = DateTime.Now },
                new User { Id = 4, Name = "patient one", Email = "patientone@example.com", Password = "patient123", Role = "patient", CreatedAt = DateTime.Now },
                new User { Id = 5, Name = "patient two", Email = "patienttwo@example.com", Password = "patient123", Role = "patient", CreatedAt = DateTime.Now },
                new User { Id = 6, Name = "patient three", Email = "patientthree@example.com", Password = "patient123", Role = "patient", CreatedAt = DateTime.Now },
                new User { Id = 7, Name = "patient four", Email = "patientfour@example.com", Password = "patient123", Role = "patient", CreatedAt = DateTime.Now },
                new User { Id = 8, Name = "doctor three", Email = "doctorthree@example.com", Password = "doctor123", Role = "doctor", CreatedAt = DateTime.Now },
                new User { Id = 9, Name = "admin user", Email = "adminuser@example.com", Password = "admin123", Role = "admin", CreatedAt = DateTime.Now },
                new User { Id = 10, Name = "patient five", Email = "patientfive@example.com", Password = "patient123", Role = "patient", CreatedAt = DateTime.Now }
            );
        }
    }
}