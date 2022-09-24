namespace Contracts;

public interface IRepositoryManager
{
    ICardRepository Card { get; }
    IHandHistoryRepository HandHistory { get; }
   Task SaveAsync();
}
