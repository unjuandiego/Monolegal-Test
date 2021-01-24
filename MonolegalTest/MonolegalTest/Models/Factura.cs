using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace MonolegalTest.Models
{
	public class Factura
	{
		[BsonElement("CodigoFactura")]
		public string CodigoFactura { get; set; }
		[BsonElement("Cliente")]
		public string Cliente { get; set; }
		[BsonElement("Ciudad")]
		public string Ciudad { get; set; }
		[BsonElement("NIT")]
		public string NIT { get; set; }
		[BsonElement("TotalFactura")]
		public double TotalFactura { get; set; }
		[BsonElement("SubTotal")]
		public double SubTotal { get; set; }
		[BsonElement("IVA")]
		public double IVA { get; set; }
		[BsonElement("Retencion")]
		public double Retencion { get; set; }
		[BsonElement("FechaCreacion")]
		public DateTime FechaCreacion { get; set; }
		[BsonElement("Estado")]
		public string Estado { get; set; }
		[BsonElement("Pagada")]
		public Boolean Pagada { get; set; }
		[BsonElement("FechaPago")]
		public DateTime FechaPago { get; set; }

	}
}
