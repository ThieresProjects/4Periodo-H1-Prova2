using AutoMapper;
using Revisao.Data.Providers.MongoDb.Collections;
using Revisao.Data.Providers.MongoDb.Interfaces;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System.Collections.Generic;

namespace Revisao.Data.Repository
{
	public class RegistroJogoRepository : IRegistroJogoRepository
    {

		private readonly IMongoRepository<RegistroJogoCollection> _registroJogoRepository;
		private readonly IMapper _mapper;

		public RegistroJogoRepository(IMongoRepository<RegistroJogoCollection> registroJogoRepository,
			IMapper mapper
        )
		{
            _registroJogoRepository = registroJogoRepository;
			_mapper = mapper;
		}

        public IEnumerable<RegistroJogo> ObterTodosOsJogos()
        {
            var ent = _registroJogoRepository.FilterBy(filter => true);
            return _mapper.Map<IEnumerable<RegistroJogo>>(ent);
        }

        public async Task RegistrarJogo(RegistroJogo registroJogo)
        {
            await _registroJogoRepository.InsertOneAsync(_mapper.Map<RegistroJogoCollection>(registroJogo));
        }
    }
}
