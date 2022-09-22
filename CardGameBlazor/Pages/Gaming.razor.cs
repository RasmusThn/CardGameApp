using CardGameBlazor.HttpService;
using Microsoft.AspNetCore.Components;
using Shared.DataTransferObjects;
using SharedDtos.DataTransferObjects;

namespace CardGameBlazor.Pages
{
    public partial class Gaming
    {
        private bool _showCard = false;
        [Inject]
        public ICardHttpService? CardHttpService { get; set; }
        [Inject]
        public IHandHistoryHttpService? HandHistoryHttpService { get; set; }
        public List<CardDto> CardsOnHand { get; set; } = new();
        public List<CardDto> CardsDeckList { get; set; } = new();
        public List<CardDto> TossedCards { get; set; } = new();
        public HandHistoryDto HandHistory { get; set; } = new();
        private int _roundCounter;
        

        protected override async Task OnInitializedAsync()
        {

            CardsDeckList = await CardHttpService.GetAllCardsAsync();
            ShuffleCardList();

        }
        public async Task TakeCards()
        {
            
            int cardsToAdd = 5 - CardsOnHand.Count;
            //Adds Remaining cards from deck and shuffles old ones
            if (CardsDeckList.Count < cardsToAdd)
            {
                int cardsLeft = CardsDeckList.Count;
                CardsOnHand.AddRange(CardsDeckList.Take(cardsLeft));
                CardsDeckList.RemoveRange(0, cardsLeft);
                ShuffleTossedCards();
                CardsOnHand.AddRange(CardsDeckList.Take(cardsToAdd - cardsLeft));
            }
            //Adds new cards when enough i Deck
            else
            {
                CardsOnHand.AddRange(CardsDeckList.Take(cardsToAdd));

                CardsDeckList.RemoveRange(0, cardsToAdd);
            }
            
            await AddCardsToHandHistory();

            _showCard = true;
            StateHasChanged();
        }
        private void ShuffleTossedCards()
        {
            CardsDeckList.AddRange(TossedCards);
            ShuffleCardList();
            TossedCards.Clear();
        }

        private void TossCards()
        {

            List<CardDto> tossed = CardsOnHand.Where(t => t.IsActive == true).ToList();

            CardsOnHand.RemoveAll(t => t.IsActive == true);

            foreach (var toss in tossed)
            {
                toss.IsActive = false;
                TossedCards.Add(toss);
            }

            TakeCards();

        }
        private void ShuffleCardList()
        {
            var rnd = new Random();
            CardsDeckList = CardsDeckList.OrderBy(item => rnd.Next()).ToList();
        }
        public async Task AddCardsToHandHistory()
        {
            HandHistory.CardIdOne = Convert.ToInt32(CardsOnHand.ElementAt(0).Id);
            HandHistory.CardIdTwo = Convert.ToInt32(CardsOnHand.ElementAt(1).Id);
            HandHistory.CardIdThree = Convert.ToInt32(CardsOnHand.ElementAt(2).Id);
            HandHistory.CardIdFour = Convert.ToInt32(CardsOnHand.ElementAt(3).Id);
            HandHistory.CardIdFive = Convert.ToInt32(CardsOnHand.ElementAt(4).Id);
            _roundCounter++;
            HandHistory.Round = _roundCounter;

            await HandHistoryHttpService.CreateHandHistoryAsync(HandHistory);
        }
    }
}
