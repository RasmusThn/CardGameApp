using AutoMapper;
using Contracts;
using Entites.Exceptions;
using Entites.Models;
using Service.Contracts;
using SharedDtos.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class CardService : ICardService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public CardService(IRepositoryManager repository, ILoggerManager logger,IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        
        public async Task<IEnumerable<CardDto>> GetAllCardsAsync(bool trackChanges)
        {
            var cards = await _repository.Card.GetAllCardsAsync(trackChanges);

            var cardsDto = _mapper.Map<IEnumerable<CardDto>>(cards);
           
            return cardsDto;
        }
        public async Task<CardDto> GetCardAsync(int id, bool trackChanges)
        {
            var card = await GetCardAndCheckIfExists(id, trackChanges);
            
            var cardDto = _mapper.Map<CardDto>(card);

            return cardDto;
        }
        public async Task<CardDto> GetRandomActiveCard(bool trackChanges)
        {
            var cards = await _repository.Card.GetAllCardsAsync(trackChanges);
            cards = cards.Where(c => c.IsActive == true);

            Random random = new Random();
            int rndNr = random.Next(0, cards.Count());
            var card = cards.ElementAt(rndNr);

            var cardDto = _mapper.Map<CardDto>(card);

            return cardDto;
        }
        private async Task<Card> GetCardAndCheckIfExists(int id, bool trackChanges)
        {
            var card = await _repository.Card.GetCardAsync(id, trackChanges);
            if (card is null)
                throw new CardNotFoundException(id);
            return card;
        }
    }
}
