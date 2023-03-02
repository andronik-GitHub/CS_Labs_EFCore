using Hospital_db.Data.Models;
using Hospital_db.Data.Repository.Interfaces;

namespace Hospital_db.Data.Repository
{
    public class PatientRepository : IPatientRepository
    {
        readonly HospitalContext _context;

        public PatientRepository(HospitalContext context)
        {
            _context = context;
        }


        public IEnumerable<Patients> GetAll()
        {
            return _context.Patients.ToList();
        }
        public Patients? Get(object id)
        {
            return _context.Patients.FirstOrDefault(
                p => p.PatientId == (int)id);
        }
        public void Add(Patients entity)
        {
            _context.Patients.Add(entity);
            _context.SaveChanges();
        }
        public void Update(Patients dbEntity, Patients entity)
        {
            dbEntity.FirstName = entity.FirstName;
            dbEntity.LastName = entity.LastName;
            dbEntity.Address = entity.Address;
            dbEntity.Email = entity.Email;
            dbEntity.HasInsurance = entity.HasInsurance;

            _context.SaveChanges();
        }
        public void Delete(Patients entity)
        {
            _context.Patients.Remove(entity);
            _context.SaveChanges();
        }
    }
}
