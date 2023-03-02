using Hospital_db.Data.Models;
using Hospital_db.Data.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_db.Controllers
{
    [Route("ef/patient")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientRepository patientRepository;

        public PatientController(IPatientRepository patientRepository)
        {
            this.patientRepository = patientRepository;
        }


        // GET: ef/patient
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Patients> patients = patientRepository.GetAll();
            return Ok(patients);
        }

        // GET: ef/patient/5
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            Patients? patient = patientRepository.Get(id);
            if (patient == null)
                return NotFound("The Patient record couldn't be found.");

            return Ok(patient);
        }

        // POST: ef/patient
        [HttpPost]
        public IActionResult Post(Patients patient)
        {
            if (patient == null)
                return BadRequest("Patient is null.");

            patientRepository.Add(patient);

            return CreatedAtRoute(
                  "Get",
                  new { Id = patient.PatientId },
                  patient);
        }

        // PUT: ef/patient/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, Patients patient)
        {
            if (patient == null)
                return BadRequest("Patient is null.");

            Patients? patientToUpdate = patientRepository.Get(id);

            if (patientToUpdate == null)
                return NotFound("The Patient record couldn't be found.");

            patientRepository.Update(patientToUpdate, patient);
            return NoContent();
        }

        // DELETE: ef/patient/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Patients? patient = patientRepository.Get(id);

            if (patient == null)
                return NotFound("The Patient record couldn't be found.");

            patientRepository.Delete(patient);
            return NoContent();
        }
    }
}
