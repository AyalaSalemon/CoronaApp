﻿using CoronaApp.Dal.Models;
using CoronaApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoronaApp.Services
{
    public interface IPatientService
    {
        Task PostPatient(PatientDTO patient);
        Task UpdatePatient(PatientDTO patient);
        Task<ICollection<PatientDTO>> GetAllPatient();
    }
}
