using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaloZombies.Shared.Models.CollectionModels
{
    public class CollectionModel
    {
        public Embedded _embedded { get; set; }
        public Link _links { get; set; }
        public Page Page { get; set; }
    }
}
