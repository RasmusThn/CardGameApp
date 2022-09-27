using CardGameBlazor.HttpService;
using Moq;
using SharedDtos.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameTest.PresentationTest.BlazorTest.HttpServiceTest
{
    public class CardHttpServiceTest
    {
        private readonly Mock<ICardHttpService> _cardHttpMock = new();

        public CardHttpServiceTest()
        {
            _cardHttpMock = new Mock<ICardHttpService>();
        }

        [Fact]
        public async Task GetAllCardsAsyncTest()
        {
            //Arrange

            List<CardDto> cardList = new List<CardDto>()
            {
                new CardDto() { Id = 1 },
                new CardDto() { Id = 2 },
                new CardDto() { Id = 3}
            };

            _cardHttpMock.Setup(x => x.GetAllCardsAsync())
                .ReturnsAsync(cardList);
            //Act

            var result = await _cardHttpMock.Object.GetAllCardsAsync();
            
            //Assert

            Assert.Same(cardList, result);
            //Assert.Equal(new List<CardDto>(), cardList);
            Assert.Equal( cardList, result);
        }
    }
}
