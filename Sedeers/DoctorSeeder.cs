using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APiClinique.Models;
using Microsoft.EntityFrameworkCore;

namespace APiClinique.Sedeers
{   
    // Doctor Seeder
    public class DoctorSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { Id = 1, UserId = 2 },
                new Doctor { Id = 2, UserId = 3 },
                new Doctor { Id = 3, UserId = 8 }
            );
        }
    }
}