using Microsoft.AspNetCore.Mvc;
using UPB.AppLogic.Managers;
using UPB.AppLogic.Models;

namespace UPB.Practice3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly PatientManager _patientManager;

        public PatientController(PatientManager patientManager)
        {
            _patientManager = patientManager;
        }

        [HttpPost]
        public string Post([FromBody] Patient patient)
        {
            return _patientManager.GetPatientCode(patient);
        }
    }
}
