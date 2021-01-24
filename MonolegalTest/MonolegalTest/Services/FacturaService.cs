using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MonolegalTest.Models;
using MongoDB.Bson;

namespace MonolegalTest.Services
{   //Interactuar con la base de datos
    public class FacturaService
    {
        private IMongoCollection<Factura> _factura;
        public FacturaService(IDatabaseSettings settings)
        {
           var cliente = new MongoClient(settings.ConnectionString);
            var database = cliente.GetDatabase(settings.Database);
            _factura = database.GetCollection<Factura>(settings.Collection);
        }
        public List<Factura> Get() {
            return _factura.Find(d => true).ToList();
        }
    }
}
