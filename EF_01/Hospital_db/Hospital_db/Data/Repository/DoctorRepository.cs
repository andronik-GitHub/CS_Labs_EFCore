using Hospital_db.Data.Models;
using Hospital_db.Data.Repository.Interfaces;

namespace Hospital_db.Data.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        readonly HospitalContext _context;

        public DoctorRepository(HospitalContext context)
        {
            _context = context;
        }


        public IEnumerable<Doctor> GetAll()
        {
            return _context.Doctors.ToList();
        }
        public Doctor? Get(object id)
        {
            return _context.Doctors.FirstOrDefault(
                d => d.DoctorId == (int)id);
        }
        public void Add(Doctor entity)
        {
            _context.Doctors.Add(entity);
            _context.SaveChanges();
        }
        public void Update(Doctor dbEntity, Doctor entity)
        {
            dbEntity.FirstName = entity.FirstName;
            dbEntity.LastName = entity.LastName;
            dbEntity.Specialty = entity.Specialty;

            _context.SaveChanges();
        }
        public void Delete(Doctor entity)
        {
            _context.Doctors.Remove(entity);
            _context.SaveChanges();
        }
    }
}
