using Ex11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex11.Configurations
{
    public class PresctiptionsConfiguration : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder
                .HasKey(e => e.IdPrescription);

            builder
                .Property(e => e.Date)
                .HasColumnType("date")
                .IsRequired();

            builder
                .Property(e => e.DueDate)
                .HasColumnType("date")
                .IsRequired();

            builder
                .HasOne<Patient>(e => e.Patient)
                .WithMany(f => f.Prescriptions)
                .HasForeignKey(e => e.IdPatient);

            builder
                .HasOne<Doctor>(e => e.Doctor)
                .WithMany(f => f.Prescriptions)
                .HasForeignKey(e => e.IdDoctor);

            var dictPrescriptions = new List<Prescription>
            {
                new Prescription { IdPrescription = 1, Date = new DateTime(2021, 01, 02), DueDate = new DateTime(2021, 02, 02), IdDoctor = 1, IdPatient = 2},
                new Prescription { IdPrescription = 2, Date = new DateTime(2021, 01, 11), DueDate = new DateTime(2021, 02, 11), IdDoctor = 2, IdPatient = 2}
            };

            builder.HasData(dictPrescriptions);
        }
    }
}
