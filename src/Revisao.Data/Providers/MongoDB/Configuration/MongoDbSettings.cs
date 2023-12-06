using Revisao.Data.Providers.MongoDb.Interfaces;

namespace Revisao.Data.Providers.MongoDb.Configuration
{
	public class MongoDbSettings : IMongoDbSettings
	{
		public string DatabaseName { get; set; }
		public string ConnectionString { get; set; }
	}
}
