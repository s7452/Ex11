using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex11.Models
{
    public class Medicament
    {
        public int IdMedicament { get; set; }
        public string Name { get; set; }
        public string Descrition { get; set; }
        public string Type { get; set; }

        public ICollection<Prescription_Medicament> Prescriptions_Medicaments { get; set; }
    }
}
