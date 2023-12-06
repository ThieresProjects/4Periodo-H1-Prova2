using AutoMapper;
using Revisao.Data.Providers.MongoDb.Collections;
using Revisao.Domain.Entities;

namespace H1Store.Catalogo.Data.AutoMapper
{
	public class DomainToCollection : Profile
	{
		public DomainToCollection()
		{
			CreateMap<RegistroJogo, RegistroJogoCollection>();
		}
	}
}