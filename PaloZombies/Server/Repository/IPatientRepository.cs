using PaloZombies.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaloZombies.Server.Repository
{
    public interface IPatientRepository
    {
        Patient Create(Patient patient);
    }
}
