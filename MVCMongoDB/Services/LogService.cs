using MongoDB.Driver;
using MVCMongoDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCMongoDB.Services
{
    public class LogService
    {
        private IMongoCollection<Trazabilidad> _trazabilidad;

        public LogService(ILogSettings settings)
        {
            var cliente = new MongoClient(settings.Server);
            var database = cliente.GetDatabase(settings.Database);
            _trazabilidad = database.GetCollection<Trazabilidad>(settings.Collection);
        }

        public List<Trazabilidad> Get()
        {
            return _trazabilidad.Find(d => true).ToList();
        }

        public Trazabilidad Create(Trazabilidad trazabilidad)
        {
            _trazabilidad.InsertOne(trazabilidad);
            return trazabilidad;
        }
    }
}
