
using CardLibrary.CardDeck;



CardDeck cards = new (52);
foreach (var item in cards.CardsList)
{
    item.GetCard();
}
