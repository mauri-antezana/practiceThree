using Serilog;
using System.ComponentModel;
using UPB.AppLogic.Managers.Exceptions;
using UPB.AppLogic.Models;

namespace UPB.AppLogic.Managers
{
    public class PatientManager
    {
        public string GetPatientCode(Patient patient)
        {
            try 
            {
                return $"{patient.Name.Substring(0, 1)}{patient.LastName.Substring(0, 1)}-{patient.Ci}";
            }
            catch(Exception e)
            {
                WrongInputException wiEx = new WrongInputException(e.Message);
                Log.Error(wiEx.GetExceptionMessage());

                throw wiEx;
            }
        }
    }
}
