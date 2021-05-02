using PaloZombies.Shared.DTOs;
using PaloZombies.Shared.Models.CollectionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaloZombies.Client.Services
{
    public interface IIllnessService
    {
        Task<PaginatedIllness> GetPaginatedIllness();
        Task<PaginatedIllness> GetPaginatedIllness(Page page);
    }
}
