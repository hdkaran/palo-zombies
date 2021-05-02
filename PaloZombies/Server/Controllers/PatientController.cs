using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaloZombies.Server.Repository;
using PaloZombies.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaloZombies.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientRepository patientRepository;

        public PatientController(IPatientRepository patientRepository)
        {
            this.patientRepository = patientRepository;
        }
   
        [HttpPost]
        public ActionResult<Patient> Create(Patient patient)
        {
            
            patientRepository.Create(patient);
            if (patient==null || patient.Id == null)
                return null;
            return Ok(patient);
        }
    }
}
