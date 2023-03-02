using Hospital_db.Data.Models;
using Hospital_db.Data.Repository;
using Hospital_db.Data.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_db.Controllers
{
    [Route("ef/visitation")]
    [ApiController]
    public class VisitationController : ControllerBase
    {
        private readonly IVisitationRepository visitationRepository;

        public VisitationController(IVisitationRepository visitationRepository)
        {
            this.visitationRepository = visitationRepository;
        }


        // GET: ef/visitation
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Visitations> visitations = visitationRepository.GetAll();
            return Ok(visitations);
        }

        // GET: ef/visitation/5
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            Visitations? visitation = visitationRepository.Get(id);
            if (visitation == null)
                return NotFound("The Visitation record couldn't be found.");

            return Ok(visitation);
        }

        // POST: ef/visitation
        [HttpPost]
        public IActionResult Post(Visitations visitation)
        {
            if (visitation == null)
                return BadRequest("Visitation is null.");

            visitationRepository.Add(visitation);

            return CreatedAtRoute(
                  "Get",
                  new { Id = visitation.VisitationId },
                  visitation);
        }

        // PUT: ef/visitation/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, Visitations visitation)
        {
            if (visitation == null)
                return BadRequest("Visitation is null.");

            Visitations? visitationToUpdate = visitationRepository.Get(id);

            if (visitationToUpdate == null)
                return NotFound("The Visitation record couldn't be found.");

            visitationRepository.Update(visitationToUpdate, visitation);
            return NoContent();
        }

        // DELETE: ef/visitation/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Visitations? visitation = visitationRepository.Get(id);

            if (visitation == null)
                return NotFound("The Visitation record couldn't be found.");

            visitationRepository.Delete(visitation);
            return NoContent();
        }
    }
}
