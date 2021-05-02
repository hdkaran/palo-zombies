using MongoDB.Driver;
using PaloZombies.Server.ServerModels;
using PaloZombies.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaloZombies.Server.Repository
{
    public class PatientRepository: IPatientRepository
    {
        private readonly IMongoCollection<Patient> _allPatients;

        public PatientRepository(IPaloDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _allPatients = database.GetCollection<Patient>(settings.CollectionName);
        }

        public Patient Create(Patient patient)
        {
            _allPatients.InsertOne(patient);
            return patient;
        }
    }
}
