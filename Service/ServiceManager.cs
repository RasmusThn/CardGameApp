using AutoMapper;
using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICardService> _cardService;
        private readonly Lazy<IHandHistoryService> _handHistoryService;
        private readonly Lazy<ICardDeckService> _cardDeckService;
        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger,
            IMapper mapper)
        {
            _cardService = new Lazy<ICardService>(() =>
            new CardService(repositoryManager, logger, mapper));
            _handHistoryService = new Lazy<IHandHistoryService>(() =>
            new HandHistoryService(repositoryManager, logger, mapper));
            _cardDeckService = new Lazy<ICardDeckService>(() =>
            new CardDeckService(repositoryManager, logger, mapper));

        }
        public ICardService CardService => _cardService.Value;
        public ICardDeckService CardDeckService => _cardDeckService.Value;
        public IHandHistoryService HandHistoryService => _handHistoryService.Value;
    }
}
