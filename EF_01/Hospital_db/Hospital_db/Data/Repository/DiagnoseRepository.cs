using Hospital_db.Data.Models;
using Hospital_db.Data.Repository.Interfaces;

namespace Hospital_db.Data.Repository
{
    public class DiagnoseRepository : IDiagnoseRepository
    {
        readonly HospitalContext _context;

        public DiagnoseRepository(HospitalContext context)
        {
            _context = context;
        }


        public IEnumerable<Diagnoses> GetAll()
        {
            return _context.Diagnoses.ToList();
        }
        public Diagnoses? Get(object id)
        {
            return _context.Diagnoses.FirstOrDefault(
                d => d.DiagnoseId == (int)id);
        }
        public void Add(Diagnoses entity)
        {
            _context.Diagnoses.Add(entity);
            _context.SaveChanges();
        }
        public void Update(Diagnoses dbEntity, Diagnoses entity)
        {
            dbEntity.Name = entity.Name;
            dbEntity.Comments = entity.Comments;

            _context.SaveChanges();
        }
        public void Delete(Diagnoses entity)
        {
            _context.Diagnoses.Remove(entity);
            _context.SaveChanges();
        }
    }
}
