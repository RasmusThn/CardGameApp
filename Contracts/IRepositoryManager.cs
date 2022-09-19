namespace Contracts;

public interface IRepositoryManager
{
    ICardRepository Card { get; }
    ICardDeckRepository Deck { get; }
    
    void Save();
}
