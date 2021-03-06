using CoronaApp.Dal.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoronaApp.Services
{
    public interface IPatientRepository
    {
        //Patient Get(string id);

        //void Save(Patient patient);
        Task PostPatient(Patient patient);
        Task UpdatePatient(Patient patient);
        Task<ICollection<Patient>> GetAllPatient();
    }
}
