using Ex11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex11.Configurations
{
    public class DoctorsConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder
                .HasKey(e => e.IdDoctor);

            builder
                .Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(e => e.LastName)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(e => e.Email)
                .HasMaxLength(100)
                .IsRequired();

            var dictDoctors = new List<Doctor>
            {
                new Doctor{ IdDoctor = 1, FirstName = "Jan", LastName = "Kowalski", Email = "jan.kowalski@email.com" },
                new Doctor{ IdDoctor = 2, FirstName = "Paweł", LastName = "Nowak", Email = "pawel.nowak@email.com" }
            };

            builder.HasData(dictDoctors);

        }
    }
}
