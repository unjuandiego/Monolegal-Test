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
        public void UpdateEstado()
        {
            var filter = Builders<Factura>.Filter.Eq(d => d.Estado, "primerrecordatorio");

            var update = Builders<Factura>.Update.Set(x => x.Estado, "segundorecordatorio");

            var filter1 = Builders<Factura>.Filter.Eq(d => d.Estado, "segundorecordatorio");

            var update2 = Builders<Factura>.Update.Set(x => x.Estado, "desactivado");

            _factura.UpdateMany(filter1, update2);
            _factura.UpdateMany(filter, update);
        }
        public bool FindEstado(string estado) {

            var lista = _factura.Find(d => d.Estado == estado).ToList();
            if (lista == null || lista.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
    }
}
