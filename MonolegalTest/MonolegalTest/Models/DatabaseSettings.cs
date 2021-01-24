using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonolegalTest.Models
{
	public class DatabaseSettings:IDatabaseSettings
	{
		public string ConnectionString { get; set; }
        public string Database { get; set; }
		public string Collection { get; set; }
	}
	public interface IDatabaseSettings
	{
		
		string ConnectionString { get; set; }
		string Database { get; set; }
        string Collection { get; set; }
	}
}
