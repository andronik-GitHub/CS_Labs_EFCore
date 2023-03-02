using Hospital_db.Data.Models;
using Hospital_db.Data.Repository.Interfaces;
using System.Diagnostics;

namespace Hospital_db.Data.Repository
{
    public class PatientMedicamentRepository : IPatientMedicamentRepository
    {
        readonly HospitalContext _context;

        public PatientMedicamentRepository(HospitalContext context)
        {
            _context = context;
        }


        public IEnumerable<PatientMedicament> GetAll()
        {
            return _context.Prescriptions.ToList();
        }
        public PatientMedicament? Get(object obj)
        {
            return _context.Prescriptions.FirstOrDefault(
                pm => 
                    pm.MedicamentId == ((PatientMedicament)obj).MedicamentId &&
                    pm.PatientId == ((PatientMedicament)obj).PatientId);
        }
        public void Add(PatientMedicament entity)
        {
            _context.Prescriptions.Add(entity);
            _context.SaveChanges();
        }
        public void Update(PatientMedicament dbEntity, PatientMedicament entity)
        {
            dbEntity.PatientId = entity.PatientId;
            dbEntity.MedicamentId = entity.MedicamentId;

            _context.SaveChanges();
        }
        public void Delete(PatientMedicament entity)
        {
            _context.Prescriptions.Remove(entity);
            _context.SaveChanges();
        }
    }
}
