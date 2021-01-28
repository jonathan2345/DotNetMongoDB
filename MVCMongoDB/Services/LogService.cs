using MongoDB.Driver;
using MVCMongoDB.Models;
using System.Collections.Generic;
using System.Linq;

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

        public void Update(string id, Trazabilidad trazabilidad)
        {
            _trazabilidad.ReplaceOne(trazabilidad => trazabilidad.Id == id, trazabilidad);
        }

        public void Delete(string id)
        {
            _trazabilidad.DeleteOne(d => d.Id == id);
        }
    }
}
