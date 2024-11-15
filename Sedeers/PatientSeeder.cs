using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APiClinique.Models;
using Microsoft.EntityFrameworkCore;

namespace APiClinique.Sedeers
{
    // Seeder for Patient
public class PatientSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Patient>().HasData(
            new Patient { Id = 1, UserId = 4 },
            new Patient { Id = 2, UserId = 5 },
            new Patient { Id = 3, UserId = 6 },
            new Patient { Id = 4, UserId = 7 },
            new Patient { Id = 5, UserId = 10 }
        );
    }
}
}