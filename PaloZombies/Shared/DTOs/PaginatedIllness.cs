using PaloZombies.Shared.Models;
using PaloZombies.Shared.Models.CollectionModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaloZombies.Shared.DTOs
{
    public class PaginatedIllness
    {
        public List<Illness> Illnesses { get; set; }
        public Page Page { get; set; }
        public string ErrorText { get; set; }
    }
}
