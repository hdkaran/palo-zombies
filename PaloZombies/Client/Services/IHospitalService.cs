using PaloZombies.Shared.DTOs;
using PaloZombies.Shared.Models.CollectionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaloZombies.Client.Services
{
    public interface IHospitalService
    {
        Task<PaginatedHospital> GetPaginatedHospital(Page page, int LevelOfPain);
    }
}
