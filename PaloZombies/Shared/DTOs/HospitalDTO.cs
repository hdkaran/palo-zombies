using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PaloZombies.Shared.DTOs
{
    public class HospitalDTO
    {
        public int HospitalId { get; set; }
        public string HospitalName { get; set; }
        public double QuotedWaitingTime { get; set; }
    }
}
