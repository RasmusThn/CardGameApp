using AutoMapper;
using Contracts;
using Entites.Models;
using Service.Contracts;
using SharedDtos.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class CardDeckService : ICardDeckService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CardDeckService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public CardDeckDto CreateCardDeck(CardDeckForCreationDto cardDeck)
        {
            var cardDeckEntity = _mapper.Map<CardDeck>(cardDeck);
            //TODO: Behöver få in CardDeck i Db
            cardDeckEntity = new(cardDeck.CardAmount);
            _repository.CardDeck.CreateCardDeck(cardDeckEntity);
            _repository.SaveAsync();
            var cardDeckReturn = _mapper.Map<CardDeckDto>(cardDeckEntity);

            return cardDeckReturn;
        }
    }
}
