using Ex11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex11.Configurations
{
    public class MedicamentsConfiguration : IEntityTypeConfiguration<Medicament>
    {
        public void Configure(EntityTypeBuilder<Medicament> builder)
        {
            builder
                .HasKey(e => e.IdMedicament);

            builder
                .Property(e => e.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(e => e.Descrition)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(e => e.Type)
                .HasMaxLength(100)
                .IsRequired();

            var dictMedicaments = new List<Medicament>
            {
                new Medicament { IdMedicament = 1, Name = "APAP", Descrition = "Przykładowy opis Apap", Type = "Przeciwbólowy"},
                new Medicament { IdMedicament = 2, Name = "Ibuprom", Descrition = "Przykładowy opis Ibuprom", Type = "Przeciwbólowy"},
                new Medicament { IdMedicament = 3, Name = "Syropex", Descrition = "Przykładowy opis Sayropexu", Type = "Syrop na kaszel"}
            };

            builder.HasData(dictMedicaments);

        }
    }
}
