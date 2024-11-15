using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APiClinique.Models;
using Microsoft.EntityFrameworkCore;

namespace APiClinique.Data
{
    public class AppDbContext : DbContext
    {
        // tables  
        public DbSet<User>? Users { get; set; }
        public DbSet<Doctor>? Doctors { get; set; }
        public DbSet<Patient>? Patients { get; set; }
        public DbSet<Appointment>? Appointments { get; set; }

        // constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Model creating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<User>()
                .HasOne(u => u.Doctor)
                .WithOne(d => d.User)
                .HasForeignKey<Doctor>(d => d.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Patient)
                .WithOne(p => p.User)
                .HasForeignKey<Patient>(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}