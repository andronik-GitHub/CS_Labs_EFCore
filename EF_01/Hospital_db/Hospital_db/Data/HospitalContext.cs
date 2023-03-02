using Hospital_db.Data.Configuration;
using Hospital_db.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital_db.Data
{
    public class HospitalContext : DbContext
    {
        public DbSet<Patients> Patients { get; set; }
        public DbSet<Visitations> Visitations { get; set; }
        public DbSet<Diagnoses> Diagnoses { get; set; }
        public DbSet<Medicaments> Medicaments { get; set; }

        public HospitalContext(DbContextOptions optinons)
            : base(optinons)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new PatientMedicamentConfiguration());
        }
    }
}
