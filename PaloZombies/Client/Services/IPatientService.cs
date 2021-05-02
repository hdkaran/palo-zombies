using PaloZombies.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaloZombies.Client.Services
{
    public interface IPatientService
    {
        Task<Patient> SavePatient(Patient patient);
    }
}
