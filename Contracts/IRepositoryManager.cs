namespace Contracts;

public interface IRepositoryManager
{
    ICardRepository Card { get; }
    ICardDeckRepository CardDeck { get; }
    
   Task SaveAsync();
}
