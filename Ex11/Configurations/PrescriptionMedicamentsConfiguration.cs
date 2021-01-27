using Ex11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex11.Configurations
{
    public class PrescriptionMedicamentsConfiguration : IEntityTypeConfiguration<Prescription_Medicament>
    {
        public void Configure(EntityTypeBuilder<Prescription_Medicament> builder)
        {
            builder
                .HasKey(e => new { e.IdPrescription, e.IdMedicament });

            builder
                .Property(e => e.Dose);

            builder
                .Property(e => e.Details)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .HasOne(e => e.Medicament)
                .WithMany(f => f.Prescriptions_Medicaments)
                .HasForeignKey(e => e.IdMedicament);

            builder
                .HasOne(e => e.Prescription)
                .WithMany(f => f.Prescriptions_Medicaments)
                .HasForeignKey(e => e.IdPrescription);

            var dictPrescriptions_Medicaments = new List<Prescription_Medicament>
            {
                new Prescription_Medicament{ IdPrescription = 1, IdMedicament = 1, Dose = 2, Details = "raz dziennie" },
                new Prescription_Medicament{ IdPrescription = 1, IdMedicament = 2, Details = "dwa razy dziennie" }
            };

            builder.HasData(dictPrescriptions_Medicaments);

        }
    }
}
