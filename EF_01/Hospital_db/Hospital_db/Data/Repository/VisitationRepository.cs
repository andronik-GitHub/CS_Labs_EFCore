using Hospital_db.Data.Models;
using Hospital_db.Data.Repository.Interfaces;

namespace Hospital_db.Data.Repository
{
    public class VisitationRepository : IVisitationRepository
    {
        readonly HospitalContext _context;

        public VisitationRepository(HospitalContext context)
        {
            _context = context;
        }


        public IEnumerable<Visitations> GetAll()
        {
            return _context.Visitations.ToList();
        }
        public Visitations? Get(long id)
        {
            return _context.Visitations.FirstOrDefault(
                p => p.VisitationId == id);
        }
        public void Add(Visitations entity)
        {
            _context.Visitations.Add(entity);
            _context.SaveChanges();
        }
        public void Update(Visitations dbEntity, Visitations entity)
        {
            dbEntity.Date = entity.Date;
            dbEntity.Comments = entity.Comments;

            _context.SaveChanges();
        }
        public void Delete(Visitations entity)
        {
            _context.Visitations.Remove(entity);
            _context.SaveChanges();
        }
    }
}
