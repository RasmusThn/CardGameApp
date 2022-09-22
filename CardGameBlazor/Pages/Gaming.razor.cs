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
        public List<CardDto> CardsOnHand { get; set; }
        public List<CardDto> CardsDeckList { get; set; } = new List<CardDto>();
        public List<CardDto> TossedCards { get; set; } = new();

        public HandHistoryDto HandHistory { get; set; } =new HandHistoryDto();
        private int counter;
        protected override async Task OnInitializedAsync()
        {
            ShuffleCardList();

            
            
        }
        public async Task TakeCards()
        {
            CardsOnHand = new List<CardDto>();
            CardsOnHand.AddRange(CardsDeckList.Take(5));

            TossedCards.AddRange(CardsOnHand);
            CardsDeckList.RemoveRange(0, 5);

            await AddCardsToHandHistory();

            _showCard = true;
            StateHasChanged();
        }
       public async Task ShuffleCardList()
        {
            
            CardsDeckList = await CardHttpService.GetAllCardsAsync();
            var rnd = new Random();
            CardsDeckList = CardsDeckList.OrderBy(item => rnd.Next()).ToList();
        }
        async Task AddCardsToHandHistory()
        {
            HandHistory.CardIdOne =Convert.ToInt32(CardsOnHand.ElementAt(0).Id);
            HandHistory.CardIdTwo =Convert.ToInt32(CardsOnHand.ElementAt(1).Id);
            HandHistory.CardIdThree =Convert.ToInt32(CardsOnHand.ElementAt(2).Id);
            HandHistory.CardIdFour =Convert.ToInt32(CardsOnHand.ElementAt(3).Id);
            HandHistory.CardIdFive =Convert.ToInt32(CardsOnHand.ElementAt(4).Id);
            counter++;
            HandHistory.Round = counter;

           await HandHistoryHttpService.CreateHandHistoryAsync(HandHistory);
        }
    }
}
