using AutoMapper;
using Revisao.Data.Providers.MongoDb.Collections;
using Revisao.Domain.Entities;

namespace Revisao.Data.AutoMapper
{
	public class CollectionToDomain : Profile
	{
		public CollectionToDomain()
		{
			CreateMap<RegistroJogoCollection, RegistroJogo>()
			   .ConstructUsing(q => new RegistroJogo(q.primeiroNumero, q.segundoNumero, q.terceiroNumero, q.quartoNumero, q.quintoNumero, q.sextoNumero));
		}
	}
}
