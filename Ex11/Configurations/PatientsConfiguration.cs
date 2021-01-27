using Ex11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex11.Configurations
{
    public class PatientsConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder
                .HasKey(e => e.IdPatient);

            builder
                .Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(e => e.LastName)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(e => e.Birthdate)
                .HasColumnType("date")
                .IsRequired();


            var dictPatients = new List<Patient>
            {
                new Patient { IdPatient = 1, FirstName = "Dariusz", LastName = "Nowakowski", Birthdate = new DateTime(1995, 05, 22) },
                new Patient { IdPatient = 2, FirstName = "Halina", LastName = "Nowak", Birthdate = new DateTime(1990, 03, 21) },
                new Patient { IdPatient = 3, FirstName = "Patrycja", LastName = "Kowal", Birthdate = new DateTime(2000, 06, 2) },
                new Patient { IdPatient = 4, FirstName = "Wojciech", LastName = "Piotrowski", Birthdate = new DateTime(2000, 06, 2) }
            };

            builder.HasData(dictPatients);
        }
    }
}
