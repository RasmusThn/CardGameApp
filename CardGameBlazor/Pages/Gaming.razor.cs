using CardGameBlazor.HttpService;
using Microsoft.AspNetCore.Components;
using SharedDtos.DataTransferObjects;

namespace CardGameBlazor.Pages
{
    public partial class Gaming
    {
        private bool _showCard = false;
        private int _roundCounter;
        [Inject]
        public ICardHttpService? CardHttpService { get; set; }
        [Inject]
        public IHandHistoryHttpService? HandHistoryHttpService { get; set; }
        public List<CardDto> CardsOnHand { get; set; } = new();
        public List<CardDto> CardsDeckList { get; set; } = new();
        public List<CardDto> TossedCards { get; set; } = new();
        public HandHistoryDto? HandHistory { get; set; }
        public List<HandHistoryDto> HandHistoryList { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            CardsDeckList = await CardHttpService.GetAllCardsAsync();
            ShuffleCardList();
        }
        private async Task TakeCards()
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
            List<CardDto> cardsToToss = CardsOnHand.Where(t => t.IsActive == true).ToList();

            CardsOnHand.RemoveAll(t => t.IsActive == true);

            foreach (var toss in cardsToToss)
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
            _roundCounter++;
            HandHistory = new()
            {
                CardImgUrlOne = CardsOnHand.ElementAt(0).ImgUrl,
                CardImgUrlTwo = CardsOnHand.ElementAt(1).ImgUrl,
                CardImgUrlThree = CardsOnHand.ElementAt(2).ImgUrl,
                CardImgUrlFour = CardsOnHand.ElementAt(3).ImgUrl,
                CardImgUrlFive = CardsOnHand.ElementAt(4).ImgUrl,
                Round = _roundCounter
            };
            HandHistoryList.Add(HandHistory);

            await HandHistoryHttpService.CreateHandHistoryAsync(HandHistory);
        }
    }
}
