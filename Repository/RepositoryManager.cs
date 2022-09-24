using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<ICardRepository> _cardRepository;
        private readonly Lazy<IHandHistoryRepository> _handHistoryRepository;
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _cardRepository = new Lazy<ICardRepository>(() => new
            CardRepository(repositoryContext));
            _handHistoryRepository = new Lazy<IHandHistoryRepository>(() => new
            HandHistoryRepository(repositoryContext));
        }
        public ICardRepository Card => _cardRepository.Value;
        public IHandHistoryRepository HandHistory => _handHistoryRepository.Value;
        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}
