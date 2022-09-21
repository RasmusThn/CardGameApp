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
        private readonly Lazy<ICardDeckRepository> _cardDeckRepository;
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _cardRepository = new Lazy<ICardRepository>(() => new
            CardRepository(repositoryContext));
            _cardDeckRepository = new Lazy<ICardDeckRepository>(() => new
           CardDeckRepository(repositoryContext));
        }
        public ICardRepository Card => _cardRepository.Value;
        public ICardDeckRepository CardDeck => _cardDeckRepository.Value;
        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}
