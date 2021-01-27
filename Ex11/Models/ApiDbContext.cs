using Ex11.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex11.Models
{
    public class ApiDbContext: DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Doctor> Patients { get; set; }
        public DbSet<Doctor> Prescriptions { get; set; }
        public DbSet<Doctor> Medicaments { get; set; }

        public ApiDbContext() { }

        public ApiDbContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new DoctorsConfiguration());
            modelBuilder.ApplyConfiguration(new MedicamentsConfiguration());
            modelBuilder.ApplyConfiguration(new PatientsConfiguration());
            modelBuilder.ApplyConfiguration(new PresctiptionsConfiguration());
            modelBuilder.ApplyConfiguration(new PrescriptionMedicamentsConfiguration());

        }
        
    }
}
