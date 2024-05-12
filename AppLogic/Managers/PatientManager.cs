using UPB.AppLogic.Models;

namespace UPB.AppLogic.Managers
{
    public class PatientManager
    {
        private Patient _patient;

        public string GetPatientCode(Patient patient)
        {
            return $"{patient.Name.Substring(0, 1)}{patient.LastName.Substring(0, 1)}-{patient.Ci}";
        }
    }
}
