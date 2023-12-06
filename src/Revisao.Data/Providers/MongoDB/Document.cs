
using MongoDB.Bson;
using Revisao.Data.Providers.MongoDb.Interfaces;

namespace Revisao.Data.Providers.MongoDb
{
	public abstract class Document  : IDocument
	{ 
		
		public ObjectId Id { get; set; }

		public DateTime CreatedAt => Id.CreationTime;
	}
}
