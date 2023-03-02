using Hospital_db.Data.Models;
using Hospital_db.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Hospital_db.Data.Repository
{
    public class MedicamentRepository : IMedicamentRepository
    {
        readonly HospitalContext _context;

        public MedicamentRepository(HospitalContext context)
        {
            _context = context;
        }


        public IEnumerable<Medicaments> GetAll()
        {
            return _context.Medicaments.ToList();
        }
        public Medicaments? Get(long id)
        {
            return _context.Medicaments.FirstOrDefault(
                m => m.MedicamentId == id);
        }
        public void Add(Medicaments entity)
        {
            _context.Medicaments.Add(entity);
            _context.SaveChanges();
        }
        public void Update(Medicaments dbEntity, Medicaments entity)
        {
            dbEntity.Name = entity.Name;

            _context.SaveChanges();
        }
        public void Delete(Medicaments entity)
        {
            _context.Medicaments.Remove(entity);
            _context.SaveChanges();
        }
    }
}
